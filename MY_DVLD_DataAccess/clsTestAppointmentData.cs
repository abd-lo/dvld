using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_DVLD_DataAccess
{
	public class clsTestAppointmentData
	{

		public static DataTable GetAllTestAppointments()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM TestAppointments";

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

		public static int AddNewTestAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"
INSERT INTO TestAppointments
(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
VALUES
(@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID)

SELECT SCOPE_IDENTITY();";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
				command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
				command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
				command.Parameters.AddWithValue("@PaidFees", PaidFees);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				command.Parameters.AddWithValue("@IsLocked", IsLocked);

				if (RetakeTestApplicationID == -1)
					command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

				else
					command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);


				connection.Open();
				int ID = Convert.ToInt32(command.ExecuteScalar());
				return ID;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error Adding New TestAppointment: " + ex.Message);
				return -1;
			}
			finally
			{
				connection.Close();
			}
		}

		public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"UPDATE TestAppointments
SET
TestTypeID = @TestTypeID,
LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
AppointmentDate = @AppointmentDate,
PaidFees = @PaidFees,
CreatedByUserID = @CreatedByUserID,
IsLocked = @IsLocked,
RetakeTestApplicationID = @RetakeTestApplicationID
WHERE TestAppointmentID = @TestAppointmentID;";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
				command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
				command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
				command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
				command.Parameters.AddWithValue("@PaidFees", PaidFees);
				command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
				command.Parameters.AddWithValue("@IsLocked", IsLocked);
				

				if (RetakeTestApplicationID == -1)
					command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

				else
					command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating TestAppointment: " + ex.Message);
				return false;
			}
			finally
			{

				connection.Close();
			}

		}

		public static bool DeleteTestAppointment(int TestAppointmentID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"DELETE FROM TestAppointments
WHERE TestAppointmentID = @TestAppointmentID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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

		public static bool FindTestAppointmentByID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref float PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@TestAppointmentID", TestAppointmentID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					TestTypeID = reader["TestTypeID"] != DBNull.Value ? Convert.ToInt32(reader["TestTypeID"]) : -1;
					LocalDrivingLicenseApplicationID = reader["LocalDrivingLicenseApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]) : -1;
					AppointmentDate = reader["AppointmentDate"] != DBNull.Value ? Convert.ToDateTime(reader["AppointmentDate"]) : DateTime.MinValue;
					PaidFees = reader["PaidFees"] != DBNull.Value ? Convert.ToSingle(reader["PaidFees"]) : -1f;
					CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : -1;
					IsLocked = reader["IsLocked"] != DBNull.Value ? Convert.ToBoolean(reader["IsLocked"]) : false;
					RetakeTestApplicationID = reader["RetakeTestApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["RetakeTestApplicationID"]) : -1;
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

		public static DataTable GetAllTestAppointmentsForLDLAppIDAndTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
		{

			DataTable dt = new DataTable();

			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			string query = @"select * from TestAppointments
								where TestTypeID=@TestTypeID And LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@TestTypeID", TestTypeID);
			command.Parameters.AddWithValue($"@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

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
		/*
				public static bool GetTestAppointmentByLDLAppIDAndTestType(int LocalDrivingLicenseApplicationID, int TestTypeID,ref ref bool IsLocked)
				{
					bool IsFound = false;
					SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

					string query = @"select * from TestAppointments
										where TestTypeID=@TestTypeID And LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue($"@TestTypeID", TestTypeID);
					command.Parameters.AddWithValue($"@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

					try
					{
						connection.Open();

						SqlDataReader reader = command.ExecuteReader();

						if (reader.Read())
						{
							TestTypeID = reader["TestTypeID"] != DBNull.Value ? Convert.ToInt32(reader["TestTypeID"]) : -1;
							LocalDrivingLicenseApplicationID = reader["LocalDrivingLicenseApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]) : -1;
							AppointmentDate = reader["AppointmentDate"] != DBNull.Value ? Convert.ToDateTime(reader["AppointmentDate"]) : DateTime.MinValue;
							PaidFees = reader["PaidFees"] != DBNull.Value ? Convert.ToSingle(reader["PaidFees"]) : -1f;
							CreatedByUserID = reader["CreatedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["CreatedByUserID"]) : -1;
							IsLocked = reader["IsLocked"] != DBNull.Value ? Convert.ToBoolean(reader["IsLocked"]) : false;
							RetakeTestApplicationID = reader["RetakeTestApplicationID"] != DBNull.Value ? Convert.ToInt32(reader["RetakeTestApplicationID"]) : -1;
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
				*/


		public static bool IsActiveTestAppointmentForTestTypeExisted(int LocalDrivingLicenseApplicationID, int TestTypeID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"select 1 from TestAppointments
							where TestTypeID=@TestTypeID and LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and IsLocked=0";
								
			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
			command.Parameters.AddWithValue($"@TestTypeID", TestTypeID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					IsFound = true;
				}

				reader.Close();
			}

			catch (Exception ex)
			{
				IsFound = false;
			}

			finally
			{
				connection.Close();
			}


			return IsFound;
		}

		public static bool IsLockedTestAppointmentForTestTypeExisted(int LocalDrivingLicenseApplicationID, int TestTypeID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"select 1 from TestAppointments
							where TestTypeID=@TestTypeID and LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and IsLocked=1";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
			command.Parameters.AddWithValue($"@TestTypeID", TestTypeID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					IsFound = true;
				}

				reader.Close();
			}

			catch (Exception ex)
			{
				IsFound = false;
			}

			finally
			{
				connection.Close();
			}


			return IsFound;
		}

		public static int GetNumberOfTriesPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
		{
			int Tries_No = 0;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"
			
			select Count(*) as Tries_No  from TestAppointments
				where TestTypeID=@TestTypeID and LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and IsLocked=1";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
			command.Parameters.AddWithValue($"@TestTypeID", TestTypeID);

			try
			{
				connection.Open();

				object result = command.ExecuteScalar();

				if (result != null && int.TryParse(result.ToString(), out int Output))
				{
					Tries_No = Output;
				}


			}

			catch (Exception ex)
			{
				Tries_No = -1;
			}

			finally
			{
				connection.Close();
			}


			return Tries_No;
		}



		/*

		public static int GetActiveTestAppointmentIDForTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"select * from TestAppointments
							where 
							TestTypeID=@TestTypeID 
							and LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID 
							and IsLocked=0";


			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
			command.Parameters.AddWithValue($"@TestTypeID", TestTypeID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					IsFound = true;
				}

				reader.Close();
			}

			catch (Exception ex)
			{
				IsFound = false;
			}

			finally
			{
				connection.Close();
			}


			return IsFound;
		}
		*/


	}
}
