﻿using System;
using System.Windows.Forms;

namespace JTTT_1._0
{
    public partial class WeatherInfoForm : Form
    {
        public WeatherInfoForm()
        {
            InitializeComponent();
        }

        private void weatherButton_Click(object sender, EventArgs e)
        {
            
            if (cityTextBox.Text == "" || cityTextBox.Text == null)
            {
                weatherDescription.Text = "Podaj prawdłową nazwę miasta";
                return;
            }
            try {
                var weather = Services.Instance.WeatherService.GetCurrentWeather(cityTextBox.Text);
                weatherDescription.Text = Parse(weather);
            }
            catch
            {
                weatherDescription.Text = $"nie znaleziono pogody dla miasta {cityTextBox.Text}, lub wystąpił problem z połączeniem internetowym";
            }
            
        }

        string Parse(WeatherInfo.RootObject weather)
        {
            return $"Obecnie jest {weather.main.temp - 273.00f} stopni Celcjuszka, ciśnienie {weather.main.pressure}hPa. Wiatr pędzie z prędkością {weather.wind.speed}m/h";
        }
    }
}
