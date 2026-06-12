using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_DVLD_DataAccess
{
	public class clsInternationalLicenseData
	{




		public static DataTable GetAllInternationalLicense()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM InternationalLicense";

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

		public static DataTable GetAllInternationalLicensesBasicInfo()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT        InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
								FROM            InternationalLicenses";

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

		public static DataTable GetAllInternationalLicensesForPersonID(int PersonID)
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT        InternationalLicenses.InternationalLicenseID, InternationalLicenses.ApplicationID, InternationalLicenses.IssuedUsingLocalLicenseID, InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, 
                         InternationalLicenses.IsActive
				FROM            Applications INNER JOIN
                         InternationalLicenses ON Applications.ApplicationID = InternationalLicenses.ApplicationID
						 where Applications.ApplicantPersonID=@PersonID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@PersonID", PersonID);
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

		public static int AddNewInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"
INSERT INTO InternationalLicenses
(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
VALUES
(@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID)

SELECT SCOPE_IDENTITY();";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
				command.Parameters.AddWithValue("@DriverID", DriverID);
				command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
				command.Parameters.AddWithValue("@IssueDate", IssueDate);
				command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
				command.Parameters.AddWithValue("@IsActive", IsActive);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				connection.Open();
				int ID = Convert.ToInt32(command.ExecuteScalar());
				return ID;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error Adding New InternationalLicense: " + ex.Message);
				return -1;
			}
			finally
			{
				connection.Close();
			}
		}

		public static bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"UPDATE InternationalLicense
SET
ApplicationID = @ApplicationID,
DriverID = @DriverID,
IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
IssueDate = @IssueDate,
ExpirationDate = @ExpirationDate,
IsActive = @IsActive,
CreatedByUserID = @CreatedByUserID
WHERE InternationalLicenseID = @InternationalLicenseID;";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
				command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
				command.Parameters.AddWithValue("@DriverID", DriverID);
				command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
				command.Parameters.AddWithValue("@IssueDate", IssueDate);
				command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
				command.Parameters.AddWithValue("@IsActive", IsActive);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating InternationalLicense: " + ex.Message);
				return false;
			}
			finally
			{

				connection.Close();
			}

		}

		public static bool DeleteInternationalLicense(int InternationalLicenseID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"DELETE FROM InternationalLicense
WHERE InternationalLicenseID = @InternationalLicenseID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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

		public static bool FindInternationalLicenseByID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@InternationalLicenseID", InternationalLicenseID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					ApplicationID = reader["ApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["ApplicationID"]) : -1;
					DriverID = reader["DriverID"] != DBNull.Value ? Convert.ToInt32(reader["DriverID"]) : -1;
					IssuedUsingLocalLicenseID = reader["IssuedUsingLocalLicenseID"] != DBNull.Value ? Convert.ToInt32(reader["IssuedUsingLocalLicenseID"]) : -1;
					IssueDate = reader["IssueDate"] != DBNull.Value ? Convert.ToDateTime(reader["IssueDate"]) : DateTime.MinValue;
					ExpirationDate = reader["ExpirationDate"] != DBNull.Value ? Convert.ToDateTime(reader["ExpirationDate"]) : DateTime.MinValue;
					IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(reader["IsActive"]) : false;
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

		public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
		{
			int InternationalLicenseID = -1;

			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"  
                            SELECT Top 1 InternationalLicenseID
                            FROM InternationalLicenses 
                            where DriverID=@DriverID and GetDate() between IssueDate and ExpirationDate 
                            order by ExpirationDate Desc;";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@DriverID", DriverID);

			try
			{
				connection.Open();

				object result = command.ExecuteScalar();

				if (result != null && int.TryParse(result.ToString(), out int insertedID))
				{
					InternationalLicenseID = insertedID;
				}
			}

			catch (Exception ex)
			{
				//Console.WriteLine("Error: " + ex.Message);

			}

			finally
			{
				connection.Close();
			}


			return InternationalLicenseID;
		}

	}



}




