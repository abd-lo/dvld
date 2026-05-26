using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MY_DVLD_DataAccess
{
	public class clsTestData
	{

		public static DataTable GetAllTests()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM Tests";

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

		public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
		{
			//when adding a new test we Lock the appointmnet
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"
						INSERT INTO Tests
						(TestAppointmentID, TestResult, Notes, CreatedByUserID)
						VALUES
						(@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID)
						
						update TestAppointments Set IsLocked=1
						where TestAppointmentID=@TestAppointmentID;

						SELECT SCOPE_IDENTITY();";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
				command.Parameters.AddWithValue("@TestResult", TestResult);
				command.Parameters.AddWithValue("@Notes", Notes);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				connection.Open();
				int ID = Convert.ToInt32(command.ExecuteScalar());
				return ID;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error Adding New Test: " + ex.Message);
				return -1;
			}
			finally
			{
				connection.Close();
			}
		}

		public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"UPDATE Tests
		SET
		TestAppointmentID = @TestAppointmentID,
		TestResult = @TestResult,
		Notes = @Notes,
		CreatedByUserID = @CreatedByUserID
		WHERE TestID = @TestID;";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@TestID", TestID);
				command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
				command.Parameters.AddWithValue("@TestResult", TestResult);
				command.Parameters.AddWithValue("@Notes", Notes);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating Test: " + ex.Message);
				return false;
			}
			finally
			{

				connection.Close();
			}

		}

		public static bool DeleteTest(int TestID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"DELETE FROM Tests
WHERE TestID = @TestID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@TestID", TestID);

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

		public static bool FindTestByID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM Tests WHERE TestID = @TestID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@TestID", TestID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					TestAppointmentID = reader["TestAppointmentID"] != DBNull.Value ? Convert.ToInt32(reader["TestAppointmentID"]) : -1;
					TestResult = reader["TestResult"] != DBNull.Value ? Convert.ToBoolean(reader["TestResult"]) : false;
					Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : string.Empty;
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


		public static int GetPassedTestsCount(int LocalDrivingLicenseApplicationID)
		{
			int PassedTestsCount = -1;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"
			SELECT COUNT(*) AS PassedTests
FROM (
    SELECT 
        TestAppointments.LocalDrivingLicenseApplicationID,
        TestAppointments.TestTypeID,
        Tests.TestResult
    FROM Tests
    INNER JOIN TestAppointments 
        ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
) AS T
WHERE 
    LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
    AND TestResult = 1;";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


			try
			{
				connection.Open();

				object result = command.ExecuteScalar();

				if (result != null && int.TryParse(result.ToString(), out int Output))
				{
					PassedTestsCount = Output;
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
			return PassedTestsCount;
		}


		public static int GetTestIDForTestAppointment(int TestAppointmentID)
		{
			int TestID = -1;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"
				select TestID From Tests Where Tests.TestAppointmentID=@TestAppointmentID;";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@TestAppointmentID", TestAppointmentID);


			try
			{
				connection.Open();

				object result = command.ExecuteScalar();

				if (result != null && int.TryParse(result.ToString(), out int Output))
				{
					TestID = Output;
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
			return TestID;
		}

		public static bool GetLastTestByPersonIDAndTestType(int PersonID, int TestTypeID, int LicenseClassID, ref int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"
			SELECT        Tests.TestID, Tests.TestAppointmentID, Tests.TestResult, Tests.Notes, Tests.CreatedByUserID
						
			FROM            People INNER JOIN
                         Applications ON People.PersonID = Applications.ApplicantPersonID INNER JOIN
                         TestAppointments INNER JOIN
                         Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID INNER JOIN
                         LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID ON 
                         Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
						 where ApplicantPersonID=@PersonID and TestTypeID=@TestTypeID   and LocalDrivingLicenseApplications.LicenseClassID=@LicenseClassID
			
						 ORDER BY Tests.TestAppointmentID DESC";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LicenseClassID", LicenseClassID);
			command.Parameters.AddWithValue($"@TestTypeID", TestTypeID);
			command.Parameters.AddWithValue($"@PersonID", PersonID);



			try
			{
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{

					// The record was found
					IsFound = true;
					TestID = (int)reader["TestID"];
					TestAppointmentID = (int)reader["TestAppointmentID"];
					TestResult = (bool)reader["TestResult"];
					if (reader["Notes"] == DBNull.Value)

						Notes = "";
					else
						Notes = (string)reader["Notes"];

					CreatedByUserID = (int)reader["CreatedByUserID"];

				}
				else
				{
					// The record was not found
					IsFound = false;
				}

				reader.Close();


			}
			catch (Exception ex)
			{
				//Console.WriteLine("Error: " + ex.Message);
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
