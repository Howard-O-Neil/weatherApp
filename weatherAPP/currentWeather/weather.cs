using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

#pragma warning disable CS4014

namespace weatherAPP.weatherControl
{
	public partial class weather : UserControl
	{
		public static weather Instance;
		public static bool canLoad = true; 

		public MySQL_ORM_Binding.current_data currentData;

		UserControl currentSplash;

		public weather()
		{
			Instance = this;
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private async void weather_Load(object sender, EventArgs e)
		{
			await initData();
		}

		DateTime toLocal(int input) // input the unix code
		{
			DateTime UnixEpoach = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			DateTime localTime = UnixEpoach.AddSeconds(input).ToLocalTime();
			return localTime;
		}

		int unixUTCNow()
		{
			return (int)DateTime.UtcNow.Subtract
				(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
		}

		public async Task initData(double lat = 10, double lon = 106)
		{
			canLoad = false;

			loadSplashScreen();

			current_data.RootObject current = await API_caller.requestCurrent(lat, lon);

			currentData = new MySQL_ORM_Binding.current_data
			{
				customer_id = mainApp.customer_id,
				country = current.sys.country,
				city = current.name,
				main = current.weather[0].main,
				description = current.weather[0].description,
				icon_url = current.weather[0].icon,
				temper = current.main.temp,
				wind = current.wind.speed,
				visibility = current.visibility,
				update_time = unixUTCNow(),
				sunrise = current.sys.sunrise,
				sunset = current.sys.sunset,
				humid = current.main.humidity,
				cloud = current.clouds.all
			};

			await initDisplay();

			currentSplash.Dispose();

			await Task.Factory.StartNew(() =>
			{
				MySqlQuery query = new MySqlQuery(); 
				query.insertCurrentWeather(currentData);
			});
			canLoad = true; 
		}

		public async Task initDisplay()
		{
			string iconUrl = "http://openweathermap.org/img/w/";

			#region display_information

			await Task.Factory.StartNew(() =>
			{
				if (currentData.city == "" || currentData.city == "Earth")
				{
					city.Text = "Unidentified Data Location From Server";
				}
				else
				{
					if (currentData.city.Contains("City"))
					{
						city.Text = currentData.country + ", " + currentData.city;
					}
					else city.Text = currentData.country + ", " + currentData.city + " City";
				}

				temperature.Text = string.Format("{0:F2}", currentData.temper - 273f) + "°C";

				status.Text = "Description: " + currentData.main + ", " + currentData.description;

				iconUrl += $"{currentData.icon_url}.png";

				icon.SizeMode = PictureBoxSizeMode.StretchImage;
				icon.Load(iconUrl);

				humid.Text = "Humidity by percentage: " + currentData.humid + "%";
				cloud.Text = "Cloudrate by percentage: " + currentData.cloud + "%";

				visibility.Text = "Visibility rate: " + string.Format("{0:F3}",
					currentData.visibility / 1000) + "km";

				wind.Text = "Wind speed: " + string.Format("{0:F3}",
					currentData.wind * 3.6f) + "km/h";

				update.Text = string.Format("{0:dd/MM/yyyy hh:mm:ss tt}",
					toLocal(currentData.update_time));

				sunrise.Text = "Sunrise at: " + string.Format("{0:hh:mm:sstt}",
					toLocal(currentData.sunrise));
				sunset.Text = "Sunset at: " + string.Format("{0:hh:mm:sstt}",
					toLocal(currentData.sunset));
			});
			#endregion
		}

		void loadSplashScreen()
		{
			if (currentSplash != null)
            {
                currentSplash.Dispose();
            }
			currentSplash = new splash(15000);
			currentSplash.Dock = DockStyle.Fill;
			this.Controls.Add(currentSplash);

			currentSplash.BringToFront(); 
			currentSplash.Show();
		}
	}
}
