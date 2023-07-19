namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
            dateTimePicker2.ValueChanged += new EventHandler(dateTimePicker2_ValueChanged);
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            TimeSpan difference = date2.Subtract(date1);
            int days = difference.Days;
            int months = (date2.Month - date1.Month) + 12 * (date2.Year - date1.Year);
            int years = date2.Year - date1.Year;

            textBoxDays.Text = days.ToString();
            textBoxMonths.Text = months.ToString();
            textBoxYears.Text = years.ToString();

            label4.Text = $"Äí³: {days}, Ì³ñÿö³: {months}, Ðîêè: {years}";
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            TimeSpan difference = date2.Subtract(date1);
            int days = difference.Days;
            int months = (date2.Month - date1.Month) + 12 * (date2.Year - date1.Year);
            int years = date2.Year - date1.Year;

            textBoxDays.Text = days.ToString();
            textBoxMonths.Text = months.ToString();
            textBoxYears.Text = years.ToString();

            label4.Text = $"Days: {days}, Months: {months}, Years: {years}";
        }
    }
}