using MY_DVLD.GlobalClasses;
using MY_DVLD.People;
using MY_DVLD_Business;
using System;
using System.Windows.Forms;
using System.IO;
namespace MY_DVLD.Login
{
	public partial class frmLogin : Form
	{

		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string Username, Password;
			Username = txtUserName.Text.Trim();
			Password = txtPassword.Text.Trim();

			if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
			{
				MessageBox.Show("Fields Can't Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			clsUser user = clsUser.FindUserByUsernameAndPassword(Username, Password);

			if (user == null)
			{
				MessageBox.Show("Credential are not vaild", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!user.IsActive)
			{
				MessageBox.Show("User Is Not Active Call Admin", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			clsGlobal.CurrentUser = user;


			frmMainForm frm = new frmMainForm(this);
			this.Hide();
			frm.ShowDialog();


			if (frm.IsSignOut)
			{
				clsGlobal.ClearStoredCredential();
				IntializeTextBoxes();
				this.Show();
				return;
			}
			else
				this.Close();


			if (chkRememberMe.Checked)
				clsGlobal.SetStoredCredential(Username, Password);

			else
				clsGlobal.ClearStoredCredential();
		}

		public void IntializeTextBoxes()
		{
			string Username = "", Password = ""; bool IsDataExisted = false;

			IsDataExisted = clsGlobal.GetStoredCredential(ref Username, ref Password);

			if (IsDataExisted)
			{
				txtUserName.Text = Username;
				txtPassword.Text = Password;
			}
			else
			{
				txtUserName.Clear();
				txtPassword.Clear();
			}

		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

			IntializeTextBoxes();
		}

		private void btnFillDefaultData_Click(object sender, EventArgs e)
		{
			txtUserName.Text = "user4";
			txtPassword.Text = "1234";
		}
	}
}
