using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MY_DVLD_DataAccess
{
	public class clsLicenseData
	{
		//	int LicenseID
		//, ApplicationID
		//, DriverID
		//, LicenseClass
		//, IssueDate
		//, ExpirationDate
		//, Notes
		//, PaidFees
		//, IsActive
		//, IssueReason
		//, CreatedByUserID

		public static DataTable GetAllLicenses()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM Licenses";

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

		public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive, int CreatedByUserID, byte IssueReason)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"
INSERT INTO Licenses
(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, CreatedByUserID, IssueReason)
VALUES
(@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @CreatedByUserID, @IssueReason)

SELECT SCOPE_IDENTITY();";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
				command.Parameters.AddWithValue("@DriverID", DriverID);
				command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
				command.Parameters.AddWithValue("@IssueDate", IssueDate);
				command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
				command.Parameters.AddWithValue("@Notes", Notes);
				command.Parameters.AddWithValue("@PaidFees", PaidFees);
				command.Parameters.AddWithValue("@IsActive", IsActive);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				command.Parameters.AddWithValue("@IssueReason", IssueReason);
				connection.Open();
				int ID = Convert.ToInt32(command.ExecuteScalar());
				return ID;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error Adding New License: " + ex.Message);
				return -1;
			}
			finally
			{
				connection.Close();
			}
		}

		public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive, int CreatedByUserID, byte IssueReason)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"UPDATE Licenses
SET
ApplicationID = @ApplicationID,
DriverID = @DriverID,
LicenseClassID = @LicenseClassID,
IssueDate = @IssueDate,
ExpirationDate = @ExpirationDate,
Notes = @Notes,
PaidFees = @PaidFees,
IsActive = @IsActive,
CreatedByUserID = @CreatedByUserID,
IssueReason = @IssueReason
WHERE LicenseID = @LicenseID;";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@LicenseID", LicenseID);
				command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
				command.Parameters.AddWithValue("@DriverID", DriverID);
				command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
				command.Parameters.AddWithValue("@IssueDate", IssueDate);
				command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
				command.Parameters.AddWithValue("@Notes", Notes);
				command.Parameters.AddWithValue("@PaidFees", PaidFees);
				command.Parameters.AddWithValue("@IsActive", IsActive);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				command.Parameters.AddWithValue("@IssueReason", IssueReason);
				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating License: " + ex.Message);
				return false;
			}
			finally
			{

				connection.Close();
			}

		}

		public static bool DeleteLicense(int LicenseID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"DELETE FROM Licenses
WHERE LicenseID = @LicenseID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@LicenseID", LicenseID);

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

		public static bool FindLicenseByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref float PaidFees, ref bool IsActive, ref int CreatedByUserID, ref byte IssueReason)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LicenseID", LicenseID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					ApplicationID = reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicationID"]) : -1;
					DriverID = reader["DriverID"] != DBNull.Value ? Convert.ToInt32(reader["DriverID"]) : -1;
					LicenseClassID = reader["LicenseClass"] != DBNull.Value ? Convert.ToInt32(reader["LicenseClass"]) : -1;
					IssueDate = reader["IssueDate"] != DBNull.Value ? Convert.ToDateTime(reader["IssueDate"]) : DateTime.MinValue;
					ExpirationDate = reader["ExpirationDate"] != DBNull.Value ? Convert.ToDateTime(reader["ExpirationDate"]) : DateTime.MinValue;
					Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : string.Empty;
					PaidFees = reader["PaidFees"] != DBNull.Value ? Convert.ToSingle(reader["PaidFees"]) : -1f;
					IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(reader["IsActive"]) : false;
					CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : -1;
					IssueReason = reader["IssueReason"] != DBNull.Value ? Convert.ToByte(reader["IssueReason"]) : (byte)0;
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

		public static bool IsActiveLicenseForPersonIDAndLicenseClassExisted(int PersonID, int LicenseClassID)

		{

			return GetActiveLicenseIDByPersonIDAndLicenseClass(PersonID, LicenseClassID)!=-1;


		}

		public static int GetActiveLicenseIDByPersonIDAndLicenseClass(int PersonID, int LicenseClassID)
		{
			int LicenseID = -1;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"			
			SELECT L.LicenseID
			FROM            
			Licenses as L INNER JOIN Drivers as D ON L.DriverID = D.DriverID
			where 
			LicenseClass=@LicenseClassID and PersonID=@PersonID and IsActive=1;";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@PersonID", PersonID);
			command.Parameters.AddWithValue($"@LicenseClassID", LicenseClassID);

			try
			{
				connection.Open();

				object result = command.ExecuteScalar();

				if (result != null && int.TryParse(result.ToString(), out int ResultLincenseID))
				{
					LicenseID = ResultLincenseID;
				}

			}
			catch (Exception ex)
			{
				// Console.WriteLine("Error: " + ex.Message);
				LicenseID = -1;
			}
			finally
			{
				connection.Close();
			}
			return LicenseID;
		}

		public static int GetDefaultValidityLength(int LicenseClassID)
		{
			int DefaultValidityLength = -1;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"			
			SELECT DefaultValidityLength
			FROM            
			LicenseClasses
			where 
			LicenseClass=@LicenseClassID;";

			SqlCommand command = new SqlCommand(query, connection);
			
			command.Parameters.AddWithValue($"@LicenseClassID", LicenseClassID);

			try
			{
				connection.Open();

				object result = command.ExecuteScalar();

				if (result != null && int.TryParse(result.ToString(), out int Result))
				{
					DefaultValidityLength = Result;
				}

			}
			catch (Exception ex)
			{
				// Console.WriteLine("Error: " + ex.Message);
				DefaultValidityLength = -1;
			}
			finally
			{
				connection.Close();
			}
			return DefaultValidityLength;
		}


	}
}


