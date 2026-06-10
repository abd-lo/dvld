using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_DVLD_DataAccess;

namespace MY_DVLD_Business
{
	public class clsDetainedLicense
	{
		#region Vars

		public int DetainID { get; set; }
		public int LicenseID { get; set; }
		public DateTime DetainDate { get; set; }
		public float FineFees { get; set; }
		public int CreatedByUserID { get; set; }
		public bool IsReleased { get; set; }
		public DateTime ReleaseDate { get; set; }
		public int ReleasedByUserID { get; set; }
		public int ReleaseApplicationID { get; set; }

		public clsUser CreatedByUserInfo { get; set; }
		public enum enMode { AddNew, Update };
		enMode Mode;

		#endregion


		public clsDetainedLicense()
		{
			this.DetainID = -1;
			this.LicenseID = -1;
			this.DetainDate = DateTime.Now;
			this.FineFees = 0f;
			this.CreatedByUserID = -1;
			this.IsReleased = false;
			this.ReleaseDate = DateTime.MaxValue;
			this.ReleasedByUserID = -1;
			this.ReleaseApplicationID = -1;

			this.CreatedByUserInfo = null;
			this.Mode = enMode.AddNew;
		}

		clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
		{
			this.DetainID = DetainID;
			this.LicenseID = LicenseID;
			this.DetainDate = DetainDate;
			this.FineFees = FineFees;
			this.CreatedByUserID = CreatedByUserID;
			this.IsReleased = IsReleased;
			this.ReleaseDate = ReleaseDate;
			this.ReleasedByUserID = ReleasedByUserID;
			this.ReleaseApplicationID = ReleaseApplicationID;

			this.CreatedByUserInfo = clsUser.FindUserByUserID(this.CreatedByUserID);
			this.Mode = enMode.Update;
		}

		public static DataTable GetAllDetainedLicenses()
		{
			return clsDetainedLicenseData.GetAllDetainedLicenses();
		}

		public static DataTable GetDetainedLicenseWithData()
		{
			return clsDetainedLicenseData.GetDetainedLicenseWithData();
		}


		bool _AddNewDetainedLicense()
		{
			this.DetainID = clsDetainedLicenseData.AddNewDetainedLicense(this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
			return (this.DetainID != -1);
		}

		bool _UpdateDetainedLicense()
		{
			bool IsUpdated = clsDetainedLicenseData.UpdateDetainedLicense(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
			return IsUpdated;
		}

		public bool Save()
		{
			switch (this.Mode)
			{
				case enMode.AddNew:
					if (_AddNewDetainedLicense())
					{
						this.Mode = enMode.Update;
						return true;
					}
					break;

				case enMode.Update:
					if (_UpdateDetainedLicense())
						return true;
					break;
			}
			return false;
		}

		public static bool DeleteDetainedLicense(int DetainID)
		{
			return clsDetainedLicenseData.DeleteDetainedLicense(DetainID);
		}

		public static clsDetainedLicense FindDetainedLicenseByID(int DetainID)
		{
			int LicenseID = 0;
			DateTime DetainDate = DateTime.MinValue;
			float FineFees = 0f;
			int CreatedByUserID = 0;
			DateTime ReleaseDate = DateTime.MinValue;
			int ReleasedByUserID = 0;
			int ReleaseApplicationID = 0;
			bool IsReleased = false;
			bool IsFound = clsDetainedLicenseData.FindDetainedLicenseByID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

			if (IsFound)
			{
				clsDetainedLicense DetainedLicense = new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
				return DetainedLicense;
			}

			return null;
		}

		public static clsDetainedLicense FindDetainedLicenseByLicenseID(int LicenseID)
		{
			int DetainID = 0;
			DateTime DetainDate = DateTime.MinValue;
			float FineFees = 0f;
			int CreatedByUserID = 0;
			DateTime ReleaseDate = DateTime.MinValue;
			int ReleasedByUserID = 0;
			int ReleaseApplicationID = 0;
			bool IsReleased = false;

			bool IsFound = clsDetainedLicenseData.FindDetainedLicenseByLicenseID(ref DetainID, LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

			if (IsFound)
			{
				clsDetainedLicense DetainedLicense = new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
				return DetainedLicense;
			}

			return null;
		}

		public static bool IsLicenseDetained(int LicenseID)
		{
			bool IsDetained = clsDetainedLicenseData.IsLicenseDetainedByLicenseID(LicenseID);

			return IsDetained;
		}


		public bool ReleaseDetainedLicense(int ApplicationID, int ReleasedByUserID)
		{
			this.IsReleased = true;
			this.ReleaseApplicationID = ApplicationID;
			this.ReleaseDate = DateTime.Now;
			this.ReleasedByUserID = ReleasedByUserID;
			
			if (this.Save())
				return true;

			else
				return false;
		}


	}
}
