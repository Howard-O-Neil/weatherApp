using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace weatherAPP.weatherInfo
{
    public partial class information : UserControl
    {
        UserControl[] controlTable = new UserControl[7];

        public static information Instance;

        public information()
        {
            Instance = this;
            Control.CheckForIllegalCrossThreadCalls = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.DoubleBuffered = true;

            InitializeComponent();
            subMenu.Height = 0;

            (subMenu as historyControl.subMenu).currentClick +=
                new EventHandler(currentWeather_Click);

            (subMenu as historyControl.subMenu).weeklyClick +=
                new EventHandler(weeklyWeather_Click);
        }

        private async void Information_Load(object sender, EventArgs e)
        {
            controlTable[0] = new weatherControl.weather();
            controlTable[1] = new weeklyWeather.weather();
            controlTable[2] = new bingMapControl.map();
            //controlTable[3] = new newsControl.news();
            controlTable[4] = new historyControl.currentWeather();
            controlTable[5] = new historyControl.weeklyWeather();
            controlTable[6] = new notepad.note(); 

            await Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 7; i++)
                {
                    if (i == 3) continue; // temporarily skip the news control 

                    controlTable[i].Dock = DockStyle.Fill;

                    mainPanel.Invoke(new Action(() =>
                    {
                        mainPanel.Controls.Add(controlTable[i]);
                    }));
                    controlTable[i].Show();
                }
            });
        }

        private void openSubMenu()
        {
            subMenu.Height = 149;
            subMenu.Visible = false;

            sliding.ShowSync(subMenu);
        }

        private void hideSubMenu()
        {
            subMenu.Height = 0;
        }

        #region UI_Button

        public void current_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            controlTable[0].BringToFront();
        }

        public void weekly_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            controlTable[1].BringToFront();
        }

        public void mapButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            returnButton_Click(null, null);
            controlTable[2].BringToFront();
        }

        public void newsButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //controlTable[3].BringToFront();
        }

        private void noteButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            controlTable[6].BringToFront();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            weeklyWeather.weather.Instance.goBack();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            openSubMenu();
        }

        private void currentWeather_Click(object sender, EventArgs e)
        {
            controlTable[4].BringToFront();
        }

        private void weeklyWeather_Click(object sender, EventArgs e)
        {
            controlTable[5].BringToFront();
        }

        #endregion


        public void resetControl()
        {
            Application.Restart(); 
        }
    }
}