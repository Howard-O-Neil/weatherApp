using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraMap;
using System.Threading;

#pragma warning disable CS4014

namespace weatherAPP.bingMapControl
{
	public partial class map : UserControl
	{
		string bingKey = "y4Nh1LNevasmA3eXxYW2~YlMNJfPNd0legiZUiP3ZyQ~A" +
			"pXv1IT4ktXEqOrCck9n2v4Pq1LO8EYk9PySKdnDftCZebzXmgbPlEXjKx7_H39b";

		GeoPoint currentMapPoint = new GeoPoint(0, 0); // current point 

		public map()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;

			bingMapDataProvider.BingKey = bingKey;
			bingSearchDataProvider.BingKey = bingKey;

			bingSearchDataProvider.SearchCompleted +=
				new BingSearchCompletedEventHandler(search_Complete);

			mapControl.NavigationPanelOptions.Visible = false;
			mapControl.ZoomLevel = 3;
			mapControl.EnableZooming = false;
		}

		private void search_Complete(object sender, BingSearchCompletedEventArgs e)
		{
			Task.Factory.StartNew(() =>
			{
				if (e.RequestResult.SearchResults.Count > 0)
				{
					string name = e.RequestResult.Keyword;

					foreach (BingLocationInformation info in e.RequestResult.SearchResults)
					{
						if (info.DisplayName == name)
						{
							currentMapPoint = info.Location;
							break;
						}
					}
				}
			});
		}

		private async void getLocation_Click(object sender, EventArgs e)
		{
			weatherInfo.information.Instance.current_Click(null, null);

			if (weeklyWeather.weather.canLoad == true &&
				weatherControl.weather.canLoad == true)
			{
				weatherControl.weather.Instance.initData
					(currentMapPoint.Latitude, currentMapPoint.Longitude);

				weeklyWeather.weather.Instance.initData
					(currentMapPoint.Latitude, currentMapPoint.Longitude);
			}
		}
	}
}
