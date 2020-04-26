using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraCharts;

#pragma warning disable CS4014

namespace weatherAPP.weeklyWeather
{
    public partial class weather : UserControl
    {
        public class graph_information
        {
            public string datetime;
            public double temper;
            public double maxTemper;
            public double minTemper;
        }

        public List<MySQL_ORM_Binding.detail_weekly_information> currentData;
        public MySQL_ORM_Binding.weekly_weather currentWeekly;

        public static weather Instance;
        public static bool canLoad = true; 

        UserControl currentSplash;
        UserControl showFullContent;
        Random numberGenerator = new Random();

        detail[] detailPerDay = new detail[5];

        ChartTitle chartTile;
        Series temper;
        Series maxTemper;
        Series minTemper;

        public weather()
        {
            Instance = this;
            this.DoubleBuffered = true;
            currentData = new List<MySQL_ORM_Binding.detail_weekly_information>();

            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                detailPerDay[i] = new detail();
                detailPerDay[i].Dock = DockStyle.Fill;
            }

            panel1.Controls.Add(detailPerDay[0]);
            panel2.Controls.Add(detailPerDay[1]);
            panel3.Controls.Add(detailPerDay[2]);
            panel4.Controls.Add(detailPerDay[3]);
            panel5.Controls.Add(detailPerDay[4]);
        }

        DateTime toLocal(int input)
        {
            DateTime UnixEpoach = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            DateTime localTime = UnixEpoach.AddSeconds(input).ToLocalTime();
            return localTime;
        }

        private async void graph_Load(object sender, EventArgs e)
        {
            await initData();
        }

        public async Task initData(double lat = 10, double lon = 106)
        {
            canLoad = false;

            loadSplashScreen(); 

            weekly_data.RootObject current = await API_caller.requestWeeklyData(lat, lon);

            long weeklyWeatherKey = 0;

            await Task.Factory.StartNew(() =>
            {
                MySqlQuery query = new MySqlQuery();
                weeklyWeatherKey = query.getWeeklyWeatherID();
            });

            currentWeekly = new MySQL_ORM_Binding.weekly_weather
            {
                customer_id = mainApp.customer_id,
                weekly_weather_id = weeklyWeatherKey,
                city_name = current.city.name,
                update_time = "          " + string.Format(
                        "{0:dd/MM/yyyy hh:mm:ss tt}", DateTime.Now)
            };

            currentData.Clear();
            currentWeekly.city_name = current.city.name;

            await Task.Factory.StartNew(() =>
            {
                foreach (var item in current.list)
                {
                    MySQL_ORM_Binding.detail_weekly_information new_tab =
                        new MySQL_ORM_Binding.detail_weekly_information
                        {
                            customer_id = mainApp.customer_id,
                            weekly_weather_id = currentWeekly.weekly_weather_id,
                            unixDateTime = item.dt,
                            main = item.weather[0].main,
                            description = item.weather[0].description,
                            icon_url = item.weather[0].icon,
                            cloud = item.clouds.all,
                            temp_min = item.main.temp_min,
                            temp_max = item.main.temp_max,
                            temp = item.main.temp,
                            wind = item.wind.speed,
                            humid = item.main.humidity
                        };
                    currentData.Add(new_tab);
                }
            });
            await initDisplay();

            currentSplash.Dispose(); 

            await Task.Factory.StartNew(() =>
            {
                MySqlQuery query = new MySqlQuery();
                query.insertWeeklyWeather(currentWeekly, ref currentData);
            });
            canLoad = true; 
        }

        public async Task initDisplay()
        {
            temperChart.Titles.Clear();
            temperChart.Series.Clear();

            if (currentWeekly.city_name == "" || currentWeekly.city_name == "Earth")
            {
                currentWeekly.city_name = "Unidentified City Name";
            }
            else
            {
                if (currentWeekly.city_name.Contains("City") == false)
                    currentWeekly.city_name += " City";
            }
            chartTile = new ChartTitle();
            chartTile.Text = currentWeekly.city_name + " weekly weather data";

            graph_information[] graphInformation = new graph_information[5];

            maxTemper = new Series("max temperature °C", ViewType.Bar);
            minTemper = new Series("min temperature °C", ViewType.Bar);
            temper = new Series("temperature °C", ViewType.Bar);

            string current_date = "";

            int count = 0;
            await Task.Factory.StartNew(() =>
            {
                foreach (var item in currentData)
                {
                    if (current_date == "")
                    {
                        detailPerDay[count].initData(item);
                        current_date = toLocal(item.unixDateTime).DayOfWeek.ToString();

                        graphInformation[count] = new graph_information
                        {
                            datetime = current_date,
                            maxTemper = item.temp_max,
                            minTemper = item.temp_min,
                            temper = item.temp
                        };
                    }
                    else if (current_date != toLocal(item.unixDateTime).DayOfWeek.ToString())
                    {
                        if (count < 4) count = count + 1;

                        detailPerDay[count].initData(item);
                        current_date = toLocal(item.unixDateTime).DayOfWeek.ToString();

                        graphInformation[count] = new graph_information
                        {
                            datetime = current_date,
                            maxTemper = item.temp_max,
                            minTemper = item.temp_min,
                            temper = item.temp
                        };
                    }

                    if (item.temp_max > graphInformation[count].maxTemper)
                        graphInformation[count].maxTemper = item.temp_max;

                    if (item.temp_min < graphInformation[count].minTemper)
                        graphInformation[count].minTemper = item.temp_min;
                }
                initDisplayGraph(graphInformation);

                update.Text = currentWeekly.update_time;
            });

            temperChart.Titles.Add(chartTile);
            temperChart.Series.Add(minTemper);
            temperChart.Series.Add(maxTemper);
            temperChart.Series.Add(temper);
        }

        public void initDisplayGraph(params graph_information[] value)
        {
            foreach (var item in value)
            {
                maxTemper.Points.Add(new SeriesPoint(item.datetime + " Weather",
                    Math.Round(item.maxTemper - 273f, 4)));
                minTemper.Points.Add(new SeriesPoint(item.datetime + " Weather",
                    Math.Round(item.minTemper - 273f, 4)));
                temper.Points.Add(new SeriesPoint(item.datetime + " Weather",
                    Math.Round(item.temper - 273f, 4)));
            }
        }

        public async Task initFullContent()
        {
            loadSplashScreen();

            showFullContent = new weeklyWeather.fullContent();
            showFullContent.Dock = DockStyle.Fill;

            panel.Controls.Add(showFullContent);
            showFullContent.Visible = false;

            await Task.Factory.StartNew(() =>
            {
                (showFullContent as weeklyWeather.fullContent).initData(
                    ref currentData, currentWeekly.city_name);
            });

            showFullContent.Show();
            showFullContent.BringToFront();
            currentSplash.Dispose();
        }

        void loadSplashScreen(int sec = 15000)
        {
            if (currentSplash != null)
            {
                currentSplash.Dispose();
            }
            currentSplash = new splash(sec);
            currentSplash.Dock = DockStyle.Fill;
            panel.Controls.Add(currentSplash);

            currentSplash.BringToFront();
        }

        public void goBack()
        {
            mainPanel.Visible = true;

            if (showFullContent != null)
            {
                showFullContent.Dispose();
            }
        }

        private async void fullContent_Click(object sender, EventArgs e)
        {
            await initFullContent();
        }
    }
}