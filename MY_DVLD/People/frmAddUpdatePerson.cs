using MY_DVLD.GlobalClasses;
using MY_DVLD_Business;
using MY_DVLD_GlobalClasses;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MY_DVLD.People
{
	public partial class frmAddUpdatePerson : Form
	{

		//public delegate void DataBackHandler(object sender, int PersonID);
		public event Action<int> DataBack_PersonID;

		//private void Form2_Load(object sender, EventArgs e)
		//{

		//}

		//private void button1_Click(object sender, EventArgs e)
		//{
		//	DataBack?.Invoke(this, Convert.ToInt16(txtPersonID.Text));

		//}
		#region Vars

		int _PersonID = -1;
		enum enMode { AddNew, Update };
		enum enGender { Male = 0, Female = 1 };
		enMode _Mode;
		clsPerson _Person;

		bool _HasCustomImage = false;

		#endregion

		public frmAddUpdatePerson(int PersonID)
		{
			InitializeComponent();
			_PersonID = PersonID;
			_Mode = enMode.Update;


		}

		public frmAddUpdatePerson()
		{
			InitializeComponent();

			_Mode = enMode.AddNew;
			lblTitle.Text = "Add New Person Data";
			//if there is no Person ID so we call the construcotr and it's mode is addnew 
			// othrewise we call Find Function in _LoadpersonData and mode is update
			_Person = new clsPerson();
		}

		private void frmAddEditPerson_Load(object sender, EventArgs e)
		{
			_SetDataDefaultData();


			if (_Mode == enMode.Update)
				_LoadPersonDataToForm();
		}

		void _IntializeCountriesComboBox()
		{
			cbCountry.DataSource = clsCountry.GetAllCountries();              // Bind DataTable as source
			cbCountry.DisplayMember = "CountryName";       // Column to display in dropdown
			cbCountry.ValueMember = "CountryID"; //Assing ID to each CountryName

			cbCountry.SelectedValue = clsCountry.Find("Syria").CountryID;
		}

		void _IntializeDatePicker()
		{
			dtpDateOfBirth.MinDate = DateTime.Today.AddYears(-120);

			//// Optional: set a reasonable MinDate (e.g., nobody older than 120 years)
			dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
		}

		void _IntializeTextBoxes()
		{
			txtFirstName.Clear();
			txtSecondName.Clear();
			txtThirdName.Clear();
			txtLastName.Clear();
			txtNationalNo.Clear();
			txtPhone.Clear();
			txtEmail.Clear();
			txtAddress.Clear();
		}

		void _IntializeTitleLabel()
		{
			lblTitle.Text = _Mode == enMode.AddNew ? "Add New Person" : "Update Person";
		}

		void _SetDataDefaultData()
		{
			_IntializeCountriesComboBox();
			_IntializeDatePicker();
			_IntializeTextBoxes();
			_IntializeTitleLabel();
			_SetGenderPicture();

			if (_Mode == enMode.AddNew)
				_Person = new clsPerson();

			llRemoveImage.Visible = false;

		}

		void _LoadPersonDataToForm()
		{
			_Person = clsPerson.FindByID(_PersonID);


			if (_Person == null)
			{
				MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.Close();
				return;
			}

			//the following code will not be executed if the person was not found
			lbPersonID.Text = _PersonID.ToString();
			txtFirstName.Text = _Person.FirstName;
			txtSecondName.Text = _Person.SecondName;
			txtThirdName.Text = _Person.ThirdName;
			txtLastName.Text = _Person.LastName;
			txtNationalNo.Text = _Person.NationalNo;
			dtpDateOfBirth.Value = _Person.DateOfBirth;

			if (_Person.Gender == 0)
				rbMale.Checked = true;
			else
				rbFemale.Checked = true;

			txtAddress.Text = _Person.Address;
			txtPhone.Text = _Person.Phone;
			txtEmail.Text = _Person.Email;

			cbCountry.SelectedValue = _Person.NationalityCountryID;

			_HasCustomImage = !string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath);

			if (_HasCustomImage)
			{
				pbPersonImage.Load(_Person.ImagePath);
			}
			llRemoveImage.Visible = _HasCustomImage;

		}



		#region ChangingPictureAccordingToCheckBoxes

		bool _HandlePersonImage()
		{
			//check if changed
			if (pbPersonImage.ImageLocation != _Person.ImagePath)
			{
				if (_Person.ImagePath != "")
				{
					//Delete Old One
					try
					{
						File.Delete(_Person.ImagePath);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Erorr Deleting the Old Photo " + ex);
					}

				}


				if (pbPersonImage.ImageLocation != null)
				{

					var (Success, DestinationFilePath) = clsUtil.CopyImageFile(pbPersonImage.ImageLocation);

					if (Success)
					{
						pbPersonImage.ImageLocation = DestinationFilePath;
						return true;
					}


					else
					{

						MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
			}

			return true;
		}
		

	void _SetGenderPicture()
	{


		pbPersonImage.Image = (rbMale.Checked) ?
	 Properties.Resources.Male_512
	: Properties.Resources.Female_512;


	}

	private void rbGender_CheckedChanged(object sender, EventArgs e)
	{

		if (!_HasCustomImage)
		{
			_SetGenderPicture();
		}


	}
	private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		openFileDialog1.Title = "Choosing New Photo";
		openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

		//the default extension If User didn't type the extension with the file name
		//filter files via extension
		openFileDialog1.Filter = "JPEG Image (*.jpg)|*.jpg|PNG Image (*.png)|*.png|Bitmap Image (*.bmp)|*.bmp|All files (*.*)|*.*"; ;
		//default extension
		openFileDialog1.DefaultExt = "jpg";
		openFileDialog1.FilterIndex = 1;

		if (openFileDialog1.ShowDialog() == DialogResult.OK)
		{
			// Check the file really exists before loading
			if (File.Exists(openFileDialog1.FileName))
			{
				string ImagePath = openFileDialog1.FileName;
				pbPersonImage.Load(ImagePath);
				_HasCustomImage = true; // mark this as a custom photo if you're using the flag approach
				llRemoveImage.Visible = true;
			}
			else
			{
				MessageBox.Show("The selected file could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
	private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		_SetGenderPicture();
		llRemoveImage.Visible = false;
		_HasCustomImage = false;
		pbPersonImage.ImageLocation = "";
	}

	#endregion

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (!_HandlePersonImage())
		{

			return;
		}
		if (!this.ValidateChildren())
		{

			MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			return;
		}

		int countryId = Convert.ToInt32(cbCountry.SelectedValue);

		_Person.NationalNo = txtNationalNo.Text;
		_Person.FirstName = txtFirstName.Text;
		_Person.SecondName = txtSecondName.Text;
		_Person.ThirdName = txtThirdName.Text;
		_Person.LastName = txtLastName.Text;
		_Person.DateOfBirth = dtpDateOfBirth.Value;
		_Person.Gender = (rbMale.Checked) ? (short)enGender.Male : (short)enGender.Female;
		_Person.Address = txtAddress.Text;
		_Person.Phone = txtPhone.Text;
		_Person.NationalityCountryID = countryId;
		_Person.Email = txtEmail.Text;

		if (pbPersonImage.ImageLocation != null)
		{
			_Person.ImagePath = pbPersonImage.ImageLocation;
		}
		else
			_Person.ImagePath = "";


		if (_Person.Save())
		{
			MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			lbPersonID.Text = _Person.PersonID.ToString();
			_Mode = enMode.Update;

			lblTitle.Text = "Update Person";

			//Invoke The event
			DataBack_PersonID?.Invoke(_Person.PersonID);
		}
		else

			MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	}



	#region Validation

	private void txtNationalNo_Validating(object sender, CancelEventArgs e)
	{

		if (string.IsNullOrWhiteSpace(txtNationalNo.Text))
		{
			errorProvider1.SetError(txtNationalNo, "This Field Is Required");
			e.Cancel = true;

			return;
		}

		else errorProvider1.SetError(txtNationalNo, "");


		if (clsPerson.IsNationalNumberExisted(txtNationalNo.Text) && txtNationalNo.Text.Trim() != _Person.NationalNo)
		{

			errorProvider1.SetError(txtNationalNo, "NationalNumber Existed.");


			e.Cancel = true;
		}
		else errorProvider1.SetError(txtNationalNo, "");
	}

	private void ValidateTextBoxes(object sender, CancelEventArgs e)
	{
		TextBox Temp = (TextBox)sender;

		if (string.IsNullOrWhiteSpace(Temp.Text))
		{
			errorProvider1.SetError(Temp, "This Field Is Required");
			e.Cancel = true;
		}

		else
			errorProvider1.SetError(Temp, "");

	}

	private void txtEmail_Validating(object sender, CancelEventArgs e)
	{
		if (string.IsNullOrWhiteSpace(txtEmail.Text))
		{
			errorProvider1.SetError(txtEmail, "");
			return;
		}

		if (!clsValidation.IsValidEmail(txtEmail.Text))
		{
			errorProvider1.SetError(txtEmail, "Email Is not Valid!");
			e.Cancel = true;
		}

		else errorProvider1.SetError(txtEmail, "");
	}
	#endregion
	private void btnClose_Click(object sender, EventArgs e)
	{

		this.Close();

	}
}












}