using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int day = 1;
        int month = 1;
        int year = 1700;

        private void textBoxDayOfBirth_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDayOfBirth.Text, out int day) || day < 1 || day > 31)
            {
                textBoxDayOfBirth.Text = "";
            }
            else
            {
                this.day = day;
                monthCalendar1.SetDate(new DateTime(this.year, this.month, this.day));
            }
        }

        private void textBoxMonth_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxMonth.Text, out int month) || month < 1 || month > 12)
            {
                textBoxMonth.Text = "";
            }
            else
            {
                this.month = month;
                monthCalendar1.SetDate(new DateTime(this.year, this.month, this.day));
            }
        }
        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxYear.Text, out int year) || year > DateTime.Now.Year)
            {
                textBoxYear.Text = "";
            }
            else
            {
                this.year = year;
                monthCalendar1.SetDate(new DateTime(this.year, this.month, this.day));
            }
        }
    }
}