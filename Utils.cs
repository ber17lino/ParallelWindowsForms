using System;
using System.IO;
using System.Windows.Forms;

namespace ParallelProcessingApp
{
    public static class Utils
    {
        public static void AppendText(RichTextBox box, string text)
        {
            if (box.InvokeRequired)
                box.Invoke(new Action(() => box.AppendText(text + Environment.NewLine)));
            else
                box.AppendText(text + Environment.NewLine);
        }

        public static void LogToFile(string filePath, string message, object lockObject)
        {
            lock (lockObject)
            {
                File.AppendAllText(filePath, $"[{DateTime.Now:HH:mm:ss.fff}] {message}{Environment.NewLine}");
            }
        }
    }
}