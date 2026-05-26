using MY_DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_DVLD_Business
{
	public class clsPerson
	{
		#region Vars
		public enum enMode { AddNew = 0, Update = 1 };
		public enMode Mode = enMode.AddNew;

		public int PersonID { set; get; }
		public string NationalNo { set; get; }
		public string FirstName { set; get; }
		public string SecondName { set; get; }
		public string ThirdName { set; get; }
		public string LastName { set; get; }
		public DateTime DateOfBirth { set; get; }
		public short Gender { set; get; }
		public string Address { set; get; }
		public string Phone { set; get; }
		public string Email { set; get; }
		public int NationalityCountryID { set; get; }
		public string ImagePath { set; get; }


		public string GenderText
		{
			get
			{
				return (Gender == 0) ? "Male": "Female";
			}
		}

		public string FullName
		{
			get
			{
				return $"{FirstName} {SecondName} {ThirdName} {LastName}";
			}
		}
		public clsCountry Country { set; get; }


		#endregion

		private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
			DateTime DateOfBirth, short Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
		{
			this.PersonID = PersonID;
			this.NationalNo = NationalNo;
			this.FirstName = FirstName;
			this.SecondName = SecondName;
			this.ThirdName = ThirdName;
			this.LastName = LastName;
			this.DateOfBirth = DateOfBirth;
			this.Gender = Gender;
			this.Address = Address;
			this.Phone = Phone;
			this.Email = Email;
			this.NationalityCountryID = NationalityCountryID;

			this.Country = clsCountry.Find(NationalityCountryID);
			this.ImagePath = ImagePath;

			Mode = enMode.Update;
		}

		public clsPerson()
		{
			this.PersonID = -1;
			this.FirstName = "";
			this.SecondName = "";
			this.ThirdName = "";
			this.LastName = "";
			this.Email = "";
			this.Phone = "";
			this.Address = "";
			this.DateOfBirth = DateTime.Now;
			this.Gender = -1;
			this.ImagePath = "";
			this.NationalityCountryID = -1;


			Mode = enMode.AddNew;
		}

		/*
		PersonID	NationalNo	FirstName	SecondName	ThirdName	LastName	
		DateOfBirth	Gender	Address	Phone	Email	NationalityCountryID	ImagePath

		int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
			DateTime DateOfBirth, short Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath

			ref PersonID,ref  NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
				 ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email , ref NationalityCountryID, ref ImagePath
		 */
		public static DataTable GetAllPersons()
		{

			DataTable dt = clsPersonsData.GetAllPersons();
			return dt;
		}

		public static bool IsNationalNumberExisted(string NationalNo)
		{
			bool Existed = clsPersonsData.IsNationalNumberExisted(NationalNo);
			return Existed;
		}

		public static clsPerson FindByID(int PersonID)
		{

			string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
			DateTime DateOfBirth = DateTime.Now;
			int NationalityCountryID = -1;
			short Gender = 0;


			bool IsFound = clsPersonsData.FindByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
				 ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

			if (IsFound)
			{
				clsPerson Person = new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
				return Person;
			}

			return null;



		}


		public static clsPerson FindByNationalNo(string NationalNo)
		{

			int PersonID = -1; string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
			DateTime DateOfBirth = DateTime.Now;
			int NationalityCountryID = -1;
			short Gender = 0;


			bool IsFound = clsPersonsData.FindByNationalNo(ref PersonID, NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
				 ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

			if (IsFound)
			{
				clsPerson Person = new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
				return Person;
			}

			return null;



		}


		public static bool Delete(int PersonID)
		{
			return (clsPersonsData.DeletePerson(PersonID));

		}

		bool _Update()
		{
			bool IsUpdated = clsPersonsData.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
				this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

			return IsUpdated;
		}

		bool _AddNew()
		{
			this.PersonID = clsPersonsData.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
		this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

			return (PersonID != -1);
		}

		public bool Save()
		{
			switch (this.Mode)
			{
				case enMode.AddNew:

					if (_AddNew())
					{

						this.Mode = enMode.Update;
						return true;
					}
					break;




				case enMode.Update:

					if (_Update())
						return true;
					break;

			}
			return false;
		}





	}

}




