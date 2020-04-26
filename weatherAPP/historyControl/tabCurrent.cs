using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#pragma warning disable CS4014

namespace weatherAPP.historyControl
{
	public partial class tabCurrent : UserControl
	{
		public MySQL_ORM_Binding.current_data data =
			new MySQL_ORM_Binding.current_data();
		
		public tabCurrent()
		{
			InitializeComponent();
		}

		DateTime toLocal(int input) // input the unix code
		{
			DateTime UnixEpoach = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			DateTime localTime = UnixEpoach.AddSeconds(input).ToLocalTime();
			return localTime;
		}

		public tabCurrent(MySQL_ORM_Binding.current_data value)
		{
			data = value;
			InitializeComponent();
		}

		private void tabCurrent_Load(object sender, EventArgs e)
		{
			label.Text = string.Format("{0:dd/MM/yyyy hh:mm:ss tt}", 
				toLocal(data.update_time));

			if (data.city == "" || data.city == "Earth")
			{
				location.Text = "Unidentified Data Location From Server"; 
			}
			else location.Text = data.country + ", " + data.city;
		}

		private async void label_Click(object sender, EventArgs e)
		{
			var message = new Loading_Information();
			message.StartPosition = FormStartPosition.CenterScreen;
			message.Show(); 

			weatherControl.weather.Instance.currentData = data;
			await weatherControl.weather.Instance.initDisplay();
			message.Dispose(); 

			weatherInfo.information.Instance.current_Click(null, null);
		}

		private async void cancel_Click(object sender, EventArgs e)
		{
			var message = new Loading_Information();
			message.StartPosition = FormStartPosition.CenterScreen;
			message.Show(); 

			await Task.Factory.StartNew(() =>
			{
				MySqlQuery query = new MySqlQuery(); 
				query.deleteCurrentWeather
					(mainApp.customer_id, data.current_weather_id); 
			});

			message.Dispose(); 
			this.Dispose();
		}
	}
}
