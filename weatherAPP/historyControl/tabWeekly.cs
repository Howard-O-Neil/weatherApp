using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherAPP.historyControl
{
    public partial class tabWeekly : UserControl
    {
        public MySQL_ORM_Binding.weekly_weather weeklyData =
            new MySQL_ORM_Binding.weekly_weather();

        public List<MySQL_ORM_Binding.detail_weekly_information> detailWeeklyData =
            new List<MySQL_ORM_Binding.detail_weekly_information>();

        public tabWeekly()
        {
            InitializeComponent();
        }

        public tabWeekly(MySQL_ORM_Binding.weekly_weather weekly)
        {
            weeklyData = weekly;

            InitializeComponent();
        }

        private void tabWeekly_Load(object sender, EventArgs e)
        {
            this.label.Text = weeklyData.update_time.Substring(10);

            if (weeklyData.city_name == "" || weeklyData.city_name == "Earth")
            {
                this.location.Text = "Unidentified Data Location From Server";
            }
            else
            {
                if (weeklyData.city_name.Contains("City") == false)
                    this.location.Text = weeklyData.city_name + " City";
                else this.location.Text = weeklyData.city_name;
            }
        }

        private async void cancel_Click(object sender, EventArgs e)
        {
            var message = new Loading_Information();
            message.StartPosition = FormStartPosition.CenterScreen;
            message.Show();

            await Task.Factory.StartNew(() =>
            {
                MySqlQuery query = new MySqlQuery(); 
                query.deleteWeeklyWeather(
                    mainApp.customer_id, weeklyData.weekly_weather_id);
            });

            message.Dispose();
            this.Dispose();
        }

        private async void label_Click(object sender, EventArgs e)
        {
            var message = new Loading_Information();
            message.StartPosition = FormStartPosition.CenterScreen;
            message.Show();

            await Task.Factory.StartNew(() =>
            {
                MySqlQuery query = new MySqlQuery(); 
                detailWeeklyData = query.getDetailWeeklyWeatherData(weeklyData);
            });

			weatherAPP.weeklyWeather.weather.Instance.currentWeekly = weeklyData;
			weatherAPP.weeklyWeather.weather.Instance.currentData = detailWeeklyData; 

			await weatherAPP.weeklyWeather.weather.Instance.initDisplay(); 
			message.Dispose(); 

			weatherInfo.information.Instance.weekly_Click(null, null); 
        }
    }
}
