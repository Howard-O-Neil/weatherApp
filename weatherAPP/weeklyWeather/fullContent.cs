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
	public partial class fullContent : UserControl
	{
		public fullContent()
		{
			this.DoubleBuffered = true;
			InitializeComponent();
		} 

		DateTime toLocal(int input)
		{
			DateTime UnixEpoach = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
			DateTime localTime = UnixEpoach.AddSeconds(input).ToLocalTime();
			return localTime;
		}

		public void initData(ref List<MySQL_ORM_Binding.detail_weekly_information> data, 
			string city)
		{
			label.Text = city;

			string currentData = "";

			foreach (var item in data)
			{
				DateTime currentTime = toLocal(item.unixDateTime);

				if (currentTime.DayOfWeek.ToString() != currentData)
				{
					initDatelabel(string.Format("{0:dd/M/yyyy}", currentTime) + " " +
						currentTime.DayOfWeek);
					currentData = currentTime.DayOfWeek.ToString();
				}

				tab newTab = new tab();
				newTab.Dock = DockStyle.Top;

				Invoke(new Action(() =>
				{
					mainPanel.Controls.Add(newTab);
				}));
				newTab.initData(item);
				newTab.BringToFront();
			}
		}

		public void initDatelabel(string dateInfo)
		{
			Label newLabel = new Label();
			newLabel.BackColor = Color.White;
			newLabel.Font = new Font("Consolas", 24, FontStyle.Bold);

			newLabel.Dock = DockStyle.Top;
			newLabel.Text = dateInfo;
			newLabel.AutoSize = false;

			newLabel.Size = new Size(1469, 59);

			mainPanel.Invoke(new Action(() =>
			{
				mainPanel.Controls.Add(newLabel);
			}));
			newLabel.BringToFront();
		}
	}
}