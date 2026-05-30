using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_DVLD_DataAccess;
namespace MY_DVLD_Business
{
	public class clsLicenseClass
	{

		//LicenseClassID ClassName   ClassDescription MinimumAllowedAge   DefaultValidityLength ClassFees
		public int LicenseClassID { set; get; }
		public string ClassName { set; get; }
		public string ClassDescription { set; get; }
		public byte MinimumAllowedAge { set; get; }
		public byte DefaultValidityLength { set; get; }
		public float ClassFees { set; get; }

		public enum enMode { AddNew, Update };
		
		public enMode Mode;



		public clsLicenseClass()
		{
			this.LicenseClassID = 0;
			this.ClassName = "";
			this.ClassDescription = "";
			this.MinimumAllowedAge = 0;
			this.DefaultValidityLength = 0;
			this.ClassFees = 0f;
			this.Mode = enMode.AddNew;
		}

		clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
		{
			this.LicenseClassID = LicenseClassID;
			this.ClassName = ClassName;
			this.ClassDescription = ClassDescription;
			this.MinimumAllowedAge = MinimumAllowedAge;
			this.DefaultValidityLength = DefaultValidityLength;
			this.ClassFees = ClassFees;
			this.Mode = enMode.Update;


		}

		public static DataTable GetAllLicenseClasses()
		{
			return clsLicenseClassData.GetAllLicenseClasses();
		}

		bool _AddNewLicenseClass()
		{
			this.LicenseClassID = clsLicenseClassData.AddNewLicenseClass(this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
			return (this.LicenseClassID != -1);
		}

		bool _UpdateLicenseClass()
		{
			bool IsUpdated = clsLicenseClassData.UpdateLicenseClass(this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
			return IsUpdated;
		}

		public bool Save()
		{
			switch (this.Mode)
			{
				case enMode.AddNew:
					if (_AddNewLicenseClass())
					{
						this.Mode = enMode.Update;
						return true;
					}
					break;

				case enMode.Update:
					if (_UpdateLicenseClass())
						return true;
					break;
			}
			return false;
		}

		public static bool DeleteLicenseClass(int LicenseClassID)
		{
			return clsLicenseClassData.DeleteLicenseClass(LicenseClassID);
		}

		public static clsLicenseClass FindLicenseClassByID(int LicenseClassID)
		{
			string ClassName = "";
			string ClassDescription = "";
			byte MinimumAllowedAge = 0;
			byte DefaultValidityLength = 0;
			float ClassFees = 0f;

			bool IsFound = clsLicenseClassData.FindLicenseClassByID(LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees);

			if (IsFound)
			{
				clsLicenseClass LicenseClass = new clsLicenseClass(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
				return LicenseClass;
			}

			return null;
		}

		public static int GetDefaultValidityLength(int LicenseClassID)
		{
			return clsLicenseData.GetDefaultValidityLength(LicenseClassID);
		}



	}
}
