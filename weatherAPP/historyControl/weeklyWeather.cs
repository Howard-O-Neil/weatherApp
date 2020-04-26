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
    public partial class weeklyWeather : UserControl
    {
        public static weeklyWeather Instance;
        public bool canRefresh = true;

        List<tabWeekly> currentTab;
        UserControl currentSplash;

        public weeklyWeather()
        {
            Instance = this;
            InitializeComponent();

            currentTab = new List<tabWeekly>();
            this.DoubleBuffered = true;
        }

        private void weeklyWeather_Load(object sender, EventArgs e)
        {
            refreshHistory();
        }

        public async void refreshHistory()
        {
            canRefresh = false;

            if (currentSplash != null)
            {
                currentSplash.Dispose();
            }
            currentSplash = new splash(99999999);
            currentSplash.Dock = DockStyle.Fill;
            this.Controls.Add(currentSplash);

            currentSplash.BringToFront();
            currentSplash.Show();

            await Task.Factory.StartNew(() =>
            {
                foreach (var controlItem in currentTab)
                {
                    controlItem.Dispose();
                }
                currentTab.Clear();

                MySqlQuery query = new MySqlQuery(); 
                List<MySQL_ORM_Binding.weekly_weather> currentWeatherData =
                    query.getWeeklyWeatherData(mainApp.customer_id);

                foreach (MySQL_ORM_Binding.weekly_weather item in currentWeatherData)
                {
                    Console.WriteLine(item.city_name);
                    initTabWeekly(item);
                }
            });
            currentSplash.Dispose();
            canRefresh = true;
        }

        private void initTabWeekly(MySQL_ORM_Binding.weekly_weather data)
        {
            var newTab = new tabWeekly(data);
            newTab.Dock = DockStyle.Top;

            currentTab.Add(newTab);

            Invoke(new Action(() =>
            {
                mainPanel.Controls.Add(newTab);
            }));
            newTab.BringToFront();
        }

        private async void clearAll_Click(object sender, EventArgs e)
        {
            var message = new Loading_Information();
            message.StartPosition = FormStartPosition.CenterScreen;
            message.Show();

            await Task.Factory.StartNew(() =>
            {
                MySqlQuery query = new MySqlQuery(); 
                query.deleteAllWeeklyWeather(mainApp.customer_id);
            });

            Task.Factory.StartNew(() =>
            {
                foreach (var controlItem in currentTab)
                {
                    controlItem.Dispose();
                }
                currentTab.Clear();
            });
            message.Dispose();
        }
    }
}
