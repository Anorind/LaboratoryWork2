namespace LaboratoryWork2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelName = new Label();
            labelSurname = new Label();
            labelFathername = new Label();
            labelMail = new Label();
            radioButtonMan = new RadioButton();
            radioButtonWoman = new RadioButton();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxFatherName = new TextBox();
            labelBirthDate = new Label();
            DatePickerOfBirth = new DateTimePicker();
            comboBoxFamilyStatus = new ComboBox();
            labelFamilyStatus = new Label();
            richTextBox1 = new RichTextBox();
            labelInform = new Label();
            labelSave = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(15, 43);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Ім'я: ";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(12, 74);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(96, 25);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Прізвище:";
            // 
            // labelFathername
            // 
            labelFathername.AutoSize = true;
            labelFathername.Location = new Point(12, 104);
            labelFathername.Name = "labelFathername";
            labelFathername.Size = new Size(109, 25);
            labelFathername.TabIndex = 2;
            labelFathername.Text = "Побатькові:";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Location = new Point(12, 139);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(64, 25);
            labelMail.TabIndex = 3;
            labelMail.Text = "Стать: ";
            // 
            // radioButtonMan
            // 
            radioButtonMan.AutoSize = true;
            radioButtonMan.Location = new Point(120, 137);
            radioButtonMan.Name = "radioButtonMan";
            radioButtonMan.Size = new Size(103, 29);
            radioButtonMan.TabIndex = 4;
            radioButtonMan.TabStop = true;
            radioButtonMan.Text = "Чоловік";
            radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // radioButtonWoman
            // 
            radioButtonWoman.AutoSize = true;
            radioButtonWoman.Location = new Point(250, 135);
            radioButtonWoman.Name = "radioButtonWoman";
            radioButtonWoman.Size = new Size(85, 29);
            radioButtonWoman.TabIndex = 5;
            radioButtonWoman.TabStop = true;
            radioButtonWoman.Text = "Жінка";
            radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(120, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(120, 68);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(150, 31);
            textBoxSurname.TabIndex = 7;
            // 
            // textBoxFatherName
            // 
            textBoxFatherName.Location = new Point(120, 98);
            textBoxFatherName.Name = "textBoxFatherName";
            textBoxFatherName.Size = new Size(150, 31);
            textBoxFatherName.TabIndex = 8;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(15, 188);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(165, 25);
            labelBirthDate.TabIndex = 9;
            labelBirthDate.Text = "Дата народження: ";
            // 
            // DatePickerOfBirth
            // 
            DatePickerOfBirth.Location = new Point(181, 186);
            DatePickerOfBirth.Name = "DatePickerOfBirth";
            DatePickerOfBirth.Size = new Size(240, 31);
            DatePickerOfBirth.TabIndex = 10;
            DatePickerOfBirth.Value = new DateTime(1992, 5, 17, 0, 0, 0, 0);
            // 
            // comboBoxFamilyStatus
            // 
            comboBoxFamilyStatus.FormattingEnabled = true;
            comboBoxFamilyStatus.Items.AddRange(new object[] { "Одружений(-на)", "Неодружений(-на)", "В активному пошуку" });
            comboBoxFamilyStatus.Location = new Point(181, 233);
            comboBoxFamilyStatus.Name = "comboBoxFamilyStatus";
            comboBoxFamilyStatus.Size = new Size(240, 33);
            comboBoxFamilyStatus.TabIndex = 11;
            comboBoxFamilyStatus.Text = "Виберіть із списку";
            // 
            // labelFamilyStatus
            // 
            labelFamilyStatus.AutoSize = true;
            labelFamilyStatus.Location = new Point(12, 241);
            labelFamilyStatus.Name = "labelFamilyStatus";
            labelFamilyStatus.Size = new Size(146, 25);
            labelFamilyStatus.TabIndex = 12;
            labelFamilyStatus.Text = "Сімейний статус:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(181, 283);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(240, 129);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // labelInform
            // 
            labelInform.AutoSize = true;
            labelInform.Location = new Point(15, 283);
            labelInform.Name = "labelInform";
            labelInform.Size = new Size(110, 50);
            labelInform.TabIndex = 14;
            labelInform.Text = "Додаткова \r\nінформація:";
            // 
            // labelSave
            // 
            labelSave.AutoSize = true;
            labelSave.Location = new Point(12, 333);
            labelSave.Name = "labelSave";
            labelSave.Size = new Size(143, 25);
            labelSave.TabIndex = 15;
            labelSave.Text = "Зберегти анкету";
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(49, 361);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(51, 51);
            buttonSave.TabIndex = 16;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 424);
            Controls.Add(buttonSave);
            Controls.Add(labelSave);
            Controls.Add(labelInform);
            Controls.Add(richTextBox1);
            Controls.Add(labelFamilyStatus);
            Controls.Add(comboBoxFamilyStatus);
            Controls.Add(DatePickerOfBirth);
            Controls.Add(labelBirthDate);
            Controls.Add(textBoxFatherName);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(radioButtonWoman);
            Controls.Add(radioButtonMan);
            Controls.Add(labelMail);
            Controls.Add(labelFathername);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelSurname;
        private Label labelFathername;
        private Label labelMail;
        private RadioButton radioButtonMan;
        private RadioButton radioButtonWoman;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxFatherName;
        private Label labelBirthDate;
        private DateTimePicker DatePickerOfBirth;
        private ComboBox comboBoxFamilyStatus;
        private Label labelFamilyStatus;
        private RichTextBox richTextBox1;
        private Label labelInform;
        private Label labelSave;
        private Button buttonSave;
    }
}