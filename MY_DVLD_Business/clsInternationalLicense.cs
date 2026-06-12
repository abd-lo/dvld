using MY_DVLD_Business.Enum;
using MY_DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static MY_DVLD_Business.clsApplication;

namespace MY_DVLD_Business
{
	public class clsInternationalLicense : clsApplication
	{
		#region ApplicationVars
		////		Application Vars
		//public int ApplicationID { set; get; }
		//public int ApplicantPersonID { set; get; }
		//public enApplicationType ApplicationTypeID { set; get; }
		//public int CreatedByUserID { set; get; }
		//public DateTime ApplicationDate { set; get; }
		//public DateTime LastStatusDate { set; get; }
		//public float PaidFees { set; get; }
		//public enApplicationStatus ApplicationStatus { set; get; }



		//public string StatusText
		//{
		//	get
		//	{
		//		switch (ApplicationStatus)
		//		{
		//			case enApplicationStatus.New:
		//				return "New";

		//			case enApplicationStatus.Completed:
		//				return "Completed";


		//			case enApplicationStatus.Cancelled:
		//				return "Cancelled";

		//			default:
		//				return "Cancelled";

		//		}

		//	}
		//}

		////	public string ApplicantFullName
		//	{
		//		get
		//		{ return clsPerson.FindByID(ApplicantPersonID).FullName; }
		//	}
		//	public clsUser UserInfo { set; get; }

		//public clsApplicationType ApplicationTypeInfo { set; get; }
		//string LastStatus
		//{
		//	get
		//	{
		//		switch (ApplicationStatus)
		//		{
		//			case enApplicationStatus.New:
		//				return "New";

		//			case enApplicationStatus.Cancelled:
		//				return "Cancelled";


		//			case enApplicationStatus.Completed:
		//				return "Completed";

		//			default:
		//				return "NULL";
		//		}
		//	}

		//}


		//public enum enApplicationType
		//{
		//	NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
		//	ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
		//};

		//public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };


		//public enum enMode { AddNew, Update };
		//public enMode Mode;
		#endregion

		#region Vars

		public int InternationalLicenseID { get; set; }
		//public int ApplicationID { get; set; }
		public int DriverID { get; set; }
		public int IssuedUsingLocalLicenseID { get; set; }
		public DateTime IssueDate { get; set; }
		public DateTime ExpirationDate { get; set; }
		public bool IsActive { get; set; }
		//public int CreatedByUserID { get; set; }

		public clsLicense IssuedUsingLocalLicenseInfo;
		//public clsUser CreatedByUserInfo;
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
		/*
		 * 
		public int ApplicationID { set; get; }
		public int ApplicantPersonID { set; get; }
		public enApplicationType ApplicationTypeID { set; get; }
		public int CreatedByUserID { set; get; }
		public DateTime ApplicationDate { set; get; }
		public DateTime LastStatusDate { set; get; }
		public float PaidFees { set; get; }
		public enApplicationStatus ApplicationStatus { set; get; }

		*/
		clsInternationalLicense(int ApplicationID, int ApplicantPersonID, enApplicationType ApplicationTypeID, DateTime ApplicationDate,
		DateTime LastStatusDate, enApplicationStatus ApplicationStatus, float PaidFees, int CreatedByUserID, int InternationalLicenseID,
		int DriverID, int IssuedUsingLocalLicenseID,
		DateTime IssueDate, DateTime ExpirationDate, bool IsActive)

		: base(ApplicationID, ApplicantPersonID, ApplicationTypeID, ApplicationDate, LastStatusDate, ApplicationStatus, PaidFees, CreatedByUserID)
		{
			this.InternationalLicenseID = InternationalLicenseID;
			this.DriverID = DriverID;
			this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
			this.IssueDate = IssueDate;
			this.ExpirationDate = ExpirationDate;
			this.IsActive = IsActive;
			this.CreatedByUserID = CreatedByUserID;

			Mode = enMode.Update;
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
			//map base mode to this mode 
			base.Mode = (clsApplication.enMode)this.Mode;

			if (!base.Save())
				return false;

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

		public bool DeleteInternationalLicense()
		{
			if (!base.DeleteApplication())
				return false;

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

			clsApplication App = clsApplication.FindApplicationByID(ApplicationID);

			if (App == null)
			{
				return null;
			}

			if (IsFound)
			{
				//	int ApplicationID, int ApplicantPersonID, enApplicationType ApplicationTypeID, DateTime ApplicationDate,
				//DateTime LastStatusDate, enApplicationStatus ApplicationStatus, float PaidFees, int CreatedByUserID
				clsInternationalLicense InternationalLicense = new clsInternationalLicense(App.ApplicationID, App.ApplicantPersonID, App.ApplicationTypeID, App.ApplicationDate,
					 App.LastStatusDate, App.ApplicationStatus, App.PaidFees, App.CreatedByUserID, InternationalLicenseID,
					 DriverID, IssuedUsingLocalLicenseID,
					 IssueDate, ExpirationDate, IsActive);
				return InternationalLicense;
			}

			return null;
		}


		public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
		{
			int IntLicneseID = clsInternationalLicenseData.GetActiveInternationalLicenseIDByDriverID(DriverID);
			return IntLicneseID;
		}








	}



}