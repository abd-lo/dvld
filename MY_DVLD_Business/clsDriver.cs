using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_DVLD_DataAccess;

namespace MY_DVLD_Business
{
	public class clsDriver
	{
		public int DriverID { get; set; }
		public int PersonID { get; set; }
		public int CreatedByUserID { get; set; }
		public DateTime CreatedDate { get; set; }

		public enum enMode { AddNew, Update };
		public enMode Mode = enMode.AddNew;

		public clsPerson PersonInfo { get; set; }

		public clsDriver()
		{
			this.DriverID = 0;
			this.PersonID = 0;
			this.CreatedByUserID = 0;
			this.CreatedDate = DateTime.Now;
			this.Mode = enMode.AddNew;

		}

		clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
		{
			this.DriverID = DriverID;
			this.PersonID = PersonID;
			this.CreatedByUserID = CreatedByUserID;
			this.CreatedDate = CreatedDate;

			this.Mode = enMode.Update;
			PersonInfo = clsPerson.FindByID(PersonID);
		}

		public static DataTable GetAllDrivers()
		{
			return clsDriverData.GetAllDrivers();
		}

		bool _AddNewDriver()
		{
			this.DriverID = clsDriverData.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);
			return (this.DriverID != -1);
		}

		bool _UpdateDriver()
		{
			bool IsUpdated = clsDriverData.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
			return IsUpdated;
		}

		public bool Save()
		{
			switch (this.Mode)
			{
				case enMode.AddNew:
					if (_AddNewDriver())
					{
						this.Mode = enMode.Update;
						return true;
					}
					break;

				case enMode.Update:
					if (_UpdateDriver())
						return true;
					break;
			}
			return false;
		}

		public static bool DeleteDriver(int DriverID)
		{
			return clsDriverData.DeleteDriver(DriverID);
		}

		public static clsDriver FindDriverByID(int DriverID)
		{
			int PersonID = 0;
			int CreatedByUserID = 0;
			DateTime CreatedDate = DateTime.MinValue;

			bool IsFound = clsDriverData.FindDriverByID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate);

			if (IsFound)
			{
				clsDriver Driver = new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
				return Driver;
			}

			return null;
		}

		public static clsDriver FindDriverByPersonID(int PersonID)
		{

			int DriverID = -1;
			int CreatedByUserID = 0;
			DateTime CreatedDate = DateTime.MinValue;

			bool IsFound = clsDriverData.FindDriverByPersonID(ref DriverID,  PersonID, ref CreatedByUserID, ref CreatedDate);

			if (IsFound)
			{
				clsDriver Driver = new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
				return Driver;
			}

			return null;
		}

	}
}
