namespace ParallelProcessingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tabs = new TabControl();
            MapReduceTabPage = new TabPage();
            MapReduceTaskOutput = new RichTextBox();
            btnStartTask1 = new Button();
            MicroservicesTabPage = new TabPage();
            MicroservicesTaskOutput = new RichTextBox();
            btnStartTask2 = new Button();
            LINQvsPLINQTabPage = new TabPage();
            LINQvsPLINQTaskOutput = new RichTextBox();
            btnStartTask3 = new Button();
            textBox1 = new TextBox();
            lblEmployees = new Label();
            Tabs.SuspendLayout();
            MapReduceTabPage.SuspendLayout();
            MicroservicesTabPage.SuspendLayout();
            LINQvsPLINQTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(MapReduceTabPage);
            Tabs.Controls.Add(MicroservicesTabPage);
            Tabs.Controls.Add(LINQvsPLINQTabPage);
            Tabs.Dock = DockStyle.Fill;
            Tabs.Location = new Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(782, 553);
            Tabs.TabIndex = 0;
            // 
            // MapReduceTabPage
            // 
            MapReduceTabPage.Controls.Add(MapReduceTaskOutput);
            MapReduceTabPage.Controls.Add(btnStartTask1);
            MapReduceTabPage.Location = new Point(4, 29);
            MapReduceTabPage.Name = "MapReduceTabPage";
            MapReduceTabPage.Padding = new Padding(3);
            MapReduceTabPage.Size = new Size(774, 520);
            MapReduceTabPage.TabIndex = 0;
            MapReduceTabPage.Text = "MapReduce";
            MapReduceTabPage.UseVisualStyleBackColor = true;
            MapReduceTabPage.Click += tabPage1_Click;
            // 
            // MapReduceTaskOutput
            // 
            MapReduceTaskOutput.Location = new Point(20, 60);
            MapReduceTaskOutput.Name = "MapReduceTaskOutput";
            MapReduceTaskOutput.ReadOnly = true;
            MapReduceTaskOutput.Size = new Size(740, 400);
            MapReduceTaskOutput.TabIndex = 1;
            MapReduceTaskOutput.Text = "";
            MapReduceTaskOutput.TextChanged += richTextBox1_TextChanged;
            // 
            // btnStartTask1
            // 
            btnStartTask1.Location = new Point(20, 20);
            btnStartTask1.Name = "btnStartTask1";
            btnStartTask1.Size = new Size(149, 29);
            btnStartTask1.TabIndex = 0;
            btnStartTask1.Text = "Запустить задачу 1";
            btnStartTask1.UseVisualStyleBackColor = true;
            btnStartTask1.Click += btnStartTask1_Click;
            // 
            // MicroservicesTabPage
            // 
            MicroservicesTabPage.Controls.Add(MicroservicesTaskOutput);
            MicroservicesTabPage.Controls.Add(btnStartTask2);
            MicroservicesTabPage.Location = new Point(4, 29);
            MicroservicesTabPage.Name = "MicroservicesTabPage";
            MicroservicesTabPage.Padding = new Padding(3);
            MicroservicesTabPage.Size = new Size(774, 520);
            MicroservicesTabPage.TabIndex = 1;
            MicroservicesTabPage.Text = "Микросервисы";
            MicroservicesTabPage.UseVisualStyleBackColor = true;
            MicroservicesTabPage.Click += tabPage2_Click;
            // 
            // MicroservicesTaskOutput
            // 
            MicroservicesTaskOutput.Location = new Point(17, 60);
            MicroservicesTaskOutput.Name = "MicroservicesTaskOutput";
            MicroservicesTaskOutput.ReadOnly = true;
            MicroservicesTaskOutput.Size = new Size(740, 400);
            MicroservicesTaskOutput.TabIndex = 2;
            MicroservicesTaskOutput.Text = "";
            // 
            // btnStartTask2
            // 
            btnStartTask2.Location = new Point(20, 20);
            btnStartTask2.Name = "btnStartTask2";
            btnStartTask2.Size = new Size(152, 29);
            btnStartTask2.TabIndex = 0;
            btnStartTask2.Text = "Запустить задачу 2";
            btnStartTask2.UseVisualStyleBackColor = true;
            btnStartTask2.Click += btnStartTask2_Click_1;
            // 
            // LINQvsPLINQTabPage
            // 
            LINQvsPLINQTabPage.Controls.Add(LINQvsPLINQTaskOutput);
            LINQvsPLINQTabPage.Controls.Add(btnStartTask3);
            LINQvsPLINQTabPage.Controls.Add(textBox1);
            LINQvsPLINQTabPage.Controls.Add(lblEmployees);
            LINQvsPLINQTabPage.Location = new Point(4, 29);
            LINQvsPLINQTabPage.Name = "LINQvsPLINQTabPage";
            LINQvsPLINQTabPage.Padding = new Padding(3);
            LINQvsPLINQTabPage.Size = new Size(774, 520);
            LINQvsPLINQTabPage.TabIndex = 2;
            LINQvsPLINQTabPage.Text = "LINQ vs PLINQ";
            LINQvsPLINQTabPage.UseVisualStyleBackColor = true;
            // 
            // LINQvsPLINQTaskOutput
            // 
            LINQvsPLINQTaskOutput.Location = new Point(20, 60);
            LINQvsPLINQTaskOutput.Name = "LINQvsPLINQTaskOutput";
            LINQvsPLINQTaskOutput.ReadOnly = true;
            LINQvsPLINQTaskOutput.Size = new Size(740, 400);
            LINQvsPLINQTaskOutput.TabIndex = 3;
            LINQvsPLINQTaskOutput.Text = "";
            // 
            // btnStartTask3
            // 
            btnStartTask3.Location = new Point(336, 20);
            btnStartTask3.Name = "btnStartTask3";
            btnStartTask3.Size = new Size(153, 29);
            btnStartTask3.TabIndex = 2;
            btnStartTask3.Text = "Запустить задачу 3";
            btnStartTask3.UseVisualStyleBackColor = true;
            btnStartTask3.Click += btnStartTask3_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 1;
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Location = new Point(20, 20);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(185, 20);
            lblEmployees.TabIndex = 0;
            lblEmployees.Text = "Количество сотрудников:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(Tabs);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Параллельная обработка данных";
            Load += Form1_Load;
            Tabs.ResumeLayout(false);
            MapReduceTabPage.ResumeLayout(false);
            MicroservicesTabPage.ResumeLayout(false);
            LINQvsPLINQTabPage.ResumeLayout(false);
            LINQvsPLINQTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage MapReduceTabPage;
        private TabPage MicroservicesTabPage;
        private TabPage LINQvsPLINQTabPage;
        private Button btnStartTask1;
        private RichTextBox MapReduceTaskOutput;
        private Button btnStartTask2;
        private RichTextBox MicroservicesTaskOutput;
        private RichTextBox LINQvsPLINQTaskOutput;
        private Button btnStartTask3;
        private TextBox textBox1;
        private Label lblEmployees;
    }
}
