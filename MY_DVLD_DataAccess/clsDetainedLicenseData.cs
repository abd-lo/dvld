using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace MY_DVLD_DataAccess
{
	public class clsDetainedLicenseData
	{
		//	SELECT DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.IsReleased, DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNo,
		//Concat(People.FirstName, People.SecondName, People.ThirdName, People.LastName) As FullName, DetainedLicenses.ReleaseApplicationID
		//	FROM            DetainedLicenses INNER JOIN
		//	Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN


		//						 Applications ON Licenses.ApplicationID = Applications.ApplicationID INNER JOIN

		//						 People ON Applications.ApplicantPersonID = People.PersonID
		public static DataTable GetDetainedLicenseWithData()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"
			SELECT DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.IsReleased, DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate, People.NationalNo,
		Concat(People.FirstName, People.SecondName, People.ThirdName, People.LastName) As FullName, DetainedLicenses.ReleaseApplicationID
			FROM            
			DetainedLicenses INNER JOIN
								Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN
								 Applications ON Licenses.ApplicationID = Applications.ApplicationID INNER JOIN

								 People ON Applications.ApplicantPersonID = People.PersonID;
			";

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

		public static DataTable GetAllDetainedLicenses()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM DetainedLicenses";

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

		public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"
									INSERT INTO DetainedLicenses
									(LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased)
									VALUES
									(@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased)

									SELECT SCOPE_IDENTITY();";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@LicenseID", LicenseID);
				command.Parameters.AddWithValue("@DetainDate", DetainDate);
				command.Parameters.AddWithValue("@FineFees", FineFees);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				command.Parameters.AddWithValue("@IsReleased", 0);


				connection.Open();
				int ID = Convert.ToInt32(command.ExecuteScalar());
				return ID;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error Adding New DetainedLicense: " + ex.Message);
				return -1;
			}
			finally
			{
				connection.Close();
			}
		}

		public static bool UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"UPDATE DetainedLicenses
									SET
									LicenseID = @LicenseID,
									DetainDate = @DetainDate,
									FineFees = @FineFees,
									CreatedByUserID = @CreatedByUserID,
									IsReleased = @IsReleased,
									ReleaseDate = @ReleaseDate,
									ReleasedByUserID = @ReleasedByUserID,
									ReleaseApplicationID = @ReleaseApplicationID

									WHERE DetainID = @DetainID;";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@DetainID", DetainID);
				command.Parameters.AddWithValue("@LicenseID", LicenseID);
				command.Parameters.AddWithValue("@DetainDate", DetainDate);
				command.Parameters.AddWithValue("@FineFees", FineFees);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				command.Parameters.AddWithValue("@IsReleased", IsReleased);
				command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
				command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
				command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating DetainedLicense: " + ex.Message);
				return false;
			}
			finally
			{

				connection.Close();
			}

		}

		public static bool DeleteDetainedLicense(int DetainID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"DELETE FROM DetainedLicenses
WHERE DetainID = @DetainID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@DetainID", DetainID);

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

		public static bool FindDetainedLicenseByID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@DetainID", DetainID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					LicenseID = reader["LicenseID"] != DBNull.Value ? Convert.ToInt32(reader["LicenseID"]) : -1;
					DetainDate = reader["DetainDate"] != DBNull.Value ? Convert.ToDateTime(reader["DetainDate"]) : DateTime.MinValue;
					FineFees = reader["FineFees"] != DBNull.Value ? Convert.ToSingle(reader["FineFees"]) : -1f;
					CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : -1;
					IsReleased = reader["IsReleased"] != DBNull.Value ? Convert.ToBoolean(reader["IsReleased"]) : false;
					ReleaseDate = reader["ReleaseDate"] != DBNull.Value ? Convert.ToDateTime(reader["ReleaseDate"]) : DateTime.MinValue;
					ReleasedByUserID = reader["ReleasedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["ReleasedByUserID"]) : -1;
					ReleaseApplicationID = reader["ReleaseApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["ReleaseApplicationID"]) : -1;
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

		public static bool FindDetainedLicenseByLicenseID(ref int DetainID, int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @" select top 1 * from DetainedLicenses where LicenseID= @LicenseID
							order by DetainID Desc";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LicenseID", LicenseID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					DetainID = reader["DetainID"] != DBNull.Value ? Convert.ToInt32(reader["DetainID"]) : -1;
					DetainDate = reader["DetainDate"] != DBNull.Value ? Convert.ToDateTime(reader["DetainDate"]) : DateTime.MinValue;
					FineFees = reader["FineFees"] != DBNull.Value ? Convert.ToSingle(reader["FineFees"]) : -1f;
					CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : -1;
					IsReleased = reader["IsReleased"] != DBNull.Value ? Convert.ToBoolean(reader["IsReleased"]) : false;
					ReleaseDate = reader["ReleaseDate"] != DBNull.Value ? Convert.ToDateTime(reader["ReleaseDate"]) : DateTime.MinValue;
					ReleasedByUserID = reader["ReleasedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["ReleasedByUserID"]) : -1;
					ReleaseApplicationID = reader["ReleaseApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["ReleaseApplicationID"]) : -1;
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


		public static bool IsLicenseDetainedByLicenseID(int LicenseID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT 1 FROM DetainedLicenses WHERE LicenseID = @LicenseID and IsReleased=0 ";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LicenseID", LicenseID);

			try
			{
				connection.Open();
				object result = command.ExecuteScalar();
				if (result != null && int.TryParse(result.ToString(), out int Output))
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
