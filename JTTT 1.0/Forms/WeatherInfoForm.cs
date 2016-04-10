using System;
using System.Drawing;
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
                Image img = Image.FromFile(Services.Instance.WeatherService.GetWeatherImg(weather));
                picture.Image = img;
            }
            catch
            {
                weatherDescription.Text = $"nie znaleziono pogody dla miasta {cityTextBox.Text}, lub wystąpił problem z połączeniem internetowym";
            }
            
        }

        public string Parse(WeatherInfo.RootObject weather)
        {
            return $"Obecnie jest {weather.main.temp - 273.00f} stopni Celcjuszka, ciśnienie {weather.main.pressure}hPa. Wiatr pędzi z prędkością {weather.wind.speed}m/s";
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }
    }
}
