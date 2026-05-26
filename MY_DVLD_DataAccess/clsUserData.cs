using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace MY_DVLD_DataAccess
{
	public class clsUserData
	{

		//UserID ,PersonID ,Username ,Password ,IsActive
		//int UserID ,int PersonID ,string Username,string Password,bool IsActive
		//ref int UserID ,ref int PersonID ,ref string Username,ref string Password,ref bool IsActive
		DataTable AllUsers;
		public static DataTable GetAllUsers()
		{
			DataTable dtUsers = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

			//UserId PersonID UserName FUllName IsActive
			string query = @"SELECT
							Users.UserID,
							Users.PersonID,
					    	Users.UserName,

							FullName = CONCAT_WS(' ',
								People.FirstName,
								People.SecondName,
								People.ThirdName,
								People.LastName
							),
		    
							Users.IsActive
						FROM Users
						INNER JOIN People ON Users.PersonID = People.PersonID";

			SqlCommand command = new SqlCommand(query, connection);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					dtUsers.Load(reader);

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

			return dtUsers;
		}

	

		public static bool AddNewUser(ref int UserID, int PersonID, string Username, string Password, bool IsActive)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			bool IsAdded = false;
			try
			{

				string query = @"
				INSERT INTO users
					  ( Username, Password, IsActive,PersonID)
						VALUES
						  (@Username, @Password,@IsActive,@PersonID);
				 SELECT SCOPE_IDENTITY();";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely

				command.Parameters.AddWithValue("@PersonID", PersonID);
				command.Parameters.AddWithValue("@Username", Username);
				command.Parameters.AddWithValue("@Password", Password);
				command.Parameters.AddWithValue("@IsActive", IsActive);

				connection.Open();

				UserID = Convert.ToInt32(command.ExecuteScalar());

				IsAdded = true;
			}
			catch (Exception ex)
			{
				// log the error or show message
				//Console.WriteLine("Error Adding New User: " + ex.Message);


				IsAdded = false;
			}
			finally
			{
				connection.Close();
			}

			return IsAdded;
		}

		public static bool UpdateUser(int UserID, int PersonID, string Username, string Password, bool IsActive)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			bool IsUpdated = false;
			try
			{

				string query = @"UPDATE Users 
                         SET Username = @Username, 
                             PersonID = @PersonID, 
                             Password = @Password, 
                             IsActive = @IsActive

                         WHERE UserID = @UserID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@Username", Username);
				command.Parameters.AddWithValue("@PersonID", PersonID);
				command.Parameters.AddWithValue("@Password", Password);
				command.Parameters.AddWithValue("@IsActive", IsActive);
				command.Parameters.AddWithValue("@UserID", UserID); 


				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				IsUpdated = (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating person: " + ex.Message);
				IsUpdated = false;
			}
			finally
			{
				connection.Close();
			}
			return IsUpdated;
		}

		public static bool DeleteUser(int UserID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{
				string query = @"Delete From Users 
                         WHERE UserID = @UserID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@UserID", UserID);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error Deleting person: " + ex.Message);
				return false;
			}
			finally
			{
				connection.Close();
			}
		}


		public static bool FindUserByUserID(int UserID, ref int PersonID, ref string Username, ref string Password, ref bool IsActive)
		{
			bool IsFound = false;


			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select * From Users Where UserID=@UserID ";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@UserID", UserID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();


				if (reader.Read())
				{

					PersonID = reader["PersonID"] != DBNull.Value ? Convert.ToInt32(reader["PersonID"]) : -1;
					Username = reader["Username"] != DBNull.Value ? reader["Username"].ToString() : string.Empty;
					Password = reader["Password"] != DBNull.Value ? reader["Password"].ToString() : string.Empty;
					IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(reader["IsActive"]) : false;
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

		public static bool FindUserByUsername(ref int UserID, ref int PersonID, string Username, ref string Password, ref bool IsActive)
		{
			bool IsFound = false;


			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select * From Users Where Username=@Username ";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Username", Username);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();


				if (reader.Read())
				{

					UserID = reader["UserID"] != DBNull.Value ? Convert.ToInt32(reader["UserID"]) : -1;
					PersonID = reader["PersonID"] != DBNull.Value ? Convert.ToInt32(reader["PersonID"]) : -1;
					Password = reader["Password"] != DBNull.Value ? reader["Password"].ToString() : string.Empty;
					IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(reader["IsActive"]) : false;

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

		public static bool FindUserByUsernameAndPassword(ref int UserID, ref int PersonID, string Username, string Password, ref bool IsActive)
		{
			bool IsFound = false;


			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select * From Users Where Username=@Username And Password=@Password";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Username", Username);
			command.Parameters.AddWithValue("@Password", Password);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();


				if (reader.Read())
				{

					UserID = reader["UserID"] != DBNull.Value ? Convert.ToInt32(reader["UserID"]) : -1;
					PersonID = reader["PersonID"] != DBNull.Value ? Convert.ToInt32(reader["PersonID"]) : -1;
					Password = reader["Password"] != DBNull.Value ? reader["Password"].ToString() : string.Empty;
					IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(reader["IsActive"]) : false;

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

		public static bool FindUserByPersonID(ref int UserID, int PersonID, ref string Username, ref string Password, ref bool IsActive)
		{
			bool IsFound = false;


			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select * From Users Where PersonID=@PersonID ";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@PersonID", PersonID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();


				if (reader.Read())
				{

					PersonID = reader["UserID"] != DBNull.Value ? Convert.ToInt32(reader["UserID"]) : -1;
					Password = reader["Password"] != DBNull.Value ? reader["Password"].ToString() : string.Empty;
					Username = reader["Username"] != DBNull.Value ? reader["Username"].ToString() : string.Empty;
					IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(reader["IsActive"]) : false;

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

		public static bool IsUserExistByPersonID(int PersonID)
		{
			bool IsFound = false;


			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select * From Users Where PersonID=@PersonID ";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@PersonID", PersonID);

			try
			{
				connection.Open();

				object reader = command.ExecuteScalar();


				if (reader != null)
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

		public static bool IsUserExistByUsername(string Username)
		{
			bool IsFound = false;


			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select * From Users Where Username=@Username ";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Username", Username);

			try
			{
				connection.Open();

				object reader = command.ExecuteScalar();


				if (reader != null)
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

