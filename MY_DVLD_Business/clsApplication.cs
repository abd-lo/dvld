using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MY_DVLD_Business.Enum;
using MY_DVLD_DataAccess;
using static MY_DVLD_Business.clsApplication;
namespace MY_DVLD_Business
{
	public class clsApplication
	{

		#region Vars

		public int ApplicationID { set; get; }
		public int ApplicantPersonID { set; get; }
		public enApplicationType ApplicationTypeID { set; get; }
		public int CreatedByUserID { set; get; }
		public DateTime ApplicationDate { set; get; }
		public DateTime LastStatusDate { set; get; }
		public float PaidFees { set; get; }
		public enApplicationStatus ApplicationStatus { set; get; }



		public string StatusText
		{
			get
			{
				switch (ApplicationStatus)
				{
					case enApplicationStatus.New:
						return "New";

					case enApplicationStatus.Completed:
						return "Completed";


					case enApplicationStatus.Cancelled:
						return "Cancelled";

					default:
						return "Cancelled";

				}

			}
		}

		public string ApplicantFullName
		{
			get
			{ return clsPerson.FindByID(ApplicantPersonID).FullName; }
		}
		public clsUser UserInfo { set; get; }

		public clsApplicationType ApplicationTypeInfo { set; get; }
		string LastStatus
		{
			get
			{
				switch (ApplicationStatus)
				{
					case enApplicationStatus.New:
						return "New";

					case enApplicationStatus.Cancelled:
						return "Cancelled";


					case enApplicationStatus.Completed:
						return "Completed";

					default:
						return "NULL";
				}
			}

		}


		//public enum enApplicationType
		//{
		//	NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
		//	ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
		//};

		public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };


		public enum enMode { AddNew, Update };
		public enMode Mode;
		#endregion

		//int ApplicationID,int ApplicantPersonID, int ApplicationTypeID,DateTime ApplicationDate, DateTime LastStatusDate,byte ApplicationStatus,float PaidFees	,int CreatedByUserID
		protected clsApplication(int ApplicationID, int ApplicantPersonID, enApplicationType ApplicationTypeID, DateTime ApplicationDate, DateTime LastStatusDate, enApplicationStatus ApplicationStatus, float PaidFees, int CreatedByUserID)
		{

			this.ApplicationID = ApplicationID;
			this.ApplicantPersonID = ApplicantPersonID;
			this.ApplicationTypeID = ApplicationTypeID;
			this.CreatedByUserID = CreatedByUserID;
			this.ApplicationDate = ApplicationDate;
			this.LastStatusDate = LastStatusDate;
			this.PaidFees = PaidFees;
			this.ApplicationStatus = ApplicationStatus;
			this.Mode = enMode.Update;
			this.UserInfo = clsUser.FindUserByUserID(CreatedByUserID);
			this.ApplicationTypeInfo = clsApplicationType.FindApplicationTypeByID(ApplicationTypeID);

		}
		public clsApplication()
		{
			this.ApplicationID = -1;
			this.ApplicantPersonID = -1;
			this.ApplicationTypeID = enApplicationType.NewDrivingLicense;
			this.CreatedByUserID = -1;
			this.ApplicationDate = DateTime.Now;
			this.LastStatusDate = DateTime.Now;
			this.PaidFees = 0f;
			this.ApplicationStatus = enApplicationStatus.New;
			this.Mode = enMode.AddNew;

		}


		public static DataTable GetAllApplications()
		{
			return clsApplicationData.GetAllApplications();
		}

		bool _AddNewApplication()
		{
			this.ApplicationID = clsApplicationData.AddNewApplication(this.ApplicantPersonID, (int)this.ApplicationTypeID, this.ApplicationDate, this.LastStatusDate, (byte)this.ApplicationStatus, this.PaidFees, this.CreatedByUserID);
			return (this.ApplicationID != -1);
		}

		bool _UpdateApplication()
		{
			bool IsUpdated = clsApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, (int)this.ApplicationTypeID, this.ApplicationDate, this.LastStatusDate, (byte)this.ApplicationStatus, this.PaidFees, this.CreatedByUserID);
			return IsUpdated;
		}
		public bool Save()
		{
			switch (this.Mode)
			{
				case enMode.AddNew:
					if (_AddNewApplication())
					{
						this.Mode = enMode.Update;
						return true;
					}
					break;

				case enMode.Update:
					if (_UpdateApplication())
						return true;
					break;
			}
			return false;
		}

		public bool DeleteApplication()
		{

			return clsApplicationData.DeleteApplication(this.ApplicationID);
		}

		public static clsApplication FindApplicationByID(int ApplicationID)
		{
			int ApplicantPersonID = 0;
			int ApplicationTypeID = 0;
			DateTime ApplicationDate = DateTime.MinValue;
			DateTime LastStatusDate = DateTime.MinValue;
			float PaidFees = 0f;
			int CreatedByUserID = 0;
			byte ApplicationStatus = 1;

			bool IsFound = clsApplicationData.FindApplicationByID(ApplicationID, ref ApplicantPersonID, ref ApplicationTypeID, ref ApplicationDate, ref LastStatusDate, ref ApplicationStatus, ref PaidFees, ref CreatedByUserID);

			if (IsFound)
			{
				clsApplication Application = new clsApplication(ApplicationID, ApplicantPersonID, (enApplicationType)ApplicationTypeID, ApplicationDate, LastStatusDate, (enApplicationStatus)ApplicationStatus, PaidFees, CreatedByUserID);
				return Application;
			}

			return null;
		}

		public static int GetActiveApplicationIDForPersonIDAndLicenseClass(ref int ApplicationID, int ApplicantID, int LicenseClass)
		{
			return
			clsApplicationData.GetActiveApplicationIDForPersonIDAndLicenseClass(ref ApplicationID, ApplicantID, LicenseClass);
		}

		public  bool UpdateStatus( enApplicationStatus ApplicationStatus)

		{
			return clsApplicationData.UpdateStatus(this.ApplicationID, (int)ApplicationStatus);
		}



		//public static void CancelApplication(int ApplicationID,)
		//{
		//clsApplicationData.UpdateStatus(ApplicationID,int);
		//}



	}
}


/*

public int LocalDrivingLicenseApplicationID { set; get; }
public int LicenseClassID { set; get; }

public int ApplicationID { set; get; }
public int ApplicantPersonID { set; get; }
public int ApplicationTypeID { set; get; }
public int CreatedByUserID { set; get; }
public DateTime ApplicationDate { set; get; }
public DateTime LastStatusDate { set; get; }
public float PaidFees { set; get; }
public enApplicationStatus ApplicationStatus { set; get; }
*/