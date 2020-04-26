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
    public partial class currentWeather : UserControl
    {
        List<tabCurrent> currentTab;
        UserControl currentSplash;

        public bool canRefresh = true;
        public static currentWeather Instance;

        public currentWeather()
        {
            Instance = this;
            currentTab = new List<tabCurrent>();
            this.DoubleBuffered = true;
            InitializeComponent();
        }

        private void currentWeather_Load(object sender, EventArgs e)
        {
            refreshHistory();
        }

        public async void refreshHistory()
        {
            canRefresh = false;

            initSplashScreen(); 

            await Task.Factory.StartNew(() =>
            {
                foreach (var controlItem in currentTab)
                {
                    controlItem.Dispose();
                }
                currentTab.Clear();

                MySqlQuery query = new MySqlQuery(); 
                List<MySQL_ORM_Binding.current_data> currentWeatherData =
                    query.getCurrentWeatherData(mainApp.customer_id);

                foreach (MySQL_ORM_Binding.current_data item in currentWeatherData)
                {
                    Console.WriteLine(item.description);
                    initTabCurrent(item);
                }
            });
            currentSplash.Dispose();
            canRefresh = true;
        }

        private void initTabCurrent(MySQL_ORM_Binding.current_data data)
        {
            var newTab = new tabCurrent(data);
            newTab.Dock = DockStyle.Top;

            currentTab.Add(newTab);

            Invoke(new Action(() =>
            {
                mainPanel.Controls.Add(newTab);
            }));
            newTab.BringToFront();
        }

        private void initSplashScreen()
        {
            if (currentSplash != null)
            {
                currentSplash.Dispose();
            }
            currentSplash = new splash(99999999);
            currentSplash.Dock = DockStyle.Fill;
            this.Controls.Add(currentSplash);

            currentSplash.BringToFront();
            currentSplash.Show();
        }

        public async void clearAll_Click(object sender, EventArgs e)
        {
            var message = new Loading_Information();
            message.StartPosition = FormStartPosition.CenterScreen;
            message.Show();

            await Task.Factory.StartNew(() =>
            {
                MySqlQuery query = new MySqlQuery(); 
                query.deleteAllCurrentWeather(mainApp.customer_id);
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
