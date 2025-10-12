using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProcessingApp
{
    public static class Task2
    {
        private static readonly object _logLock = new();

        public static async Task RunMicroservicesAsync(RichTextBox output)
        {
            Utils.AppendText(output, "Начало обработки микросервисов...");
            Utils.AppendText(output, "Генерация тестовых данных...");

            var goodsList = Enumerable.Range(1, 100).Select(i => new Goods { Id = i }).ToList();
            var storage = new Storage();

            foreach (var g in goodsList)
            {
                storage.Inventory.TryAdd(g, new Info
                {
                    Price = 10 + g.Id * 2.5,
                    Count = Random.Shared.Next(0, 10)
                });
            }

            var orders = Enumerable.Range(1, 50).Select(i => new Order
            {
                Id = i,
                GoodsList = goodsList.Where(_ => Random.Shared.NextDouble() > 0.4)
                                     .Take(Random.Shared.Next(1, 6)).ToList(),
                PersonalDiscount = Random.Shared.NextDouble() * 0.3,
                Address = $"Street{i} Bld{Random.Shared.Next(1, 100)}"
            }).ToList();

            string logFile = Path.Combine(Path.GetTempPath(), "microservices_log.txt");
            File.WriteAllText(logFile, "");

            Utils.AppendText(output, $"Сгенерировано данных:");
            Utils.AppendText(output, $"   - Товаров: {goodsList.Count}");
            Utils.AppendText(output, $"   - Заказов: {orders.Count}");
            Utils.AppendText(output, "");

            int fullyProcessed = 0;
            int missingItems = 0;
            double totalRevenue = 0;
            var deliveryStats = new Dictionary<int, int>();

            var tasks = new List<Task<OrderResult>>();

            Utils.AppendText(output, "Запуск обработки заказов...");
            Utils.AppendText(output, "");

            foreach (var order in orders)
            {
                tasks.Add(ProcessOrderAsync(order, storage, logFile));
            }

            var results = await Task.WhenAll(tasks);

            foreach (var result in results)
            {
                if (result.IsFullyProcessed)
                {
                    fullyProcessed++;
                    totalRevenue += result.FinalAmount;

                    if (deliveryStats.ContainsKey(result.DeliveryDays))
                        deliveryStats[result.DeliveryDays]++;
                    else
                        deliveryStats[result.DeliveryDays] = 1;
                }
                else
                {
                    missingItems++;
                }
            }

            Utils.AppendText(output, "РЕЗУЛЬТАТЫ ОБРАБОТКИ:");
            Utils.AppendText(output, new string('=', 50));
            Utils.AppendText(output, $"Полностью обработано заказов: {fullyProcessed}");
            Utils.AppendText(output, $"Заказы с отсутствующими товарами: {missingItems}");
            Utils.AppendText(output, $"Общая выручка: {totalRevenue:F2} руб.");
            Utils.AppendText(output, "");
            Utils.AppendText(output, "Статистика доставки:");
            foreach (var stat in deliveryStats.OrderBy(x => x.Key))
            {
                Utils.AppendText(output, $"   - {stat.Key} дней: {stat.Value} заказов");
            }
            Utils.AppendText(output, "");
            Utils.AppendText(output, $"Подробный лог сохранён в: {logFile}");
            Utils.AppendText(output, "");
            Utils.AppendText(output, "ОБРАБОТКА ЗАВЕРШЕНА!");

            Utils.AppendText(output, "");
            Utils.AppendText(output, " ДОПОЛНИТЕЛЬНАЯ СТАТИСТИКА:");
            Utils.AppendText(output, $"   - Эффективность обработки: {(double)fullyProcessed / orders.Count * 100:F1}%");
            Utils.AppendText(output, $"   - Средний чек: {(fullyProcessed > 0 ? totalRevenue / fullyProcessed : 0):F2} руб.");
            Utils.AppendText(output, $"   - Среднее время доставки: {(deliveryStats.Any() ? deliveryStats.Average(x => x.Key * x.Value) / deliveryStats.Sum(x => x.Value) : 0):F1} дней");
        }

        private static async Task<OrderResult> ProcessOrderAsync(Order order, Storage storage, string logFile)
        {
            var result = new OrderResult { OrderId = order.Id };

            bool hasAll = order.GoodsList.All(g => storage.Inventory.TryGetValue(g, out var info) && info.Count > 0);
            Utils.LogToFile(logFile, $"[Order {order.Id}] Inventory Check: {(hasAll ? "PASS" : "FAIL")} - {order.GoodsList.Count} items", _logLock);

            if (!hasAll)
            {
                result.IsFullyProcessed = false;
                return result;
            }

            double total = order.GoodsList.Sum(g => storage.Inventory[g].Price);
            double final = total * (1 - order.PersonalDiscount);
            Utils.LogToFile(logFile, $"[Order {order.Id}] Pricing: Total={total:F2}, Discount={order.PersonalDiscount:P1}, Final={final:F2}", _logLock);

            result.FinalAmount = final;

            int days = Math.Max(1, order.Address.Length % 7);
            Utils.LogToFile(logFile, $"[Order {order.Id}] Shipping: Address='{order.Address}', Delivery={days} days", _logLock);

            result.DeliveryDays = days;
            result.IsFullyProcessed = true;

            return result;
        }

        private class OrderResult
        {
            public int OrderId { get; set; }
            public bool IsFullyProcessed { get; set; }
            public double FinalAmount { get; set; }
            public int DeliveryDays { get; set; }
        }
    }
}