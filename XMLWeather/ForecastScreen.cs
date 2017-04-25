using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {
            displayForecast();
        }

        public void displayForecast()
        {
            date1.BackColor = Color.FromArgb(100, Color.Black);
            max1.BackColor = Color.FromArgb(100, Color.Black);
            date2.BackColor = Color.FromArgb(100, Color.Black);
            max2.BackColor = Color.FromArgb(100, Color.Black);
            date3.BackColor = Color.FromArgb(100, Color.Black);
            max3.BackColor = Color.FromArgb(100, Color.Black);

            //day 1
            date1.Text = DateTime.Now.ToString("dddd");
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("#") + "°";

            //day 2
            date2.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("#") + "°";

            //day 2
            date3.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("#") + "°";

            //if weather for the days us clear or sunny
            if (Form1.days[1].condition.Contains("clear") || Form1.days[0].condition.Contains("sun")) //weather check
            {
                dayPic1.Image = Properties.Resources.sunny;
            }
            if (Form1.days[2].condition.Contains("clear") || Form1.days[0].condition.Contains("sun")) 
            {
                dayPic2.Image = Properties.Resources.sunny;
            }
            if (Form1.days[3].condition.Contains("clear") || Form1.days[0].condition.Contains("sun")) 
            {
                dayPic3.Image = Properties.Resources.sunny;
            }
            //if weather for the days is cloudy
            if (Form1.days[1].condition.Contains("clouds")) //weather check
            {
                dayPic1.Image = Properties.Resources.cloud;
            }
            if (Form1.days[2].condition.Contains("clouds"))
            {
                dayPic2.Image = Properties.Resources.cloud;
            }
            if (Form1.days[3].condition.Contains("clouds"))
            {
                dayPic3.Image = Properties.Resources.cloud;
            }

            //if weather is rainy
            if (Form1.days[1].precipitation.Contains("rain"))
            {
                dayPic1.Image = Properties.Resources.rain_cloud;
            }
            if (Form1.days[2].precipitation.Contains("rain"))
            {
                dayPic2.Image = Properties.Resources.rain_cloud;
            }
            if (Form1.days[3].precipitation.Contains("rain"))
            {
                dayPic3.Image = Properties.Resources.rain_cloud;
            }
        }
    }
}
