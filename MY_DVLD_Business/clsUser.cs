using MY_DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_DVLD_Business
{
	public class clsUser
	{
		#region Vars

		public enum enMode { AddNew, Update };
		public enMode Mode { set; get; }

		public int UserID { set; get; }
		public string Username { set; get; }
		public string Password { set; get; }
		public bool IsActive { set; get; }
		public int PersonID { set; get; }
		public clsPerson Person { set; get; }

		#endregion
		//UserID ,PersonID ,Username ,Password ,IsActive
		//ref UserID ,ref PersonID ,ref Username ,ref Password ,ref IsActive
		//int UserID ,int PersonID ,string Username,string Password,bool IsActive
		//ref int UserID ,ref int PersonID ,ref string Username,ref string Password,ref bool IsActive
		public clsUser()
		{
			this.Mode = enMode.AddNew;
			this.UserID = -1;
			this.Username = "";
			this.Password = "";
			this.IsActive = false;
			this.Person = new clsPerson();
		}

		private clsUser(int UserID, int PersonID, string Username, string Password, bool IsActive)
		{
			this.Mode = enMode.Update;

			this.UserID = UserID;
			this.PersonID = PersonID;
			this.Username = Username;
			this.Password = Password;
			this.IsActive = IsActive;

			this.Person = clsPerson.FindByID(PersonID);
		}

		public static DataTable GetAllUsers()
		{
			return clsUserData.GetAllUsers();
		}


		public static clsUser FindUserByUserID(int UserID)
		{
			int PersonID = -1; string Username = "", Password = ""; bool IsActive = false;

			bool IsExisted = clsUserData.FindUserByUserID(UserID, ref PersonID, ref Username, ref Password, ref IsActive);

			if (IsExisted)
			{
				return new clsUser(UserID, PersonID, Username, Password, IsActive);
			}
			else
				return null;
		}

		public static clsUser FindUserByPersonID(int PersonID)
		{
			string Username = "", Password = ""; bool IsActive = false; int UserID = -1;

			bool IsExisted = clsUserData.FindUserByPersonID(ref UserID, PersonID, ref Username, ref Password, ref IsActive);

			if (IsExisted)
			{
				return new clsUser(UserID, PersonID, Username, Password, IsActive);
			}
			else
				return null;
		}

		public static clsUser FindUserByUsername(string Username)
		{
			int PersonID = -1, UserID = -1; string Password = ""; bool IsActive = false;

			bool IsExisted = clsUserData.FindUserByUsername(ref UserID, ref PersonID, Username, ref Password, ref IsActive);

			if (IsExisted)
			{
				return new clsUser(UserID, PersonID, Username, Password, IsActive);
			}
			else
				return null;
		}

		public static clsUser FindUserByUsernameAndPassword(string Username, string Password)
		{
			int PersonID = -1, UserID = -1; bool IsActive = false;

			bool IsExisted = clsUserData.FindUserByUsernameAndPassword(ref UserID, ref PersonID, Username, Password, ref IsActive);

			if (IsExisted)
			{
				return new clsUser(UserID, PersonID, Username, Password, IsActive);
			}
			else
				return null;
		}

		public static bool IsUserExistByPersonID(int PersonID)
		{
			return clsUserData.IsUserExistByPersonID(PersonID);
		}

		public static bool IsUserExistByUsername(string UserName)
		{
			return clsUserData.IsUserExistByUsername(UserName);
		}

		//public static clsUser AddNewUser(string UserName, string Password, bool IsActive)
		//{
		//	int UserID = -1; int PersonID = -1;

		//	bool IsAdded = clsUserData.AddNewUser(ref UserID, PersonID, UserName, Password, IsActive);
		//	if (IsAdded)
		//	{

		//	}
		//}

		//public static clsUser UpdateUser(string UserName, string Password, bool IsActive)
		//{
		//	int UserID = -1; int PersonID = -1;

		//	bool IsAdded = clsUserData.AddNewUser(ref UserID, PersonID, UserName, Password, IsActive);
		//	if (IsAdded)
		//	{

		//	}
		//}

		public static bool DeleteUser(int UserID)
		{
			return clsUserData.DeleteUser(UserID);
		}


		private bool _AddNewUser()
		{
			int UserID = -1;

			bool IsAdded = clsUserData.AddNewUser(ref UserID, this.PersonID, this.Username, this.Password, this.IsActive);

			if (IsAdded)
			{
				this.UserID = UserID;
				return true;
			}

			else
			{
				this.UserID = -1;
				return false;
			}
		}


		private bool _UpdateUser()
		{
			bool IsUpdated = false;
			IsUpdated = clsUserData.UpdateUser(this.UserID, this.PersonID, this.Username, this.Password, this.IsActive);
			return IsUpdated;
		}


		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewUser())
					{
						this.Mode = enMode.Update;
						return true;
					}
					break;


				case enMode.Update:
					if (_UpdateUser())
						return true;
					break;
			}
			return false;

		}




	}
}
