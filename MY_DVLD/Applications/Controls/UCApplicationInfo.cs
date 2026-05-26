using MY_DVLD.People;
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

namespace MY_DVLD.Applications.Controls
{
	public partial class UCApplicationInfo : UserControl
	{
		int _ApplicationID=-1;
		clsApplication _Application;

		public UCApplicationInfo()
		{
			InitializeComponent();
		}


		private void _ResetDefaultValues()
		{
			_ApplicationID = -1;

			lblApplicationID.Text = "[????]";
			lblStatus.Text = "[????]";
			lblType.Text = "[????]";
			lblFees.Text = "[????]";
			lblApplicant.Text = "[????]";
			lblDate.Text = "[????]";
			lblStatusDate.Text = "[????]";
			lblCreatedByUser.Text = "[????]";
		}

		private void _FillApplicationInfo()
		{
			_ApplicationID = _Application.ApplicationID;

			lblApplicationID.Text = _Application.ApplicationID.ToString();
			lblStatus.Text = _Application.StatusText;
			lblType.Text = _Application.ApplicationTypeInfo.ApplicationTypeTitle;
			lblFees.Text = _Application.PaidFees.ToString();
			lblApplicant.Text = _Application.ApplicantFullName;
			lblDate.Text = _Application.ApplicationDate.ToShortDateString();
			lblStatusDate.Text = _Application.LastStatusDate.ToShortDateString();
			lblCreatedByUser.Text = _Application.UserInfo.Username;
		}

		public void LoadData(int ApplicationID)
		{

			_Application = clsApplication.FindApplicationByID(ApplicationID);

			if (_Application == null)
			{
				MessageBox.Show($"UnableToFindThisApplicationWithApplicationID{ApplicationID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_ResetDefaultValues();
				return;
			}


			_FillApplicationInfo();
		}

		private void UCApplicationInfo_Load(object sender, EventArgs e)
		{
			_ResetDefaultValues();
		}

		private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmShowPersonInfo frm = new frmShowPersonInfo(_Application.ApplicantPersonID);
			frm.ShowDialog();

			LoadData(_ApplicationID);

		}




	}
}
