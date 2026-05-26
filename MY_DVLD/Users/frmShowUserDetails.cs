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
	public partial class frmShowUserDetails : Form
	{
		public frmShowUserDetails(int UserID)
		{
			InitializeComponent();
			ucUserInfo1.LoadUserInfo(UserID);
		}
	}
}
