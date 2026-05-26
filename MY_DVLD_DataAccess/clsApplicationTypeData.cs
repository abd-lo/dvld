using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MY_DVLD_DataAccess
{
	public class clsApplicationTypeData
	{


		public static DataTable GetAllApplicationTypes()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"SELECT * from ApplicationTypes";


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

		public static bool UpdateApplicationTypeData(int ApplicationTypeID, string ApplicationTypeTitle, double ApplicationFees)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			bool IsUpdated = false;

			string query = @"Update ApplicationTypes set
			ApplicationTypeTitle=@ApplicationTypeTitle,
			ApplicationFees=@ApplicationFees
			where ApplicationTypeID=@ApplicationTypeID";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
			command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
			command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);


			try
			{
				connection.Open();

				int rowsAffected = command.ExecuteNonQuery();

				IsUpdated = (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message

				IsUpdated = false;
			}
			finally
			{
				connection.Close();
			}
			return IsUpdated;

		}

		public static bool FindApplicationTypeByApplicationID(int ApplicationTypeID, ref string ApplicationTypeTitle, ref float ApplicationFees)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			bool IsFound = false;

			string query = @"SELECT * from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					ApplicationTypeTitle = reader["ApplicationTypeTitle"]?.ToString();
					ApplicationFees = float.Parse(reader["ApplicationFees"]?.ToString());
					IsFound = true;
				}

				reader.Close();

			}

			catch (Exception ex)
			{
				// Console.WriteLine("Error: " + ex.Message);
				IsFound = false;
			}
			finally
			{
				connection.Close();
			}

			return IsFound;

		}


	}
}
