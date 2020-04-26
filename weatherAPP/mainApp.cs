using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace weatherAPP
{
	public partial class mainApp : Form
	{
		public static mainApp Instance;
		public static string customer_id;

		Point LastLocation;
		bool isDragging = false;

		UserControl currentControl = null;

		UserControl splashScreen = null;

		public mainApp()
		{
			Instance = this;
			InitializeComponent();

			this.FormClosing += 
				new FormClosingEventHandler(cancel_Click);
			this.Load += new EventHandler(loadHandle);

			this.KeyPreview = true;
			this.DoubleBuffered = true;
		}

		void loadHandle(object sender, EventArgs e)
		{
			loadSplashScreen(7);
			initNewControl();
		}

		public void initNewControl()
		{
			currentControl = new weatherInfo.information();

			Thread newThread = new Thread(() =>
			{
				currentControl.Dock = DockStyle.Fill;

				mainPanel.Invoke(new Action(() =>
					mainPanel.Controls.Add(currentControl)));

				Invoke(new Action(() =>
				{
					currentControl.Show();
				}));
			});
			newThread.Start();
		}

		void loadSplashScreen(int sec)
		{
			splashScreen = new splash(sec);

			Task.Factory.StartNew(() =>
			{
				splashScreen.Dock = DockStyle.Fill;

				mainPanel.Invoke(new Action(() =>
					mainPanel.Controls.Add(splashScreen)));

				splashScreen.Show();
			});
		}  

		#region necsessoryStuff

		private void TitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			isDragging = true;
			LastLocation = e.Location;
		}

		private void TitleBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging == true)
			{
				this.Location = new Point(this.Location.X - LastLocation.X + e.X,
					this.Location.Y - LastLocation.Y + e.Y);
				this.Update();
			}
		}

		private void TitleBar_MouseUp(object sender, MouseEventArgs e)
		{
			isDragging = false;
		}

		private void cancel_Click(object sender, FormClosingEventArgs e)
		{
			this.Hide();

			System.Windows.Forms.Timer newTimer =
				new System.Windows.Forms.Timer();
			newTimer.Interval = 1000;

			newTimer.Tick += new EventHandler(time_tick);
			newTimer.Start();
		}

		private void minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		#endregion

		private void mainApp_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F5)
			{
				if (historyControl.currentWeather.Instance.canRefresh == true)
				{
					historyControl.currentWeather.Instance.refreshHistory();
				}
				if (historyControl.weeklyWeather.Instance.canRefresh == true)
				{
					historyControl.weeklyWeather.Instance.refreshHistory();
				}
			}
			else if (e.KeyCode == Keys.F9)
			{
				weatherInfo.information.Instance.resetControl();
			}
		}

		int countCancel = 30;
		private void time_tick(object sender, EventArgs e)
		{
			countCancel--;
			if (countCancel == 0)
			{
				Application.Exit();
			}
		}
	}
}