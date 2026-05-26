using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_DVLD_DataAccess;
namespace MY_DVLD_Business
{
	public class clsTestType
	{
		public enum enMode
		{
			AddNew, Update
		}

		public enum enTestType
		{
			VisionTest = 1, WrittenTest = 2, StreetTest = 3
		};

		public enTestType ID { set; get; }
		public string Title { set; get; }
		public string Description { set; get; }
		public float Fees { set; get; }
		public enMode Mode { set; get; }

		clsTestType(enTestType TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestTypeFees)
		{
			this.ID = TestTypeID;
			this.Title = TestTypeTitle;
			this.Description = TestTypeDescription;
			this.Fees = TestTypeFees;

			this.Mode = enMode.Update;
		}

		public clsTestType()
		{
			this.ID = enTestType.VisionTest;
			this.Title = "";
			this.Description = "";
			this.Fees = 0;

			this.Mode = enMode.AddNew;
		}

		public static DataTable GetAllTestTypes()
		{
			DataTable dt = clsTestTypesData.GetAllTestTypes();
			return dt;
		}
		
		public static float GetTestFees(enTestType TestType)
		{
			return clsTestType.FindTestType(TestType).Fees;
		}

		public static clsTestType FindTestType(enTestType TestTypeID)
		{
			//int TestTypeID,  string TestTypeTitle,  string TestTypeDescription,  float TestTypeFees
			string TestTypeTitle = "", TestTypeDescription = "";
			float TestTypeFees = 0;

			if (clsTestTypesData.FindTestTypeByTestID((int)TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
				return new clsTestType(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);

			else
				return null;

		}

		private bool _UpdateTestType()
		{
			return clsTestTypesData.UpdateTestType((int)this.ID, this.Title, this.Description, this.Fees);
		}

		private bool _AddNewTestType()
		{
			int TestTypeID = -1;
			bool IsAdded = clsTestTypesData.AddNewTestType(ref TestTypeID, this.Title, this.Description, this.Fees);

			if (IsAdded)
			{
				this.ID = (enTestType)TestTypeID;
				return true;
			}
			else
				return false;
		}

		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					{
						if (_AddNewTestType())
						{

							this.Mode = enMode.Update;
							return true;
						}
						return false;

					}

				case enMode.Update:
					return _UpdateTestType();


			}
			return false;

		}


	}
}
