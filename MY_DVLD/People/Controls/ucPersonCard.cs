using MY_DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MY_DVLD.People.Controls
{
	public partial class ucPersonCard : UserControl
	{
		public ucPersonCard()
		{
			InitializeComponent();
		}
		#region Vars

		int _PersonID = -1;
		public int PersonID
		{ get { return _PersonID; } }

		clsPerson _Person;
		public clsPerson Person
		{
			get { return _Person; }
		}
		enum enGender { Male, Female };

		#endregion


		void _FillPersonData()
		{
			lbPersonID.Text = _Person.PersonID.ToString();

			lbFullName.Text = _Person.FirstName + _Person.SecondName + _Person.ThirdName + _Person.LastName;
			lbNationalNo.Text = _Person.NationalNo;
			lbDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();

			if (_Person.Gender == (short)enGender.Male)
				lbGender.Text = "Male";
			else
				lbGender.Text = "Female";


			lbAddress.Text = _Person.Address;
			lbPhone.Text = _Person.Phone;
			lbEmail.Text = _Person.Email;

			lbCountry.Text = (clsCountry.Find(_Person.NationalityCountryID)).CountryName;


		}

		void _SetPersonImage()
		{
			enGender Gender = (enGender)_Person.Gender;
			string ImagePath = _Person.ImagePath;

			pbPersonImage.Image = (Gender == enGender.Male) ?
		 Properties.Resources.Male_512
		: Properties.Resources.Female_512;


			if (!string.IsNullOrWhiteSpace(ImagePath))
			{
				if (File.Exists(ImagePath))
				{
					pbPersonImage.Load(ImagePath);
				}
				else
					MessageBox.Show("  Image File Is Not Existed  " + ImagePath);
			}



		}

		void _ResetValues()
		{
			//why set PersonID to -1 ? 
			//in order to make reset it if user is found and then another search happens
			//and we are checking for is Person found via the person id
			_PersonID = -1;
			lbPersonID.Text = "????";

			lbFullName.Text = "????";
			lbNationalNo.Text = "????";
			lbDateOfBirth.Text = "????";
			lbGender.Text = "????";



			lbAddress.Text = "????";
			lbPhone.Text = "????";
			lbEmail.Text = "????";

			lbCountry.Text = "????";
			pbPersonImage.Image = Properties.Resources.Male_512;

			llEditPersonInfo.Enabled = false;
		}

		public void LoadPersonData(int PersonID)
		{
			_Person = clsPerson.FindByID(PersonID);

			if (_Person == null)
			{
				MessageBox.Show("No Person with ID = " + PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				_ResetValues();
				return;
			}

			_PersonID = _Person.PersonID;

			llEditPersonInfo.Enabled = true;
			_FillPersonData();

			_SetPersonImage();

		}

		public void LoadPersonData(string NationalNo)
		{
			_Person = clsPerson.FindByNationalNo(NationalNo);



			if (_Person == null)
			{
				MessageBox.Show("No Person with NationalNumber = " + NationalNo, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				_ResetValues();
				return;
			}
			_PersonID = _Person.PersonID;
			llEditPersonInfo.Enabled = true;

			_FillPersonData();

			_SetPersonImage();
		}

		private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmAddUpdatePerson frm = new frmAddUpdatePerson(_Person.PersonID);

			frm.ShowDialog();
			//Reload Same Person with changes 
			LoadPersonData(_Person.PersonID);
		}
	}
}
