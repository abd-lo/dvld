using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_DVLD_DataAccess
{
	public class clsApplicationData
	{
		//1 New 2Cancled 3Comp

		public static DataTable GetAllApplications()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM Applications";

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
		public static int AddNewApplication(int ApplicantPersonID, int ApplicationTypeID, DateTime ApplicationDate, DateTime LastStatusDate, byte ApplicationStatus, float PaidFees, int CreatedByUserID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"
INSERT INTO Applications
(ApplicantPersonID, ApplicationTypeID, ApplicationDate, LastStatusDate, ApplicationStatus, PaidFees, CreatedByUserID)
VALUES
(@ApplicantPersonID, @ApplicationTypeID, @ApplicationDate, @LastStatusDate, @ApplicationStatus, @PaidFees, @CreatedByUserID)

SELECT SCOPE_IDENTITY();";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
				command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
				command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
				command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
				command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
				command.Parameters.AddWithValue("@PaidFees", PaidFees);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				connection.Open();
				int ID = Convert.ToInt32(command.ExecuteScalar());
				return ID;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error Adding New Application: " + ex.Message);
				return -1;
			}
			finally
			{
				connection.Close();
			}
		}
		public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, int ApplicationTypeID, DateTime ApplicationDate, DateTime LastStatusDate, byte ApplicationStatus, float PaidFees, int CreatedByUserID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"UPDATE Applications
SET
ApplicantPersonID = @ApplicantPersonID,
ApplicationTypeID = @ApplicationTypeID,
ApplicationDate = @ApplicationDate,
LastStatusDate = @LastStatusDate,
ApplicationStatus = @ApplicationStatus,
PaidFees = @PaidFees,
CreatedByUserID = @CreatedByUserID
WHERE ApplicationID = @ApplicationID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
				command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
				command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
				command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
				command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
				command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
				command.Parameters.AddWithValue("@PaidFees", PaidFees);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating Application: " + ex.Message);
				return false;
			}
			finally
			{

				connection.Close();
			}

		}
		public static bool DeleteApplication(int ApplicationID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"DELETE FROM Applications
WHERE ApplicationID = @ApplicationID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
		public static bool FindApplicationByID(int ApplicationID, ref int ApplicantPersonID, ref int ApplicationTypeID, ref DateTime ApplicationDate, ref DateTime LastStatusDate, ref byte ApplicationStatus, ref float PaidFees, ref int CreatedByUserID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@ApplicationID", ApplicationID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					ApplicantPersonID = reader["ApplicantPersonID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicantPersonID"]) : -1;
					ApplicationStatus =
	reader["ApplicationStatus"] != DBNull.Value
		? Convert.ToByte(reader["ApplicationStatus"])
		: (byte)0;
					ApplicationTypeID = reader["ApplicationTypeID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicationTypeID"]) : -1;
					ApplicationDate = reader["ApplicationDate"] != DBNull.Value ? Convert.ToDateTime(reader["ApplicationDate"]) : DateTime.MinValue;
					LastStatusDate = reader["LastStatusDate"] != DBNull.Value ? Convert.ToDateTime(reader["LastStatusDate"]) : DateTime.MinValue;
					PaidFees = reader["PaidFees"] != DBNull.Value ? Convert.ToSingle(reader["PaidFees"]) : -1f;
					CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : -1;
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


		public static bool UpdateStatus(int ApplicationID, int ApplicationStatus)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"UPDATE Applications
SET
ApplicationStatus = @ApplicationStatus

WHERE ApplicationID = @ApplicationID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
				command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating Application: " + ex.Message);
				return false;
			}
			finally
			{

				connection.Close();
			}

		}

		public static int GetActiveApplicationIDForPersonIDAndLicenseClass(ref int ApplicationID, int ApplicantPersonID, int LicenseClassID)
		{

			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"
select Applications.ApplicationID 
	
	FROM  
	Applications INNER JOIN LocalDrivingLicenseApplications
						 ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID

  where 
  ApplicantPersonID=@ApplicantPersonID and LicenseClassID=@LicenseClassID and ApplicationStatus=1;";


			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
			command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{

					ApplicationID = reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicationID"]) : -1;
				}

				reader.Close();
			}
			catch (Exception ex)
			{
				// Console.WriteLine("Error: " + ex.Message);
				ApplicationID = -1;

			}
			finally
			{
				connection.Close();
			}
			return ApplicationID;
		}

	}
}
