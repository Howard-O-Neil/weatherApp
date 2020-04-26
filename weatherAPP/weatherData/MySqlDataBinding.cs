using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; 

namespace weatherAPP
{
	namespace MySQL_ORM_Binding
	{
		public class user_information
		{
			public string customer_id { get; set; }
			public string first_name { get; set; }
			public string last_name { get; set; }
			public string customer_user_name { get; set; }
			public string customer_password { get; set; }
		}

		public class current_data
		{
			public string customer_id { get; set; }
			public long current_weather_id { get; set; }
			public string country { get; set; }
			public string city { get; set; }
			public string main { get; set; }
			public string description { get; set; }
			public string icon_url { get; set; }
			public double temper { get; set; }
			public double wind { get; set; }
			public double visibility { get; set; }
			public int update_time { get; set; }
			public int sunrise { get; set; }
			public int sunset { get; set; }
			public int humid { get; set; }
			public int cloud { get; set; }
		}	

		public class weekly_weather
		{
			public string customer_id { get; set; }
			public long weekly_weather_id { get; set; }
			public string city_name { get; set; }
			public string update_time { get; set; }
		}

		public class detail_weekly_information
		{
			public string customer_id { get; set; }
			public long weekly_weather_id { get; set; }
			public long detail_weekly_information_id { get; set; }
			public string main { get; set; }
			public string description { get; set; }
			public string icon_url { get; set; }
			public double temp_min { get; set; }
			public double temp_max { get; set; }
			public double temp { get; set; }
			public double wind { get; set; }
			public int cloud { get; set; }
			public int humid { get; set; }
			public int unixDateTime { get; set; }
	}

		public class notepad_information
		{
			public string customer_id { get; set; }
			public long time_table_id { get; set; }
			public string time_info { get; set; }
			public string content_information { get; set; }
		}

		public class current_version
		{
			public string assembly_value { get; set; }
		}
	}
}
