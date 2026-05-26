using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MY_DVLD_DataAccess
{
	public class clsPersonsData
	{

		public static DataTable GetAllPersons()
		{

			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"SELECT        P.PersonID, P.NationalNo, P.FirstName, P.SecondName, P.ThirdName, P.LastName,P.DateOfBirth, 

							Case P.Gender
							when 0 then 'Male'
							else 'Female'
							end as Gender
							
							, P.Address, P.Phone, P.Email, 
							                         P.NationalityCountryID, C.CountryName, P.ImagePath
							FROM            People P INNER JOIN

							Countries C ON P.NationalityCountryID = C.CountryID";


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


		public static bool IsNationalNumberExisted(string NationailNo)
		{


			bool Existed = false;
			DataTable dt = new DataTable();
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select NationalNo From People Where NationalNo=@NationalNo ";


			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@NationalNo", NationailNo);
			try
			{
				connection.Open();

				object result = command.ExecuteScalar();
				Existed = !(result == null || result == DBNull.Value);


			}

			catch (Exception ex)
			{
				// Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}

			return Existed;
		}

		/*
		PersonID	NationalNo	FirstName	SecondName	ThirdName	LastName	
		DateOfBirth	Gender	Address	Phone	Email	NationalityCountryID	ImagePath

		int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
			DateTime DateOfBirth, short Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath

			PersonID,ref  NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
				 ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email , ref NationalityCountryID, ref ImagePath
		 */


		public static bool FindByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref
		DateTime DateOfBirth, ref short Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select * from People where PersonID=@PersonID";


			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@PersonID", PersonID);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();


				if (reader.Read())
				{
					//PersonID = reader["PersonID"] != DBNull.Value ? Convert.ToInt32(reader["PersonID"]) : 0;
					NationalNo = reader["NationalNo"] != DBNull.Value ? reader["NationalNo"].ToString() : string.Empty;
					FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : string.Empty;
					SecondName = reader["SecondName"] != DBNull.Value ? reader["SecondName"].ToString() : string.Empty;
					ThirdName = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"].ToString() : string.Empty;
					LastName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : string.Empty;
					DateOfBirth = reader["DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(reader["DateOfBirth"]) : DateTime.MinValue;
					Gender = reader["Gender"] != DBNull.Value ? Convert.ToInt16(reader["Gender"]) : (short)-1;
					NationalityCountryID = reader["NationalityCountryID"] != DBNull.Value ? Convert.ToInt32(reader["NationalityCountryID"]) : -1;
					Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty;
					Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : string.Empty;
					Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
					ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : string.Empty;


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


		public static bool FindByNationalNo(ref int PersonID,  string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref
		DateTime DateOfBirth, ref short Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
		{
			bool IsFound = false;
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


			string query = @"Select * from People where NationalNo=@NationalNo";


			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@NationalNo", NationalNo);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();


				if (reader.Read())
				{
					PersonID = reader["PersonID"] != DBNull.Value ? Convert.ToInt32(reader["PersonID"]) : 0;
					//NationalNo = reader["NationalNo"] != DBNull.Value ? reader["NationalNo"].ToString() : string.Empty;
					FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : string.Empty;
					SecondName = reader["SecondName"] != DBNull.Value ? reader["SecondName"].ToString() : string.Empty;
					ThirdName = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"].ToString() : string.Empty;
					LastName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : string.Empty;
					DateOfBirth = reader["DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(reader["DateOfBirth"]) : DateTime.MinValue;
					Gender = reader["Gender"] != DBNull.Value ? Convert.ToInt16(reader["Gender"]) : (short)-1;
					NationalityCountryID = reader["NationalityCountryID"] != DBNull.Value ? Convert.ToInt32(reader["NationalityCountryID"]) : -1;
					Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : string.Empty;
					Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : string.Empty;
					Email = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : string.Empty;
					ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : string.Empty;


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

		public static int AddNewPerson( string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
			DateTime DateOfBirth, short Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{

				string query = @"
INSERT INTO People
    (NationalNo, FirstName, SecondName, ThirdName, LastName,
     DateOfBirth, Gender, Address, Phone, Email,
     NationalityCountryID, ImagePath)
VALUES
    (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName,
     @DateOfBirth, @Gender, @Address, @Phone, @Email,
     @NationalityCountryID, @ImagePath);
	 SELECT SCOPE_IDENTITY();
	 ";
				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely

				command.Parameters.AddWithValue("@NationalNo", NationalNo);
				command.Parameters.AddWithValue("@FirstName", FirstName);
				command.Parameters.AddWithValue("@SecondName", SecondName);
				command.Parameters.AddWithValue("@ThirdName", ThirdName);
				command.Parameters.AddWithValue("@LastName", LastName);
				command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
				command.Parameters.AddWithValue("@Gender", Gender);
				command.Parameters.AddWithValue("@Address", Address);
				command.Parameters.AddWithValue("@Phone", Phone);
				command.Parameters.AddWithValue("@Email", Email);
				command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
				command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath);

				connection.Open();
				int Person_ID = Convert.ToInt32(command.ExecuteScalar());
				return Person_ID;
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error Adding New Person: " + ex.Message);
				return -1;
			}
			finally
			{
				connection.Close();
			}
		}

		public static bool UpdatePerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
			DateTime DateOfBirth, short Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{


				string query = @"UPDATE People 
                         SET NationalNo = @NationalNo, 
                             FirstName = @FirstName, 
                             SecondName = @SecondName, 
                             ThirdName = @ThirdName, 
                             LastName = @LastName, 
                             DateOfBirth = @DateOfBirth, 
                             Gender = @Gender, 
                             Address = @Address, 
                             Phone = @Phone, 
                             Email = @Email, 
                             NationalityCountryID = @NationalityCountryID, 
                             ImagePath = @ImagePath 
                         WHERE PersonID = @PersonID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@PersonID", PersonID);
				command.Parameters.AddWithValue("@NationalNo", NationalNo);
				command.Parameters.AddWithValue("@FirstName", FirstName);
				command.Parameters.AddWithValue("@SecondName", SecondName);
				command.Parameters.AddWithValue("@ThirdName", ThirdName);
				command.Parameters.AddWithValue("@LastName", LastName);
				command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
				command.Parameters.AddWithValue("@Gender", Gender);
				command.Parameters.AddWithValue("@Address", Address);
				command.Parameters.AddWithValue("@Phone", Phone);
				command.Parameters.AddWithValue("@Email", Email);
				command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
				command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(ImagePath) ? (object)DBNull.Value : ImagePath);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();

				return (rowsAffected > 0);
			}
			catch (Exception ex)
			{
				// log the error or show message
				Console.WriteLine("Error updating person: " + ex.Message);
				return false;
			}
			finally
			{
				connection.Close();
			}
		}

		public static bool DeletePerson(int PersonID)
		{
			SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
			try
			{


				string query = @"Delete From People 
                         WHERE PersonID = @PersonID";

				SqlCommand command = new SqlCommand(query, connection);

				// add parameters safely
				command.Parameters.AddWithValue("@PersonID", PersonID);

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



	}
}
