using MY_DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MY_DVLD_DataAccess
{
	public class clsLocalDrivingLicenseApplicationData
	{

		public static DataTable GetAllLocalDrivingLicenseApplications()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM LocalDrivingLicenseApplications_View";

			SqlCommand command = new SqlCommand(query, connection);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					dt.Load(reader);
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

			return dt;
		}

		public static int AddNewLocalDrivingLicenseApplication(int LicenseClassID, int ApplicationID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"
INSERT INTO LocalDrivingLicenseApplications
(LicenseClassID, ApplicationID)
VALUES
(@LicenseClassID, @ApplicationID)

SELECT SCOPE_IDENTITY();";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
				command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
				connection.Open();
				int ID = Convert.ToInt32(command.ExecuteScalar());
				return ID;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error Adding New LocalDrivingLicenseApplication: " + ex.Message);
				return -1;
			}
			finally
			{
				connection.Close();
			}
		}

		public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int LicenseClassID, int ApplicationID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"UPDATE LocalDrivingLicenseApplications
SET
LicenseClassID = @LicenseClassID,
ApplicationID = @ApplicationID
WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";


				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
				command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
				command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating LocalDrivingLicenseApplication: " + ex.Message);
				return false;
			}
			finally
			{

				connection.Close();
			}

		}

		public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"DELETE FROM LocalDrivingLicenseApplications
WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error Deleting record: " + ex.Message);
				return false;
			}
			finally
			{
				connection.Close();
			}
		}

		public static bool FindLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID, ref int LicenseClassID, ref int ApplicationID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					LicenseClassID = reader["LicenseClassID"] != DBNull.Value ? Convert.ToInt32(reader["LicenseClassID"]) : -1;
					ApplicationID = reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicationID"]) : -1;
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

		public static bool IsTestPassedByTestTypeAndLocalDrivingLicneseAppID(int LocalDrivingLicenseApplicationID, int TestTypeID)
		{
			bool IsPassed = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"
			SELECT      top 1 TestResult
			FROM   Tests INNER JOIN
                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
						 where TestResult=1 and TestTypeID=@TestTypeID and LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID
						 order by Tests.TestAppointmentID Desc";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
			command.Parameters.AddWithValue($"@TestTypeID", TestTypeID);


			try
			{
				connection.Open();

				object result = command.ExecuteScalar();

				if (result != null && bool.TryParse(result.ToString(), out bool Output))
				{
					IsPassed = Output;
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
			return IsPassed;
		}

		public static bool DoesAttendedTestByTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"
			select  top 1 Found=1 from 
			Tests join TestAppointments 
			ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
			where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestTypeID=@TestTypeID;";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
			command.Parameters.AddWithValue($"@TestTypeID", TestTypeID);


			try
			{
				connection.Open();

				object result = command.ExecuteScalar();

				if (result != null)
				{
					IsFound = true;
				}

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
