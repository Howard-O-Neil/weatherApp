using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 
using MySql.Data; 

namespace weatherAPP
{
	public static class Helper
	{
		static string server = "194.59.164.22"; 
		static string database = "u757834126_weatherInfo"; 
		static string user = "u757834126_mingkhoi"; 
		static string pass = "database"; 
		
		public static MySqlConnection getConnectionString()
		{
			MySqlConnectionStringBuilder connection = 
				new MySqlConnectionStringBuilder();
				
			connection.Server = server; 
			connection.Database = database; 
			connection.UserID = user; 
			connection.Password = pass;
			// connection.Port = 3306;

			return new MySqlConnection(connection.ToString()); 
		}

		public static string getHashKey(string username, string pass)
		{
			long res = 0; 

			for (int i = 0; i < username.Length; i++)
				res += username[i] * (i + 1);
			for (int i = 0; i < pass.Length; i++)
				res += pass[i] * (i + 1); 
			
			return res.ToString(); 
		}
	}
}
