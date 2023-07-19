namespace Task2
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
            textBoxYear = new TextBox();
            textBoxMonth = new TextBox();
            textBoxDayOfBirth = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(274, 25);
            label1.TabIndex = 0;
            label1.Text = "Введіть дату свого народження:";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(108, 67);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(72, 31);
            textBoxYear.TabIndex = 3;
            textBoxYear.TextChanged += textBoxYear_TextChanged;
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(108, 121);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(35, 31);
            textBoxMonth.TabIndex = 2;
            textBoxMonth.TextChanged += textBoxMonth_TextChanged;
            // 
            // textBoxDayOfBirth
            // 
            textBoxDayOfBirth.Location = new Point(110, 175);
            textBoxDayOfBirth.Name = "textBoxDayOfBirth";
            textBoxDayOfBirth.Size = new Size(33, 31);
            textBoxDayOfBirth.TabIndex = 1;
            textBoxDayOfBirth.TextChanged += textBoxDayOfBirth_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 181);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 4;
            label2.Text = "Число:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 127);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 5;
            label3.Text = "Місяць: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 73);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 6;
            label4.Text = "Рік: ";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(473, 24);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxMonth);
            Controls.Add(textBoxDayOfBirth);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxYear;
        private TextBox textBoxMonth;
        private TextBox textBoxDayOfBirth;
        private Label label2;
        private Label label3;
        private Label label4;
        private MonthCalendar monthCalendar1;
    }
}