using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_DVLD_DataAccess
{
	public class clsTestTypesData
	{

		public static DataTable GetAllTestTypes()
		{

			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"SELECT * from TestTypes";


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

		public static bool FindTestTypeByTestID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref float TestTypeFees)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			bool IsFound = false;

			string query = @"SELECT * from TestTypes where TestTypeID=@TestTypeID";

			SqlCommand command = new SqlCommand(query, connection);


			try
			{
				connection.Open();

				command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					TestTypeTitle = reader["TestTypeTitle"]?.ToString();
					TestTypeDescription = reader["TestTypeDescription"]?.ToString();
					TestTypeFees = float.Parse(reader["TestTypeFees"]?.ToString());

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

		public static bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			bool IsFound = false;

			string query = @"UPDATE TestTypes SET
    TestTypeTitle = @TestTypeTitle,
    TestTypeDescription = @TestTypeDescription,
    TestTypeFees = @TestTypeFees
WHERE
    TestTypeID = @TestTypeID;";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
			command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
			command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
			command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

			try
			{
				connection.Open();

				int RowsAffected = command.ExecuteNonQuery();

				if (RowsAffected > 0)
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

		public static bool AddNewTestType(ref int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			bool IsFound = false;

			string query = @"INSERT INTO TestTypes 
			(TestTypeTitle, TestTypeDescription, TestTypeFees)
	 VALUES (@TestTypeTitle, @TestTypeDescription, @TestTypeFees);
	 
				 SELECT SCOPE_IDENTITY();";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
			command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
			command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

			try
			{
				connection.Open();

				TestTypeID = Convert.ToInt32(command.ExecuteScalar());

				if (TestTypeID != -1)
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