using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MY_DVLD_Business;
using MY_DVLD_GlobalClasses;

namespace MY_DVLD.Users
{
	public partial class frmAddUpdateUser : Form
	{
		#region Vars

		clsUser _User;
		int _UserID;
		enum enMode { AddNew, Update };
		enMode _Mode;

		#endregion


		public frmAddUpdateUser()
		{
			InitializeComponent();
			_Mode = enMode.AddNew;

		}

		public frmAddUpdateUser(int UserID)
		{
			InitializeComponent();
			_Mode = enMode.Update;
			_UserID = UserID;
		}


		private void frmAddUpdateUser_Load(object sender, EventArgs e)
		{
			//ucPersonCardWithFind1.OnPersonSelectedEvent += LoadAndSetUserData;

			_SetDefaultValues();
		}

		private void _SetDefaultValues()
		{
			btnSave.Enabled = false;
			tpLoginInfo.Enabled = false;

			lbUserID.Text = "????";
			txtUserName.Text = "";
			txtPassword.Text = "";
			txtConfirmPassword.Text = "";

			if (_Mode == enMode.Update)
			{
				lbTitle.Text = "Update User";
				ucPersonCardWithFind1.FilterEnabled = false;
				LoadUser(_UserID);

			}
			else
			{
				ucPersonCardWithFind1.FilterEnabled = true;
				lbTitle.Text = "Add New User";
				_User = new clsUser();
			}
		}


		private void _FillUserData()
		{
			lbUserID.Text = _User.UserID.ToString();
			txtUserName.Text = _User.Username;
			txtPassword.Text = _User.Password;
			txtConfirmPassword.Text = _User.Password;
			chkIsActive.Checked = _User.IsActive;

			ucPersonCardWithFind1.LoadPerson(_User.PersonID);
		}

		public void LoadUser(int UserID)
		{
			_User = clsUser.FindUserByUserID(UserID);

			if (_User == null)
			{

				MessageBox.Show($"User With UserID:{UserID} Was not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_FillUserData();



		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{

			if (_Mode == enMode.AddNew)
			{
				//InCase of no person Selected
				if (ucPersonCardWithFind1.PersonID == -1)
				{

					MessageBox.Show($"Please Select A Person", "No Person Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

					return;
				}


				//Incase of selected is a user
				if (clsUser.IsUserExistByPersonID(ucPersonCardWithFind1.PersonID))
				{
					MessageBox.Show($"This Person is already a User", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

			}
			//if Update or addnew and person is selected
			tpLoginInfo.Enabled = true;
			btnSave.Enabled = true;
			tcUser.SelectedTab = tpLoginInfo;

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show($"All Fields Are Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_User.PersonID = ucPersonCardWithFind1.PersonID;
			_User.Password = txtPassword.Text;
			_User.Username = txtUserName.Text.Trim();
			_User.IsActive = chkIsActive.Checked;

			if (_User.Save())
			{
				MessageBox.Show("Saved Successfuly", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				lbUserID.Text = _User.UserID.ToString();
			}

			else
				MessageBox.Show($"Error Saving User Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);





		}

		private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
		{
			if (txtPassword.Text != txtConfirmPassword.Text)
			{

				MessageBox.Show("Password Doesn't Match");
				e.Cancel = true;

				return;
			}
			else
				e.Cancel = false;

		}

		private void txtUserName_Validating(object sender, CancelEventArgs e)
		{
			clsValidation.ValidateControlRequired(sender, e, errorProvider1, "UserName Is Required");
			string UsernameStringInput = txtUserName.Text.Trim();
			bool IsUsernameExisted = clsUser.IsUserExistByUsername(UsernameStringInput);

			if (_Mode == enMode.AddNew)
			{
				if (IsUsernameExisted)
				{
					MessageBox.Show($"Username Is Existed,Try Another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}


			if (_Mode == enMode.Update)
			{
				if (IsUsernameExisted)
				{
					if (UsernameStringInput != _User.Username.Trim())
					{
						MessageBox.Show($"Username Is Existed,Try Another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						errorProvider1.SetError(txtUserName, "Username Is Existed");
						return;
					}


				}
			}
		}


	}
}
