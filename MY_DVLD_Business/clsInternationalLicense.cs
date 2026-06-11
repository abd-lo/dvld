using MY_DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MY_DVLD_Business
{
	public class clsInternationalLicense
	{
		#region Vars

		public int InternationalLicenseID { get; set; }
		public int ApplicationID { get; set; }
		public int DriverID { get; set; }
		public int IssuedUsingLocalLicenseID { get; set; }
		public DateTime IssueDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public bool IsActive { get; set; }
		public int CreatedByUserID { get; set; }

		public clsLicense IssuedUsingLocalLicenseInfo;
		public clsUser CreatedByUserInfo;
		public clsDriver DriverInfo;

		public enum enMode { AddNew, Update };
		public enMode Mode;
		#endregion

		public clsInternationalLicense()
		{
			this.InternationalLicenseID = 0;
			this.ApplicationID = 0;
			this.DriverID = 0;
			this.IssuedUsingLocalLicenseID = 0;
			this.IssueDate = DateTime.Now;
			this.ExpirationDate = DateTime.Now;
			this.IsActive = false;
			this.CreatedByUserID = 0;

			Mode = enMode.AddNew;

		}

		clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
		{
			this.InternationalLicenseID = InternationalLicenseID;
			this.ApplicationID = ApplicationID;
			this.DriverID = DriverID;
			this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
			this.IssueDate = IssueDate;
			this.ExpirationDate = ExpirationDate;
			this.IsActive = IsActive;
			this.CreatedByUserID = CreatedByUserID;

			Mode = enMode.Update;
			CreatedByUserInfo = clsUser.FindUserByUserID(CreatedByUserID);
			DriverInfo = clsDriver.FindDriverByID(DriverID);
			IssuedUsingLocalLicenseInfo = clsLicense.FindLicenseByID(IssuedUsingLocalLicenseID);
		}


		public static DataTable GetAllInternationalLicensesBasicInfo()
		{
			return clsInternationalLicenseData.GetAllInternationalLicensesBasicInfo();
		}

		public static DataTable GetAllInternationalLicenseByPersonID(int PersonID)
		{
			return clsInternationalLicenseData.GetAllInternationalLicensesForPersonID(PersonID);
		}

		bool _AddNewInternationalLicense()
		{
			this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
			return (this.InternationalLicenseID != -1);
		}

		bool _UpdateInternationalLicense()
		{
			bool IsUpdated = clsInternationalLicenseData.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
			return IsUpdated;
		}

		public bool Save()
		{
			switch (this.Mode)
			{
				case enMode.AddNew:
					if (_AddNewInternationalLicense())
					{
						this.Mode = enMode.Update;
						return true;
					}
					break;

				case enMode.Update:
					if (_UpdateInternationalLicense())
						return true;
					break;
			}
			return false;
		}

		public static bool DeleteInternationalLicense(int InternationalLicenseID)
		{
			return clsInternationalLicenseData.DeleteInternationalLicense(InternationalLicenseID);
		}

		public static clsInternationalLicense FindInternationalLicenseByID(int InternationalLicenseID)
		{
			int ApplicationID = 0;
			int DriverID = 0;
			bool IsActive = false;
			int IssuedUsingLocalLicenseID = 0;
			DateTime IssueDate = DateTime.MinValue;
			DateTime ExpirationDate = DateTime.MinValue;
			int CreatedByUserID = 0;

			bool IsFound = clsInternationalLicenseData.FindInternationalLicenseByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID);

			if (IsFound)
			{
				clsInternationalLicense InternationalLicense = new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
				return InternationalLicense;
			}

			return null;
		}











	}



}
