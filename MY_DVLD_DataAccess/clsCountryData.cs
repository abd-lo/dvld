using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MY_DVLD_DataAccess
{
	public class clsCountryData
	{
	
		public static DataTable GetAllCountries()
		{

			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"SELECT * from Countries";


			SqlCommand command = new SqlCommand(query, connection);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows)

				{
					dt.Load(reader);
				}

				reader.Close();


			}

			catch (Exception ex)
			{
				// Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}

			return dt;

		}


		public static string Find(int CountryID)
		{
		
			string CountryName = "";
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select CountryName from Countries Where CountryID=@CountryID";


			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@CountryID", CountryID);

			try
			{
				connection.Open();

				object result = command.ExecuteScalar();
				if (result != null && result != DBNull.Value)
				{
					CountryName = result.ToString();
				}


			}

			catch (Exception ex)
			{
				// Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}

			return CountryName;

		}

		public static int Find(string CountryName)
		{
			int CountryID=-1;

			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select CountryID from Countries Where CountryName=@CountryName";


			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@CountryName", CountryName);

			try
			{
				connection.Open();

				object result = command.ExecuteScalar();
				if (result != null && result != DBNull.Value)
				{
					CountryID = Convert.ToInt32(result);
				}


			}

			catch (Exception ex)
			{
				// Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}

			return CountryID;

		}










	}
}
