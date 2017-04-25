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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            tempLabel.BackColor = Color.FromArgb(100, Color.Black);

            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("#")  + "°"; 
            dateLabel.Text = DateTime.Now.ToString();
            windLabel.Text = Form1.days[0].windSpeed;


            if (Form1.days[0].precipitation.Contains("Yes"))
            {
                weatherStatus.Image = Properties.Resources.rain_cloud;
            }

            if (Form1.days[0].condition.Contains("clear")  || Form1.days[0].condition.Contains("sun")) //weather check
            {
                weatherStatus.Image = Properties.Resources.sunny;
            }
            if (Form1.days[0].condition.Contains("cloud")) 
            {
                weatherStatus.Image = Properties.Resources.cloud;
            }

        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
