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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            btnStartTask1 = new Button();
            txtResult1 = new RichTextBox();
            btnStartTask2 = new Button();
            txtResult2 = new RichTextBox();
            lblEmployees = new Label();
            textBox1 = new TextBox();
            btnStartTask3 = new Button();
            txtResult3 = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(782, 553);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtResult1);
            tabPage1.Controls.Add(btnStartTask1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(774, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "MapReduce";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtResult2);
            tabPage2.Controls.Add(btnStartTask2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(774, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Микросервисы";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtResult3);
            tabPage3.Controls.Add(btnStartTask3);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(lblEmployees);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(774, 520);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "LINQ vs PLINQ";
            tabPage3.UseVisualStyleBackColor = true;
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
            // txtResult1
            // 
            txtResult1.Location = new Point(20, 60);
            txtResult1.Name = "txtResult1";
            txtResult1.ReadOnly = true;
            txtResult1.Size = new Size(740, 400);
            txtResult1.TabIndex = 1;
            txtResult1.Text = "";
            txtResult1.TextChanged += richTextBox1_TextChanged;
            // 
            // btnStartTask2
            // 
            btnStartTask2.Location = new Point(20, 20);
            btnStartTask2.Name = "btnStartTask2";
            btnStartTask2.Size = new Size(152, 29);
            btnStartTask2.TabIndex = 0;
            btnStartTask2.Text = "Запустить задачу 2";
            btnStartTask2.UseVisualStyleBackColor = true;
            // 
            // txtResult2
            // 
            txtResult2.Location = new Point(17, 60);
            txtResult2.Name = "txtResult2";
            txtResult2.ReadOnly = true;
            txtResult2.Size = new Size(740, 400);
            txtResult2.TabIndex = 2;
            txtResult2.Text = "";
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
            // textBox1
            // 
            textBox1.Location = new Point(211, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "1000";
            // 
            // btnStartTask3
            // 
            btnStartTask3.Location = new Point(336, 20);
            btnStartTask3.Name = "btnStartTask3";
            btnStartTask3.Size = new Size(153, 29);
            btnStartTask3.TabIndex = 2;
            btnStartTask3.Text = "Запустить задачу 3";
            btnStartTask3.UseVisualStyleBackColor = true;
            // 
            // txtResult3
            // 
            txtResult3.Location = new Point(20, 60);
            txtResult3.Name = "txtResult3";
            txtResult3.ReadOnly = true;
            txtResult3.Size = new Size(740, 400);
            txtResult3.TabIndex = 3;
            txtResult3.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Параллельная обработка данных";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnStartTask1;
        private RichTextBox txtResult1;
        private Button btnStartTask2;
        private RichTextBox txtResult2;
        private RichTextBox txtResult3;
        private Button btnStartTask3;
        private TextBox textBox1;
        private Label lblEmployees;
    }
}
