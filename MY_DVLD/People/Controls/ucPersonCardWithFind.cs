using MY_DVLD.GlobalClasses;
using MY_DVLD_Business;
using MY_DVLD_GlobalClasses;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
namespace MY_DVLD.People.Controls
{
	public partial class ucPersonCardWithFind : UserControl
	{
		public ucPersonCardWithFind()
		{
			InitializeComponent();
		}

		//PersonID NationalNo  FirstName SecondName  ThirdName LastName
		//DateOfBirth Gender  Address Phone   Email NationalityCountryID    ImagePath
		#region Vars

		bool _ShowFindButton = true;
		public bool ShowFindButton
		{
			get { return _ShowFindButton; }

			set
			{
				_ShowFindButton = value;
				btnFindPerson.Visible = _ShowFindButton;
			}
		}


		bool _ShowAddPersonButton = true;
		public bool ShowAddPersonButton
		{
			get { return _ShowAddPersonButton; }

			set
			{
				_ShowAddPersonButton = value;
				btnAddNewPerson.Visible = _ShowAddPersonButton;
			}
		}


		bool _FilterEnabled = true;
		public bool FilterEnabled
		{
			get { return _FilterEnabled; }

			set
			{
				_FilterEnabled = value;
				gbFilter.Enabled = _FilterEnabled;
			}
		}


		enum enGender { Male, Female };

		public int PersonID
		{
			get { return ucPersonCard1.PersonID; }
		}

		public clsPerson SelectedPersonInfo
		{
			get { return ucPersonCard1.Person; }
		}

		private void ucPersonCardWithFind_Load(object sender, EventArgs e)
		{
			_IntializeFindByComboBox();
		}

		public event Action<int> OnPersonSelectedEvent;
		#endregion
		
		protected virtual void OnPersonSelected(int PersonID)
		{
			Action<int> handler;
			handler = OnPersonSelectedEvent;

			handler?.Invoke(PersonID);
		}

		void _IntializeFindByComboBox()
		{
			cbFilterBy.Items.Add("Person ID");
			cbFilterBy.Items.Add("National No");
			cbFilterBy.SelectedIndex = 0;
		}

		public void LoadPerson(int PersonID)
		{

			txtFindByValue.Text=PersonID.ToString().Trim();
			_FindPerson();
		}

		public void LoadPerson(string NationalNo)
		{
			txtFindByValue.Text = NationalNo.ToString().Trim();
			_FindPerson();
		}

		private void btnFindPerson_Click(object sender, EventArgs e)
		{
			_FindPerson();
		}

		private void _FindPerson()
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show("All Fileds Are Required");
				return;
			}

			string UserInput = txtFindByValue.Text.Trim();

			if (cbFilterBy.SelectedItem == "Person ID")
				ucPersonCard1.LoadPersonData(int.Parse(UserInput));

			if (cbFilterBy.SelectedItem == "National No")
				ucPersonCard1.LoadPersonData(UserInput);
				
				////assign the personId to the textbox


			//Fire the event if there is any subscribers 
			//the form will be subscribed when the user adds the event handler(onPersonSelected)
			if (OnPersonSelectedEvent != null) //&& FilterEnabled)
			{ OnPersonSelected(PersonID); }

		}

		private void btnAddNewPerson_Click(object sender, EventArgs e)
		{
			frmAddUpdatePerson frm = new frmAddUpdatePerson();
			frm.DataBack_PersonID += HandelAddingNewPerson;
			frm.ShowDialog();
		}

		private void HandelAddingNewPerson(int PersonID)
		{
			ucPersonCard1.LoadPersonData(PersonID);
			txtFindByValue.Text = PersonID.ToString();
			cbFilterBy.SelectedItem = "Person ID";
		}

		private void txtFindByValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
				btnFindPerson.PerformClick();


			if (cbFilterBy.SelectedItem == "Person ID")
				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
			else
				e.Handled = false;
		}


		private void txtFindByValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			clsValidation.ValidateControlRequired(sender, e, errorProvider1);
		}
	}
}