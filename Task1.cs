using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProcessingApp
{
    public static class Task1
    {
        public static async Task RunMapReduceAsync(RichTextBox output, string[] wordsToFind)
        {
            var textsFolder = Path.Combine(Application.StartupPath, "Texts");

            if (!Directory.Exists(textsFolder))
            {
                Utils.AppendText(output, "Папка Texts не найдена!");
                return;
            }

            var files = Directory.GetFiles(textsFolder, "*.txt");
            if (files.Length == 0)
            {
                Utils.AppendText(output, "В папке Texts нет .txt файлов");
                return;
            }

            var totalCounts = new ConcurrentDictionary<string, int>();

            await Task.Run(() =>
            {
                Parallel.ForEach(files, file =>
                {
                    var text = File.ReadAllText(file).ToLower();
                    foreach (var word in wordsToFind)
                    {
                        int count = Regex.Matches(text, $@"\b{Regex.Escape(word)}\b").Count;
                        if (count > 0)
                        {
                            totalCounts.AddOrUpdate(word, count, (key, oldValue) => oldValue + count);
                        }
                    }
                });
            });

            Utils.AppendText(output, "Результат MapReduce:");
            Utils.AppendText(output, $"Обработано файлов: {files.Length}");
            Utils.AppendText(output, $"Искомые слова: {string.Join(", ", wordsToFind)}");
            Utils.AppendText(output, "");
            Utils.AppendText(output, "Статистика вхождений:");
            foreach (var kvp in totalCounts.OrderByDescending(x => x.Value))
            {
                Utils.AppendText(output, $"   {kvp.Key}: {kvp.Value} вхождений");
            }

            var totalWords = totalCounts.Values.Sum();
            Utils.AppendText(output, "");
            Utils.AppendText(output, $"Всего найдено вхождений: {totalWords}");
        }
    }
}