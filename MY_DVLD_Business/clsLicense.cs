using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_DVLD_Business.Enum;
using MY_DVLD_DataAccess;
namespace MY_DVLD_Business
{
	public class clsLicense
	{

		/*
		 * 
		 * 	int LicenseID
			  ,ApplicationID
			  ,DriverID
			  ,LicenseClass
			  ,IssueDate
			  ,ExpirationDate
			  ,Notes
			  ,PaidFees
			  ,IsActive
			  ,IssueReason
			  ,CreatedByUserID
		*/

		#region Vars

		public int LicenseID { get; set; }
		public int ApplicationID { get; set; }
		public int DriverID { get; set; }
		public int LicenseClassID { get; set; }
		public DateTime IssueDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public string Notes { get; set; }
		public float PaidFees { get; set; }
		public bool IsActive { get; set; }
		public int CreatedByUserID { get; set; }



		public bool IsDetained { get { return clsDetainedLicenseData.IsLicenseDetainedByLicenseID(this.LicenseID); } }
		//public DriverInfo;

		//1-FirstTime, 2-Renew, 3-Replacement for Damaged, 4- Replacement for Lost.
		public enum enMode { AddNew, Update };
		public enum enIssueReason { FirstTime = 1, Renew = 2, ReplacementForDamaged = 3, ReplacementForLost = 4 }
		public string IssueReasonText
		{
			get
			{
				switch (IssueReason)
				{
					case enIssueReason.FirstTime:
						return "FirstTime";

					case enIssueReason.Renew:
						return "Renew";

					case enIssueReason.ReplacementForDamaged:
						return "ReplacementForDamaged";

					case enIssueReason.ReplacementForLost:
						return "ReplacementForLost";

					default:
						return "FirstTime";

				}


			}
		}

		public enIssueReason IssueReason;
		public enMode Mode;
		public clsUser UserInfo { get; set; }
		public clsApplication ApplicationInfo { get; set; }
		public clsLicenseClass LicenseClassInfo { get; set; }
		public clsDriver DriverInfo { get; set; }

		#endregion

		public clsLicense()
		{
			this.LicenseID = 0;
			this.ApplicationID = 0;
			this.DriverID = 0;
			this.LicenseClassID = 0;
			this.IssueDate = DateTime.Now;
			this.ExpirationDate = DateTime.Now;
			this.Notes = "";
			this.PaidFees = 0f;
			this.IsActive = false;
			this.CreatedByUserID = 0;
			this.IssueReason = enIssueReason.FirstTime;

		}

		clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive, int CreatedByUserID, enIssueReason IssueReason)
		{
			this.LicenseID = LicenseID;
			this.ApplicationID = ApplicationID;
			this.DriverID = DriverID;
			this.LicenseClassID = LicenseClassID;
			this.IssueDate = IssueDate;
			this.ExpirationDate = ExpirationDate;
			this.Notes = Notes;
			this.PaidFees = PaidFees;
			this.IsActive = IsActive;
			this.CreatedByUserID = CreatedByUserID;
			this.IssueReason = IssueReason;

			this.Mode = enMode.Update;
			ApplicationInfo = clsApplication.FindApplicationByID(this.ApplicationID);
			UserInfo = clsUser.FindUserByUserID(this.CreatedByUserID);
			LicenseClassInfo = clsLicenseClass.FindLicenseClassByID(this.LicenseClassID);
			DriverInfo = clsDriver.FindDriverByID(this.DriverID);
		}

		public static DataTable GetAllLicenses()
		{
			return clsLicenseData.GetAllLicenses();
		}


		public static DataTable GetAllLicensesByPersonID(int PersonID)
		{
			return clsLicenseData.GetAllLicensesByPersonID(PersonID);

		}

		bool _AddNewLicense()
		{
			this.LicenseID = clsLicenseData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.CreatedByUserID, (byte)this.IssueReason);
			return (this.LicenseID != -1);
		}

		bool _UpdateLicense()
		{

			bool IsUpdated = clsLicenseData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.CreatedByUserID, (byte)this.IssueReason);
			return IsUpdated;
		}

		public bool Save()
		{
			switch (this.Mode)
			{
				case enMode.AddNew:
					if (_AddNewLicense())
					{
						this.Mode = enMode.Update;
						return true;
					}
					break;

				case enMode.Update:
					if (_UpdateLicense())
						return true;
					break;
			}
			return false;
		}

		public static bool DeleteLicense(int LicenseID)
		{
			return clsLicenseData.DeleteLicense(LicenseID);
		}

		public static clsLicense FindLicenseByID(int LicenseID)
		{
			int ApplicationID = 0;
			int DriverID = 0;
			int LicenseClassID = 0;
			DateTime IssueDate = DateTime.MinValue;
			DateTime ExpirationDate = DateTime.MinValue;
			string Notes = "";
			float PaidFees = 0f;
			int CreatedByUserID = 0;
			bool IsActive = false;
			byte IssueReason = 1;


			bool IsFound = clsLicenseData.FindLicenseByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref CreatedByUserID, ref IssueReason);

			if (IsFound)
			{
				clsLicense License = new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, CreatedByUserID, (enIssueReason)IssueReason);
				return License;
			}
			else
				return null;
		}

		public static bool IsLicenseExistedForPersonID(int PersonID, int LicenseClassID)
		{
			return clsLicenseData.IsActiveLicenseForPersonIDAndLicenseClassExisted(PersonID, LicenseClassID);
		}


		public bool DeactivateLicense()
		{
			return clsLicenseData.DeactiveLicnese(this.LicenseID);
		}


		public clsLicense RenewLicense(string Notes, int CreatedByUserID)
		{

			//First Create Applicaiton 
			clsApplication Application = new clsApplication();

			Application.ApplicantPersonID = this.DriverInfo.PersonID;
			Application.ApplicationDate = DateTime.Now;
			Application.ApplicationTypeID = enApplicationType.RenewDrivingLicense;
			Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
			Application.LastStatusDate = DateTime.Now;
			Application.PaidFees = clsApplicationType.FindApplicationTypeByID(enApplicationType.RenewDrivingLicense).ApplicationFees;
			Application.CreatedByUserID = CreatedByUserID;

			if (!Application.Save())
			{
				return null;
			}

			clsLicense NewLicense = new clsLicense();

			NewLicense.ApplicationID = Application.ApplicationID;
			NewLicense.DriverID = this.DriverID;
			NewLicense.LicenseClassID = this.LicenseClassID;
			NewLicense.IssueDate = DateTime.Now;

			int DefaultValidityLength = this.LicenseClassInfo.DefaultValidityLength;

			NewLicense.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
			NewLicense.Notes = Notes;
			NewLicense.PaidFees = this.LicenseClassInfo.ClassFees;
			NewLicense.IsActive = true;
			NewLicense.IssueReason = clsLicense.enIssueReason.Renew;
			NewLicense.CreatedByUserID = CreatedByUserID;


			if (!NewLicense.Save())
			{
				return null;
			}

			//we need to deactivate the old License.
			this.DeactivateLicense();

			return NewLicense;
		}

		public clsLicense ReplaceLicense(int CreatedByUserID, enApplicationType ApplicationType)
		{

			//First Create Applicaiton 
			clsApplication Application = new clsApplication();
			Application.ApplicantPersonID = this.DriverInfo.PersonID;
			Application.ApplicationDate = DateTime.Now;
			Application.ApplicationTypeID = ApplicationType;
			Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
			Application.LastStatusDate = DateTime.Now;
			Application.PaidFees = clsApplicationType.FindApplicationTypeByID(ApplicationType).ApplicationFees;
			Application.CreatedByUserID = CreatedByUserID;

			if (!Application.Save())
			{
				return null;
			}

			clsLicense NewLicense = new clsLicense();

			NewLicense.ApplicationID = Application.ApplicationID;
			NewLicense.DriverID = this.DriverID;
			NewLicense.LicenseClassID = this.LicenseClassID;
			NewLicense.IssueDate = DateTime.Now;

			NewLicense.ExpirationDate = this.ExpirationDate;
			NewLicense.Notes = this.Notes;
			NewLicense.PaidFees = 0;//No fees because it a replacment
			NewLicense.IsActive = true;

			if (ApplicationType == enApplicationType.ReplaceDamagedDrivingLicense)

				NewLicense.IssueReason = clsLicense.enIssueReason.ReplacementForDamaged;

			else
				NewLicense.IssueReason = clsLicense.enIssueReason.ReplacementForLost;

			NewLicense.CreatedByUserID = CreatedByUserID;


			if (!NewLicense.Save())
			{
				return null;
			}

			//we need to deactivate the old License.
			this.DeactivateLicense();

			return NewLicense;
		}

	}
}
