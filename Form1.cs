using System;
using System.Windows.Forms;

namespace ParallelProcessingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void btnStartTask1_Click(object sender, EventArgs e)
        {
            btnStartTask1.Enabled = false;
            MapReduceTaskOutput.Clear();
            try
            {
                await Task1.RunMapReduceAsync(MapReduceTaskOutput);
            }
            catch (Exception ex)
            {
                MapReduceTaskOutput.AppendText($"Ошибка: {ex.Message}");
            }
            finally
            {
                btnStartTask1.Enabled = true;
            }
        }

        private async void btnStartTask2_Click_1(object sender, EventArgs e)
        {
            btnStartTask2.Enabled = false;
            MicroservicesTaskOutput.Clear();
            try
            {
                await Task2.RunMicroservicesAsync(MicroservicesTaskOutput);
            }
            catch (Exception ex)
            {
                MicroservicesTaskOutput.AppendText($"Ошибка: {ex.Message}");
            }
            finally
            {
                btnStartTask2.Enabled = true;
            }
        }

        private async void btnStartTask3_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int employeeCount) || employeeCount <= 0)
            {
                MessageBox.Show(
                    "Пожалуйста, введите корректное число сотрудников (целое > 0).",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            btnStartTask3.Enabled = false;
            LINQvsPLINQTaskOutput.Clear();
            try
            {
                await Task3.RunLinqVsPlinqAsync(employeeCount, LINQvsPLINQTaskOutput);
            }
            catch (Exception ex)
            {
                LINQvsPLINQTaskOutput.AppendText($"Ошибка: {ex.Message}");
            }
            finally
            {
                btnStartTask3.Enabled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
    }
}