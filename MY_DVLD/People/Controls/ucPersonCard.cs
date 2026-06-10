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

		public int PersonID { get; private set; } = -1;

		public clsPerson Person { get; private set; } = null;
		enum enGender { Male, Female };

		#endregion


		void _FillPersonData()
		{
			lbPersonID.Text = Person.PersonID.ToString();

			lbFullName.Text = Person.FirstName + Person.SecondName + Person.ThirdName + Person.LastName;
			lbNationalNo.Text = Person.NationalNo;
			lbDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();

			if (Person.Gender == (short)enGender.Male)
				lbGender.Text = "Male";
			else
				lbGender.Text = "Female";


			lbAddress.Text = Person.Address;
			lbPhone.Text = Person.Phone;
			lbEmail.Text = Person.Email;

			lbCountry.Text = (clsCountry.Find(Person.NationalityCountryID)).CountryName;


		}

		void _SetPersonImage()
		{
			enGender Gender = (enGender)Person.Gender;
			string ImagePath = Person.ImagePath;

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
			PersonID = -1;
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
			Person = clsPerson.FindByID(PersonID);

			if (Person == null)
			{
				MessageBox.Show("No Person with ID = " + PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				_ResetValues();
				return;
			}

			PersonID = Person.PersonID;

			llEditPersonInfo.Enabled = true;
			_FillPersonData();

			_SetPersonImage();

		}

		public void LoadPersonData(string NationalNo)
		{
			Person = clsPerson.FindByNationalNo(NationalNo);



			if (Person == null)
			{
				MessageBox.Show("No Person with NationalNumber = " + NationalNo, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				_ResetValues();
				return;
			}
			PersonID = Person.PersonID;
			llEditPersonInfo.Enabled = true;

			_FillPersonData();

			_SetPersonImage();
		}

		private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmAddUpdatePerson frm = new frmAddUpdatePerson(Person.PersonID);

			frm.ShowDialog();
			//Reload Same Person with changes 
			LoadPersonData(Person.PersonID);
		}
	}
}
