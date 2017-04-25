using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // create list to hold day objects
        public static List<Day> days = new List<Day>();
        Day d = new Day();
        
        public Form1()
        {
            InitializeComponent();
            GetData();
            ExtractCurrent();
            ExtractForecast();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            // one day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData.xml");
            // mulit day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData7Day.xml");

        }

        private void ExtractCurrent()
        {   //load xml
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            XmlNode parent;
            parent = doc.DocumentElement;
            //scan through all nodes
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "city")//get city
                {
                    
                    d.location = child.Attributes["name"].Value;
                }
                if (child.Name == "temperature")//get highest, lowest and current temp
                {
                    d.currentTemp = child.Attributes["value"].Value;
                }
                if (child.Name == "wind")
                {
                    foreach(XmlNode grandchild in child.ChildNodes)
                    {
                        if(grandchild.Name == "speed")
                        {
                            d.windSpeed = grandchild.Attributes["name"].Value;
                        }
                    }
                }
                if (child.Name == "clouds")//get current cloud or sun
                {
                    d.condition = child.Attributes["name"].Value;
                }
                if (child.Name == "precipitation")//get if raining
                {
                    d.precipitation = child.Attributes["mode"].Value;
                }
    
                
            }
            days.Add(d);
        }

        private void ExtractForecast()
        {
            //load xml
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            XmlNode parent;
            parent = doc.DocumentElement;

            d = new Day();

            //scan through all nodes
            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "forecast")//get forecast
                {
                    foreach(XmlNode grandChild in child.ChildNodes)//down a level
                    {
                        foreach (XmlNode greatGrandChild in grandChild.ChildNodes)//down a level
                        {
                            d.date = grandChild.Attributes["day"].Value;//get time

                            if (greatGrandChild.Name == "temperature")//get highest, lowest and current temp
                            {
                                d.tempHigh = greatGrandChild.Attributes["max"].Value;
                            }
                            if(greatGrandChild.Name == "clouds")//get cloud data
                            {
                                d.condition = greatGrandChild.Attributes["value"].Value;
                                days.Add(d);
                                d = new Day();
                            }
                            if (greatGrandChild.Name == "precipitation")//get if raining
                            {
                                try
                                {
                                    d.precipitation = greatGrandChild.Attributes["type"].Value;
                                }
                                catch
                                {
                                    d.precipitation = "clear";
                                }                                 
                            }
                        }
                    }
                }
            }
            //days.RemoveAt(1);
        }
    }
}
