using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using System.Data;

namespace weatherAPP
{
	public class MySqlQuery
	{
		public bool checkVersion(string currentVersion)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = "call get_current_version()";
					var res = connection.Query<MySQL_ORM_Binding.current_version>
						(command).ToList();

					string availabledVersion = res[0].assembly_value;

					if (availabledVersion != currentVersion)
					{
						return false;
					}
					else return true;
				}
			}
			catch
			{
				throw new Exception(); 
			}
		}

		public bool checkCustomer(string username, string pass)
		{
			string hashKey = Helper.getHashKey(username, pass);
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call get_customer_information(\"{hashKey}\")";
					var val = connection.Query(command).ToList();

					if (val.Count() > 0) return true;
					else return false;
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public bool checkUsername(string username)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call get_customer_username(\"{username}\")";
					var val = connection.Query(command).ToList();

					if (val.Count() > 0) return false;
					else return true;
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public void insertUserInformation
			(MySQL_ORM_Binding.user_information customer)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = "call insert_customer_information(" +
						$"{customer.customer_id}, " +
						$"\"{customer.first_name}\", " +
						$"\"{customer.last_name}\", " +
						$"\"{customer.customer_user_name}\", " +
						$"\"{customer.customer_password}\")";

					connection.Query(command);
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public void insertCurrentWeather(MySQL_ORM_Binding.current_data data)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call insert_current_weather(" +
						$"{data.customer_id}, " +
						$"\"{data.country}\", " +
						$"\"{data.city}\", " +
						$"\"{data.main}\", " +
						$"\"{data.description}\", " +
						$"\"{data.icon_url}\", " +
						$"{data.temper}, " +
						$"{data.wind}, " +
						$"{data.visibility}, " +
						$"{data.update_time}, " +
						$"{data.sunrise}, " +
						$"{data.sunset}, " +
						$"{data.humid}, " +
						$"{data.cloud})";

					connection.Query(command);
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public void insertWeeklyWeather(MySQL_ORM_Binding.weekly_weather data,
			ref List<MySQL_ORM_Binding.detail_weekly_information> listData)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call insert_weekly_weather(" +
						$"{data.customer_id}, " +
						$"\"{data.city_name}\", " +
						$"\"{data.update_time}\");";

					command += "insert into detail_weekly_information(" +
						"customer_id, weekly_weather_id, main, description, icon_url, " +
						"temp_min, temp_max, temp, wind, cloud, humid, unixDateTime) values";

					foreach (var item in listData)
					{
						command += $"\n(\"{item.customer_id}\", " +
							$"{item.weekly_weather_id}, " +
							$"\"{item.main}\", " +
							$"\"{item.description}\", " +
							$"\"{item.icon_url}\", " +
							$"{item.temp_min}, " + $"{item.temp_max}, " +
							$"{item.temp}, " + $"{item.wind}, " +
							$"{item.cloud}, " + $"{item.humid}, " +
							$"{item.unixDateTime}),";
					}
					command = command.Remove(command.Length - 1);
					command += ';';

					connection.Query(command);
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public void insertNotepadInformation(MySQL_ORM_Binding.notepad_information data)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call insert_notepad_information(" +
						$"{data.customer_id}, " +
						$"\"{data.time_info}\", " +
						$"\"{MySqlHelper.EscapeString(data.content_information)}\")";

					connection.Query(command); 
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public long getWeeklyWeatherID()
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = "call get_weekly_weather_id()";

					long key = connection.Query<long>(command).ToList()[0];
					return key;
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public long getNotepadInformationID()
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = "call get_notepad_information_id()";

					long key = connection.Query<long>(command).ToList()[0];
					return key;
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public List<MySQL_ORM_Binding.current_data> getCurrentWeatherData
			(string customer_id)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call get_current_weather(" +
						$"\"{customer_id}\");";

					var res = connection.Query<MySQL_ORM_Binding.current_data>
						(command).ToList();
					return res;
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public List<MySQL_ORM_Binding.weekly_weather> getWeeklyWeatherData
			(string customer_id)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call get_weekly_weather(" +
						$"\"{customer_id}\");";

					var res = connection.Query<MySQL_ORM_Binding.weekly_weather>(
						command).ToList();
					return res;
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public List<MySQL_ORM_Binding.detail_weekly_information> getDetailWeeklyWeatherData
			(MySQL_ORM_Binding.weekly_weather data)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call get_detail_weekly_weather(" +
						$"\"{data.customer_id}\", " +
						$"{data.weekly_weather_id})";

					var res = connection.Query<MySQL_ORM_Binding.detail_weekly_information>(
						command).ToList();

					if (res.Count <= 5)
					{
						deleteWeeklyWeather(data.customer_id, data.weekly_weather_id);
						throw new Exception();
					}
					else return res;
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public List<MySQL_ORM_Binding.notepad_information> getNotepadInformation
			(string customer_id)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call get_notepad_information(" +
						$"\"{customer_id}\")";

					var res = connection.Query<MySQL_ORM_Binding.notepad_information>
						(command).ToList();
					return res;
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public void updateNotepadInformation(MySQL_ORM_Binding.notepad_information data)
		{
			try
			{
				using (IDbConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call update_notepad_information(" +
						$"\"{data.customer_id}\", " +
						$"\"{data.time_table_id}\", " +
						$"\"{data.content_information}\");";

					connection.Query(command);
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public void deleteCurrentWeather(string customer_id, long currentWeatherID)
		{
			try
			{
				using (MySqlConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call delete_current_weather(" +
						$"\"{customer_id}\", " +
						$"{currentWeatherID})";

					MySqlCommand database_command = new MySqlCommand("", connection);
					database_command.CommandText = command;
					database_command.ExecuteNonQuery();
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public void deleteWeeklyWeather(string customer_id, long weeklyWeatherID)
		{
			try
			{
				using (MySqlConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call delete_weekly_weather(" +
						$"\"{customer_id}\", " +
						$"{weeklyWeatherID})";

					MySqlCommand database_command = new MySqlCommand("", connection);
					database_command.CommandText = command;
					database_command.ExecuteNonQuery();
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public void deleteNotepadInformation(MySQL_ORM_Binding.notepad_information data)
		{
			try
			{
				using (MySqlConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = "call delete_notepad_information(" +
						$"\"{data.customer_id}\", " +
						$"{data.time_table_id})";

					MySqlCommand database_command = new MySqlCommand("", connection);
					database_command.CommandText = command;
					database_command.ExecuteNonQuery();
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public void deleteAllCurrentWeather(string customer_id)
		{
			try
			{
				using (MySqlConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call delete_all_current_weather(" +
						$"\"{customer_id}\")";

					MySqlCommand database_command = new MySqlCommand("", connection);
					database_command.CommandText = command;
					database_command.ExecuteNonQuery();
				}
			}
			catch
			{
				throw new Exception();
			}
		}

		public void deleteAllWeeklyWeather(string customer_id)
		{
			try
			{
				using (MySqlConnection connection = Helper.
					getConnectionString())
				{
					connection.Open();

					string command = $"call delete_all_weekly_weather(\"{customer_id}\")";

					MySqlCommand database_command = new MySqlCommand("", connection);
					database_command.CommandText = command;
					database_command.ExecuteNonQuery();
				}
			}
			catch
			{
				throw new Exception();
			}
		}
	}
}
