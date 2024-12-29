namespace Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            AddNumber = new Button();
            SubtractNumber = new Button();
            MultiplyNumber = new Button();
            DivideNumber = new Button();
            label4 = new Label();
            AnswerTextbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 45);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(102, 114);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 1;
            label2.Text = "Enter Value for A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(102, 177);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 2;
            label3.Text = "Enter Value for B";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(287, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 34);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(287, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(239, 34);
            textBox2.TabIndex = 4;
            // 
            // AddNumber
            // 
            AddNumber.Location = new Point(56, 251);
            AddNumber.Name = "AddNumber";
            AddNumber.Size = new Size(119, 37);
            AddNumber.TabIndex = 5;
            AddNumber.Text = "Addition";
            AddNumber.UseVisualStyleBackColor = true;
            AddNumber.Click += AddNumber_Click;
            // 
            // SubtractNumber
            // 
            SubtractNumber.Location = new Point(200, 251);
            SubtractNumber.Name = "SubtractNumber";
            SubtractNumber.Size = new Size(119, 37);
            SubtractNumber.TabIndex = 6;
            SubtractNumber.Text = "Subtraction";
            SubtractNumber.UseVisualStyleBackColor = true;
            SubtractNumber.Click += SubtractNumber_Click;
            // 
            // MultiplyNumber
            // 
            MultiplyNumber.Location = new Point(349, 251);
            MultiplyNumber.Name = "MultiplyNumber";
            MultiplyNumber.Size = new Size(119, 37);
            MultiplyNumber.TabIndex = 7;
            MultiplyNumber.Text = "Multiplication";
            MultiplyNumber.UseVisualStyleBackColor = true;
            MultiplyNumber.Click += MultiplyNumber_Click;
            // 
            // DivideNumber
            // 
            DivideNumber.Location = new Point(517, 251);
            DivideNumber.Name = "DivideNumber";
            DivideNumber.Size = new Size(119, 37);
            DivideNumber.TabIndex = 8;
            DivideNumber.Text = "Division";
            DivideNumber.UseVisualStyleBackColor = true;
            DivideNumber.Click += DivideNumber_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(102, 344);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 9;
            label4.Text = "Label4";
            label4.Visible = false;
            // 
            // AnswerTextbox
            // 
            AnswerTextbox.Font = new Font("Segoe UI", 12F);
            AnswerTextbox.Location = new Point(287, 344);
            AnswerTextbox.Name = "AnswerTextbox";
            AnswerTextbox.Size = new Size(239, 34);
            AnswerTextbox.TabIndex = 10;
            AnswerTextbox.TextAlign = HorizontalAlignment.Center;
            AnswerTextbox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 458);
            Controls.Add(AnswerTextbox);
            Controls.Add(label4);
            Controls.Add(DivideNumber);
            Controls.Add(MultiplyNumber);
            Controls.Add(SubtractNumber);
            Controls.Add(AddNumber);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyCalculatorApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button AddNumber;
        private Button SubtractNumber;
        private Button MultiplyNumber;
        private Button DivideNumber;
        private Label label4;
        private TextBox AnswerTextbox;
    }
}
