using System.Windows.Forms;


namespace MY_DVLD.People
{
	public partial class frmShowPersonInfo : Form
	{
		int _PersonID;

		public frmShowPersonInfo(int PersonID)
		{
			InitializeComponent();
			_PersonID = PersonID;
		}
		private void frmShowPersonInfo_Load(object sender, System.EventArgs e)
		{
			ucPersonCard1.LoadPersonData(_PersonID);
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		/*
		#region Vars

		int _PersonID = -1;
		enum enMode { AddNew, Update };
		enum enGender { Male = 0, Female = 1 };
		enMode _Mode;
		clsPersons _Person;

		bool _HasCustomImage = false;

		#endregion

		public frmShowPersonInfo(int PersonID)
		{
			InitializeComponent();
			_PersonID = PersonID;
			_Mode = enMode.Update;
			lblTitle.Text = "Update Person Data";

		}

		public frmShowPersonInfo()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;
			lblTitle.Text = "Add New Person Data";
		}



		void _LoadPersonData()
		{
			_Person = clsPersons.FindByID(_PersonID);


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


			if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
			{
				pbPersonImage.Image = Image.FromFile(_Person.ImagePath);

				_HasCustomImage = true;
			}


		}

		bool IsValidEmail(string email)
		{
			return Regex.IsMatch(email,
				@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
				RegexOptions.IgnoreCase);
		}
		private void txtEmail_Validated(object sender, EventArgs e)
		{
			if (!IsValidEmail(txtEmail.Text))
			{
				errorProvider1.SetError(txtEmail, "Email Is not Valid!");
				txtEmail.Focus();
			}
			else errorProvider1.SetError(txtEmail, "");



		}
		private void txtNationalNo_Validating(object sender, CancelEventArgs e)
		{
			btnSave.Enabled = true;
			if (_Mode == enMode.Update && txtNationalNo.Text == _Person.NationalNo)
			{

				errorProvider1.SetError(txtNationalNo, "");
				return;
			}

			if (clsPersons.IsNationalNumberExisted(txtNationalNo.Text))
			{

				errorProvider1.SetError(txtNationalNo, "NationalNumber Existed.");
				txtNationalNo.Focus();
				btnSave.Enabled = false;
			}
			else errorProvider1.SetError(txtNationalNo, "");
		}



		void _SetGenderPicture()
		{
			_HasCustomImage = false;

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

		private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			_SetGenderPicture();


		}





		void _SetDataDefaultData()
		{
			cbCountry.DataSource = clsCountry.GetAllCountries();              // Bind DataTable as source
			cbCountry.DisplayMember = "CountryName";       // Column to display in dropdown
			cbCountry.ValueMember = "CountryID"; //Assing ID to each CountryName


			dtpDateOfBirth.MinDate = DateTime.Today.AddYears(-120);

			//// Optional: set a reasonable MinDate (e.g., nobody older than 120 years)
			dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
		}


		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmAddEditPerson_Load(object sender, EventArgs e)
		{
			_SetDataDefaultData();

			if (_Mode == enMode.Update)
				_LoadPersonData();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{


			int countryId = Convert.ToInt32(cbCountry.SelectedValue);

			_Person.NationalNo = txtNationalNo.Text;
			_Person.FirstName = txtFirstName.Text;
			_Person.SecondName = txtNationalNo.Text;
			_Person.ThirdName = txtNationalNo.Text;
			_Person.LastName = txtNationalNo.Text;
			_Person.DateOfBirth = dtpDateOfBirth.Value;
			_Person.Gender = (rbFemale.Checked) ? (short)enGender.Male : (short)enGender.Female;
			_Person.Address = txtAddress.Text;
			_Person.Phone = txtNationalNo.Text;
			_Person.NationalityCountryID = Convert.ToInt32(cbCountry.SelectedValue);
			_Person.Email = txtEmail.Text;
			_Person.ImagePath = pbPersonImage.ImageLocation;

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
					pbPersonImage.Image = Image.FromFile(openFileDialog1.FileName);
					_HasCustomImage = true; // mark this as a custom photo if you're using the flag approach
				}
				else
				{
					MessageBox.Show("The selected file could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}
			*/
	}
}

