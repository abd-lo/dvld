using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_DVLD_Business.Enum;
using MY_DVLD_DataAccess;

namespace MY_DVLD_Business
{
	public class clsApplicationType
	{
		public enApplicationType ApplicationTypeID { set; get; }
		public string ApplicationTypeTitle { set; get; }
		public float ApplicationFees { set; get; }


		clsApplicationType()
		{
			this.ApplicationTypeID = enApplicationType.NewDrivingLicense;
			this.ApplicationTypeTitle = "";
			this.ApplicationFees = 0;
		}
		 
		clsApplicationType(enApplicationType ApplicationTypeID, string ApplicationTypeTitle, float ApplicationFees)
		{
			this.ApplicationTypeID = ApplicationTypeID;
			this.ApplicationTypeTitle = ApplicationTypeTitle;
			this.ApplicationFees = ApplicationFees;
		}

		public static DataTable GetAllApplicationTypes()
		{
			return clsApplicationTypeData.GetAllApplicationTypes();
		}

		public static clsApplicationType FindApplicationTypeByID(enApplicationType ApplicationTypeID)
		{
			string ApplicationTypeTitle = "";
			float ApplicationFees = 0;

			bool IsFound = clsApplicationTypeData.FindApplicationTypeByApplicationID((int)ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees);
			if (IsFound)
				return new clsApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);

			else return null;
		}

		private bool _Update()
		{
			bool IsUpdated = clsApplicationTypeData.UpdateApplicationTypeData((int)this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
			return IsUpdated;
		}


		public bool Save()
		{
			if (_Update()) return true;
			else return false;
		}


	}
}
