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

namespace MY_DVLD.Licenses.Controls
{
	public partial class UCDriverLicenses : UserControl
	{
		public UCDriverLicenses()
		{
			InitializeComponent();
		}
		//Lic.ID App.ID ClassName IssueDate ExpirationDate IsActive
		DataTable _dtLocalLiceses;
		DataTable _dtInternationalLicenes;
		int _PersonID;

		private void _LoadInternationalLicenses()
		{
			_dtInternationalLicenes = clsInternationalLicense.GetAllInternationalLicenseByPersonID(_PersonID);
			dgvInternationalLicensesHistory.DataSource = _dtInternationalLicenes;
			lblInternationalLicensesRecords.Text = dgvInternationalLicensesHistory.Rows.Count.ToString();


			if (dgvInternationalLicensesHistory.Rows.Count > 0)
			{
				dgvInternationalLicensesHistory.Columns[0].HeaderText = "Int.License ID";
				dgvInternationalLicensesHistory.Columns[0].Width = 160;

				dgvInternationalLicensesHistory.Columns[1].HeaderText = "Application ID";
				dgvInternationalLicensesHistory.Columns[1].Width = 130;

				dgvInternationalLicensesHistory.Columns[2].HeaderText = "L.License ID";
				dgvInternationalLicensesHistory.Columns[2].Width = 130;

				dgvInternationalLicensesHistory.Columns[3].HeaderText = "Issue Date";
				dgvInternationalLicensesHistory.Columns[3].Width = 180;

				dgvInternationalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
				dgvInternationalLicensesHistory.Columns[4].Width = 180;

				dgvInternationalLicensesHistory.Columns[5].HeaderText = "Is Active";
				dgvInternationalLicensesHistory.Columns[5].Width = 120;

			}
		}

		private void _LoadLocalLicenseInfo()
		{

			_dtLocalLiceses = clsLicense.GetAllLicensesByPersonID(_PersonID);


			dgvLocalLicensesHistory.DataSource = _dtLocalLiceses;
			lblLocalLicensesRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

			if (dgvLocalLicensesHistory.Rows.Count > 0)
			{
				dgvLocalLicensesHistory.Columns[0].HeaderText = "Lic.ID";
				dgvLocalLicensesHistory.Columns[0].Width = 110;

				dgvLocalLicensesHistory.Columns[1].HeaderText = "App.ID";
				dgvLocalLicensesHistory.Columns[1].Width = 110;

				dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
				dgvLocalLicensesHistory.Columns[2].Width = 270;

				dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
				dgvLocalLicensesHistory.Columns[3].Width = 170;

				dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
				dgvLocalLicensesHistory.Columns[4].Width = 170;

				dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
				dgvLocalLicensesHistory.Columns[5].Width = 110;

			}
		}


		public void LoadData(int PersonID)
		{
			_PersonID = PersonID;
			_LoadLocalLicenseInfo();
			_LoadInternationalLicenses();
		}


		public void Clear()
		{
			_dtLocalLiceses = null;
		}

	}
}
