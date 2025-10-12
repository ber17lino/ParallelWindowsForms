using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using System.Windows.Forms;

namespace ParallelProcessingApp
{
    public static class Task3
    {
        public static async Task RunLinqVsPlinqAsync(int employeeCount, RichTextBox output)
        {
            Utils.AppendText(output, $" Генерация данных для {employeeCount} сотрудников...");
            var employees = GenerateEmployees(employeeCount);

            var totalOrders = employees.Sum(e => e.Orders.Count);
            Utils.AppendText(output, $" Сгенерировано: {employees.Count} сотрудников, {totalOrders} заказов");
            Utils.AppendText(output, "");

            string prefix = "A";
            DateTime cutoff = DateTime.Now.AddYears(-1);

            await BenchmarkAsync(" Запрос 1: Имена начинаются с '" + prefix + "'",
                () => employees.Where(e => e.FullName.StartsWith(prefix)).SelectMany(e => e.Orders).ToList(),
                () => employees.AsParallel().Where(e => e.FullName.StartsWith(prefix)).SelectMany(e => e.Orders).ToList(),
                output);

            await BenchmarkAsync(" Запрос 2: Заказы после " + cutoff.ToString("yyyy-MM-dd"),
                () => employees.SelectMany(e => e.Orders).Where(o => o.Date > cutoff).ToList(),
                () => employees.AsParallel().SelectMany(e => e.Orders).Where(o => o.Date > cutoff).ToList(),
                output);

            await BenchmarkAsync(" Запрос 3: Сотрудники по средней сумме заказов (по убыванию)",
                () => employees.Where(e => e.Orders.Any())
                               .Select(e => new { e.FullName, Avg = e.Orders.Average(o => o.Amount) })
                               .OrderByDescending(x => x.Avg).ToList(),
                () => employees.AsParallel().Where(e => e.Orders.Any())
                               .Select(e => new { e.FullName, Avg = e.Orders.Average(o => o.Amount) })
                               .OrderByDescending(x => x.Avg).ToList(),
                output);
        }

        private static List<Employee> GenerateEmployees(int count)
        {
            var faker = new Faker();
            var list = new List<Employee>();
            for (int i = 0; i < count; i++)
            {
                var emp = new Employee
                {
                    Id = i,
                    FullName = faker.Name.FullName()
                };
                int orderCount = Random.Shared.Next(50, 101);
                for (int j = 0; j < orderCount; j++)
                {
                    emp.Orders.Add(new OrderSimple
                    {
                        Id = j,
                        Date = faker.Date.Past(3),
                        Amount = faker.Random.Double(10, 5000)
                    });
                }
                list.Add(emp);
            }
            return list;
        }

        private static async Task BenchmarkAsync<T>(string desc, Func<List<T>> linq, Func<List<T>> plinq, RichTextBox output)
        {
            Utils.AppendText(output, desc);

            await Task.Run(linq);
            await Task.Run(plinq);

            var sw = Stopwatch.StartNew();
            var r1 = await Task.Run(linq);
            sw.Stop();
            long t1 = sw.ElapsedMilliseconds;

            sw.Restart();
            var r2 = await Task.Run(plinq);
            sw.Stop();
            long t2 = sw.ElapsedMilliseconds;

            double speedup = (double)t1 / Math.Max(t2, 1);

            Utils.AppendText(output, $"    LINQ:   {t1,5} мс");
            Utils.AppendText(output, $"   PLINQ:  {t2,5} мс");
            Utils.AppendText(output, $"   Ускорение: {speedup:F2}x {(speedup > 1 ? "(PLINQ быстрее)" : "(LINQ быстрее)")}");
            Utils.AppendText(output, $"   Результатов: {r1.Count}");

            if (speedup > 1.1)
                Utils.AppendText(output, "   PLINQ показывает хорошее ускорение");
            else if (speedup < 0.9)
                Utils.AppendText(output, "   LINQ работает лучше для этого запроса");
            else
                Utils.AppendText(output, "   Производительность сопоставима");

            Utils.AppendText(output, new string('-', 50));
        }
    }
}