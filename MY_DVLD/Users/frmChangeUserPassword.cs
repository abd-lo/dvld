using MY_DVLD.GlobalClasses;
using MY_DVLD_Business;
using MY_DVLD_GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Users
{
	public partial class frmChangeUserPassword : Form
	{
		clsUser _User;
		int _UserID;

		public frmChangeUserPassword(int UserID)
		{
			InitializeComponent();
			btnClose.CausesValidation = false;

			_UserID = UserID;
		}

		private void _ResetDefaultValues()
		{
			txtCurrentPassword.Text = "";
			txtNewPassword.Text = "";
			txtConfirmPassword.Text = "";


		}

		private void frmChangeUserPassword_Load(object sender, EventArgs e)
		{
			_LoadUserData();
			_ResetDefaultValues();
		}


		private void _LoadUserData()
		{
			_User = clsUser.FindUserByUserID(_UserID);

			if (_User == null)
			{
				MessageBox.Show($"User With UserID={_UserID} Isn't Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			ucUserInfo1.LoadUserInfo(_UserID);

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!this.ValidateChildren())
			{
				MessageBox.Show($"Check Fields Which Has Errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_User.Password = txtNewPassword.Text;

			if (_User.Save())
			{

				MessageBox.Show("Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				_ResetDefaultValues();
			}
			else

				MessageBox.Show($"Error Saving New User Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);





		}

		private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
		{
			string PasswrodUserInput = txtCurrentPassword.Text;
			clsValidation.ValidateControlRequired(sender, e, errorProvider1, "Can't Be Empty");

			if (PasswrodUserInput != _User.Password)
			{
				errorProvider1.SetError(txtCurrentPassword, "Wrong Password");
				e.Cancel = true;
			}
			else
				e.Cancel = false;


		}

		private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
		{
			string NewPasswrodUserInput = txtNewPassword.Text;
			string ConfirmNewPasswrodUserInput = txtConfirmPassword.Text;

			clsValidation.ValidateControlRequired(sender, e, errorProvider1, "Can't be Empty");

			if (NewPasswrodUserInput != ConfirmNewPasswrodUserInput)
			{
				errorProvider1.SetError(txtConfirmPassword, "Password DOsen't match");
				e.Cancel = true;
			}
			else
				e.Cancel = false;
		}

		private void txtNewPassword_Validating(object sender, CancelEventArgs e)
		{
			clsValidation.ValidateControlRequired(sender, e, errorProvider1, "Can't be Empty");

		}
	}
}
