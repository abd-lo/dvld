using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_DVLD_DataAccess
{
	public class clsLicenseClassData
	{

		public static DataTable GetAllLicenseClasses()
		{
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM LicenseClasses";

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

		public static int AddNewLicenseClass(string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"
				INSERT INTO LicenseClasses
				(ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees)
				VALUES
				(@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees)

				SELECT SCOPE_IDENTITY();";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@ClassName", ClassName);
				command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
				command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
				command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
				command.Parameters.AddWithValue("@ClassFees", ClassFees);
				connection.Open();
				int ID = Convert.ToInt32(command.ExecuteScalar());
				return ID;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error Adding New LicenseClass: " + ex.Message);
				return -1;
			}
			finally
			{
				connection.Close();
			}
		}

		public static bool UpdateLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"UPDATE LicenseClasses
SET
ClassName = @ClassName,
ClassDescription = @ClassDescription,
MinimumAllowedAge = @MinimumAllowedAge,
DefaultValidityLength = @DefaultValidityLength,
ClassFees = @ClassFees
WHERE LicenseClassID = @LicenseClassID;";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely";
				command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
				command.Parameters.AddWithValue("@ClassName", ClassName);
				command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
				command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
				command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
				command.Parameters.AddWithValue("@ClassFees", ClassFees);
				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating LicenseClass: " + ex.Message);
				return false;
			}
			finally
			{

				connection.Close();
			}

		}

		public static bool DeleteLicenseClass(int LicenseClassID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"DELETE FROM LicenseClasses
WHERE LicenseClassID = @LicenseClassID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

		public static bool FindLicenseClassByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref float ClassFees)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			string query = @"SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue($"@LicenseClassID", LicenseClassID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					ClassName = reader["ClassName"] != DBNull.Value ? reader["ClassName"].ToString() : string.Empty;
					ClassDescription = reader["ClassDescription"] != DBNull.Value ? reader["ClassDescription"].ToString() : string.Empty;
					MinimumAllowedAge = reader["MinimumAllowedAge"] != DBNull.Value ? Convert.ToByte(reader["MinimumAllowedAge"]) : (byte)0;
					DefaultValidityLength = reader["DefaultValidityLength"] != DBNull.Value ? Convert.ToByte(reader["DefaultValidityLength"]) : (byte)0;
					ClassFees = reader["ClassFees"] != DBNull.Value ? Convert.ToSingle(reader["ClassFees"]) : -1f;
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
