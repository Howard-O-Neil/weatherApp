using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherAPP.weeklyWeather
{
	public partial class tab : UserControl
	{
		public tab()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
		}

		DateTime toLocal(int input)
		{
			DateTime UnixEpoach = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			DateTime localTime = UnixEpoach.AddSeconds(input).ToLocalTime();
			return localTime;
		}

		public void initData(MySQL_ORM_Binding.detail_weekly_information value)
		{
			Task.Factory.StartNew(() =>
			{
				string iconUrl = "http://openweathermap.org/img/w/";
				iconUrl += $"{value.icon_url}.png";

				DateTime currentTime = toLocal(value.unixDateTime);

				date.Text = "   " + string.Format("{0:hh:mm:sstt}", currentTime);
				icon.SizeMode = PictureBoxSizeMode.Zoom;
				icon.Load(iconUrl);

				temper.Text = string.Format("{0:F3}", value.temp - 273f) + "°C";
				description.Text = value.main + ": " + value.description;
				humid.Text = "humid rate: " + value.humid + "%";
				wind.Text = "wind speed: " + string.Format("{0:F3}", value.wind / 3.6f) + "km/h";
			});
		}
	}
}
