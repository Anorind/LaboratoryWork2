namespace Task3
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            labelInfo = new Label();
            labelDays = new Label();
            textBoxDays = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxMonths = new TextBox();
            textBoxYears = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(44, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(431, 37);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 1;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(112, 115);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(232, 25);
            labelInfo.TabIndex = 2;
            labelInfo.Text = "Різниця між датами у днях:";
            // 
            // labelDays
            // 
            labelDays.AutoSize = true;
            labelDays.Location = new Point(431, 115);
            labelDays.Name = "labelDays";
            labelDays.Size = new Size(0, 25);
            labelDays.TabIndex = 3;
            // 
            // textBoxDays
            // 
            textBoxDays.Location = new Point(275, 241);
            textBoxDays.Name = "textBoxDays";
            textBoxDays.Size = new Size(150, 31);
            textBoxDays.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 247);
            label1.Name = "label1";
            label1.Size = new Size(232, 25);
            label1.TabIndex = 5;
            label1.Text = "Різниця між датами у днях:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 302);
            label2.Name = "label2";
            label2.Size = new Size(257, 25);
            label2.TabIndex = 6;
            label2.Text = "Різниця між датами у місяцях:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 362);
            label3.Name = "label3";
            label3.Size = new Size(243, 25);
            label3.TabIndex = 7;
            label3.Text = "Різниця між датами у роках:";
            // 
            // textBoxMonths
            // 
            textBoxMonths.Location = new Point(275, 296);
            textBoxMonths.Name = "textBoxMonths";
            textBoxMonths.Size = new Size(150, 31);
            textBoxMonths.TabIndex = 8;
            // 
            // textBoxYears
            // 
            textBoxYears.Location = new Point(275, 356);
            textBoxYears.Name = "textBoxYears";
            textBoxYears.Size = new Size(150, 31);
            textBoxYears.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 116);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBoxYears);
            Controls.Add(textBoxMonths);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDays);
            Controls.Add(labelDays);
            Controls.Add(labelInfo);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label labelInfo;
        private Label labelDays;
        private TextBox textBoxDays;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxMonths;
        private TextBox textBoxYears;
        private Label label4;
    }
}