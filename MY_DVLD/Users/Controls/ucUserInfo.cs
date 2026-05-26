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

namespace MY_DVLD.Users.Controls
{
	public partial class ucUserInfo : UserControl
	{
		public ucUserInfo()
		{
			InitializeComponent();
		}

		int _UserID;
		public int UserID
		{
			get { return _UserID; }
		}

		clsUser _User;
		public clsUser User
		{ get { return _User; } }



		private void _SetDefaultValues()
		{
			lbIsActive.Text = "????";
			lbUserID.Text = "????";
			lbUserName.Text = "????";

		}


		private void _FillPersonInfo()
		{
			ucPersonCard1.LoadPersonData(_User.PersonID);

			lbUserID.Text = _User.UserID.ToString();
			lbIsActive.Text = (_User.IsActive) ? "Yes" : "No";
			lbUserName.Text = _User.Username;
		}



		public void LoadUserInfo(int UserID)
		{
			_User = clsUser.FindUserByUserID(UserID);

			if (_User == null)
			{
				_SetDefaultValues();

				MessageBox.Show($"User Of UserID: {UserID} Was Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			_FillPersonInfo();




		}


	}
}
