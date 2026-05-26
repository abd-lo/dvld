using MY_DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MY_DVLD_Business
{
	public class clsCountry
	{
		#region Vars
		public int CountryID { set; get; }
		public string CountryName { set; get; }
		#endregion

		clsCountry(int CountryID, string CountryName)
		{
			this.CountryID = CountryID;
			this.CountryName = CountryName;
		}

		public static DataTable GetAllCountries()
		{
			return clsCountryData.GetAllCountries();

		}


		public static clsCountry Find(int CountryID)
		{
			string CountryName = clsCountryData.Find(CountryID);

			if (!string.IsNullOrEmpty(CountryName))
				return new clsCountry(CountryID, CountryName);

			else return null;
		}

		public static clsCountry Find(string CountryName)
		{
			int CountryID = clsCountryData.Find(CountryName);

			if (CountryID >= 0)
				return new clsCountry(CountryID, CountryName);

			else return null;
		}










	}
}
