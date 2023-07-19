using System.Xml.Serialization;

namespace LaboratoryWork2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            User user = new User();

            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text) ||
                    string.IsNullOrEmpty(textBoxFatherName.Text))
                {
                    throw new Exception("Строка повинна бути заповнена!!!");
                }
                user.Name = textBoxName.Text;
                user.Surname = textBoxSurname.Text;
                user.FatherName = textBoxFatherName.Text;
                if (radioButtonMan.Checked == true)
                { user.Maill = radioButtonMan.Text; }
                if (radioButtonWoman.Checked == true)
                { user.Maill = radioButtonWoman.Text; }
                user.DateOfBirth = DatePickerOfBirth.Value.ToShortDateString();
                if (comboBoxFamilyStatus.SelectedItem != null)
                {
                    user.FamilyStatus = comboBoxFamilyStatus.SelectedItem.ToString();
                }
                else
                {
                    throw new Exception("Виберіть свій сімейний статус!!!");

                }

                user.OtherInformation = richTextBox1.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(user.ToString());

            string fileName = "user.xml";
            FileStream fs = new FileStream(fileName, FileMode.Create);

            XmlSerializer formatter = new XmlSerializer(typeof(User));
            formatter.Serialize(fs, user);

            fs.Close();

            Environment.Exit(0);
        }
    }
}