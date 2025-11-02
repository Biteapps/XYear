using System;
using System.Drawing;
using System.Windows.Forms;

namespace DaysToNewYear
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Timer _timer;

        public MainForm()
        {
            InitializeComponent();
            ApplyDarkTheme();
            UpdateCountdown();

            // автообновление каждую минуту
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 60 * 1000;
            _timer.Tick += (s, e) => UpdateCountdown();
            _timer.Start();
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(34, 34, 34);
            this.ForeColor = Color.White;

            foreach (Control c in this.Controls)
            {
                c.BackColor = this.BackColor;
                c.ForeColor = this.ForeColor;
            }
        }

        private void UpdateCountdown()
        {
            DateTime today = DateTime.Now.Date;
            int year = today.Year;

            // определяем ближайший Новый год
            DateTime thisNewYear = new DateTime(year, 1, 1);
            DateTime nextNewYear = new DateTime(year + 1, 1, 1);
            DateTime targetNewYear = (today >= thisNewYear) ? nextNewYear : thisNewYear;

            TimeSpan diff = targetNewYear - today;
            int daysLeft = diff.Days;

            lblToday.Text = $"Сегодня: {DateTime.Now:dddd, dd MMMM yyyy}";
            lblNewYear.Text = $"Новый год: {targetNewYear:dddd, dd MMMM yyyy}";
            lblDays.Text = daysLeft == 0
                ? "С НОВЫМ ГОДОМ! 🎉"
                : $"Осталось: {daysLeft} {(daysLeft == 1 ? "день" : "дней")}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateCountdown();
        }
    }
}
