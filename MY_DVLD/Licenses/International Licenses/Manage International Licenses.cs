using MY_DVLD.GlobalClasses;
using MY_DVLD.People;
using MY_DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MY_DVLD.Licenses.International_Licenses
{
	public partial class frmManageInternationalLicenseApplications : Form
	{
		public frmManageInternationalLicenseApplications()
		{
			InitializeComponent();
		}

		DataTable _dtInternationalLiceseApplications;
		private void frmManageInternationalLicenseApplications_Load(object sender, EventArgs e)
		{
			_RefreshData();
			_IntializeDataGridView();
			_IntializeComboBoxes();
		}


		private void _UpdateRecordsNo()
		{
			lblTotalRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
		}

		string _GetFilterByTrimmedString(string Text)
		{
			if (Text == "Local License ID")
				Text = "IssuedUsingLocalLicenseID";

			return clsUtil.TrimSpaces(Text);

		}

		void _SetFilterControlsVisibility(string SelectedFilterTrimmed)
		{
			txtFilterValue.Visible = !(SelectedFilterTrimmed == "None") && !(SelectedFilterTrimmed == "IsActive");
			cbIsActive.Visible = (SelectedFilterTrimmed == "IsActive");
		}

		private void _ApplyUserFilter()
		{
			//InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID IsActive

			string SelectedFilter = _GetFilterByTrimmedString(cbFilterBy.SelectedItem?.ToString());

			if (SelectedFilter == null)
				return;

			string UserInputString = txtFilterValue.Text.Trim();

			_SetFilterControlsVisibility(SelectedFilter);

			bool IsValueEmptyORNone = (UserInputString == "" || SelectedFilter == "None") && (SelectedFilter != "IsActive");

			if (IsValueEmptyORNone)
			{
				_dtInternationalLiceseApplications.DefaultView.RowFilter = "";
				_UpdateRecordsNo();
				return;
			}


			switch (SelectedFilter)
			{

				case "IsActive":
					string CbSelected = cbIsActive.Text.Trim();
					if (CbSelected == "All")
					{
						_dtInternationalLiceseApplications.DefaultView.RowFilter = "";
					}
					else if (CbSelected == "Yes")
					{
						_dtInternationalLiceseApplications.DefaultView.RowFilter = "[IsActive] = true";
					}
					else if (CbSelected == "No")
					{
						_dtInternationalLiceseApplications.DefaultView.RowFilter = "[IsActive] = false";
					}

					break;

				//CaseAnyID
				default:
					_dtInternationalLiceseApplications.DefaultView.RowFilter = $"[{SelectedFilter}]={UserInputString}";
					break;
			}

			_UpdateRecordsNo();
		}

		private void _IntializeComboBoxes()
		{

			/*
				None
				International License ID
				Application ID
				Driver ID
				Local License ID
				Is Active

			*/

			//InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID IsActive

			cbFilterBy.Items.Add("None");
			cbFilterBy.Items.Add("International License ID");
			cbFilterBy.Items.Add("Application ID");
			cbFilterBy.Items.Add("Driver ID");
			cbFilterBy.Items.Add("Local License ID");
			cbFilterBy.Items.Add("Is Active");
			cbFilterBy.SelectedIndex = 0;

			cbIsActive.Items.Add("All");
			cbIsActive.Items.Add("Yes");
			cbIsActive.Items.Add("No");
			cbIsActive.SelectedIndex = 0;
		}

		private void _IntializeDataGridView()
		{
			_dtInternationalLiceseApplications = clsInternationalLicense.GetAllInternationalLicensesBasicInfo();

			dgvInternationalLicenses.DataSource = _dtInternationalLiceseApplications;
			_UpdateRecordsNo();

			if (dgvInternationalLicenses.Rows.Count > 0)
			{
				if (dgvInternationalLicenses.Rows.Count > 0)
				{
					dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
					dgvInternationalLicenses.Columns[0].Width = 160;

					dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
					dgvInternationalLicenses.Columns[1].Width = 150;

					dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
					dgvInternationalLicenses.Columns[2].Width = 130;

					dgvInternationalLicenses.Columns[3].HeaderText = "L.License ID";
					dgvInternationalLicenses.Columns[3].Width = 130;

					dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
					dgvInternationalLicenses.Columns[4].Width = 180;

					dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
					dgvInternationalLicenses.Columns[5].Width = 180;

					dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
					dgvInternationalLicenses.Columns[6].Width = 120;

				}
			}
		}

		private void _RefreshData()
		{
			_dtInternationalLiceseApplications = clsInternationalLicense.GetAllInternationalLicensesBasicInfo();

			dgvInternationalLicenses.DataSource = _dtInternationalLiceseApplications;

			_UpdateRecordsNo();
		}

		private void ChangeFilter(object sender, EventArgs e)
		{
			_ApplyUserFilter();
		}



		private void showLicenseDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			int InLicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;

			frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(InLicenseID);
			frm.ShowDialog();
		}

		private void PesonDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			int InLicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;
			clsInternationalLicense InLicense = clsInternationalLicense.FindInternationalLicenseByID(InLicenseID);
			frmShowPersonInfo frm = new frmShowPersonInfo(InLicense.DriverInfo.PersonID);
			frm.ShowDialog();
		}

		private void showPersonLicenseHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			int InLicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;
			clsInternationalLicense InLicense = clsInternationalLicense.FindInternationalLicenseByID(InLicenseID);
			frmShowPersonDrivingLicenseHistory frm = new frmShowPersonDrivingLicenseHistory(InLicense.DriverInfo.PersonID);
			frm.ShowDialog();
		}
	}
}
