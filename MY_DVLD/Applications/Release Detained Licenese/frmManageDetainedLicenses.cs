using MY_DVLD.GlobalClasses;
using MY_DVLD.Licenses;
using MY_DVLD.People;
using MY_DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Applications.Detain_and_Release_License
{
	public partial class frmManageDetainedLicenses : Form
	{
		public frmManageDetainedLicenses()
		{
			InitializeComponent();
		}


		DataTable _dtDetainedLicenses;
		private void cmsApplications_Opening(object sender, CancelEventArgs e)
		{

		}

		private void PesonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string NationalNo = (string)dgvDetainedLicenses.CurrentRow.Cells[6].Value;
			frmShowPersonInfo frm = new frmShowPersonInfo(NationalNo);
			frm.ShowDialog();
		}

		private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
			clsLicense License = clsLicense.FindLicenseByID(LicenseID);
			frmShowPersonDrivingLicenseHistory frm = new frmShowPersonDrivingLicenseHistory(License.ApplicationInfo.ApplicantPersonID);
			frm.ShowDialog();
		}

		private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
		{

		}

		private void btnDetainLicense_Click(object sender, EventArgs e)
		{
			frmDetainLicense frm = new frmDetainLicense();
			frm.ShowDialog();
			_RefreshData();
		}


		private void _UpdateRecordsNo()
		{
			lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
		}

		string _GetFilterByTrimmedString(string Text)
		{


			string SelectedTextTrimmed = clsUtil.TrimSpaces(Text);

			return SelectedTextTrimmed;
		}

		void _SetFilterControlsVisibility(string SelectedFilterTrimmed)
		{
			txtFilterValue.Visible = !(SelectedFilterTrimmed == "None") && !(SelectedFilterTrimmed == "IsReleased");
			cbIsReleased.Visible = (SelectedFilterTrimmed == "IsReleased");
		}

		private void _ApplyUserFilter()
		{
			string SelectedFilter = _GetFilterByTrimmedString(cbFilterBy.SelectedItem?.ToString());

			if (SelectedFilter == null)
				return;

			string UserInputString = txtFilterValue.Text.Trim();

			_SetFilterControlsVisibility(SelectedFilter);


			bool IsValueEmptyORNone = (UserInputString == "" || SelectedFilter == "None") && (SelectedFilter != "IsReleased");


			if (IsValueEmptyORNone)
			{
				_dtDetainedLicenses.DefaultView.RowFilter = "";
				_UpdateRecordsNo();
				return;
			}


			switch (SelectedFilter)
			{
				case "DetainID":
				case "Release Application ID":
					_dtDetainedLicenses.DefaultView.RowFilter = $"[{SelectedFilter}]={UserInputString}";
					break;

				case "IsReleased":
					string CbSelected = cbIsReleased.Text.Trim();
					if (CbSelected == "All")
					{
						_dtDetainedLicenses.DefaultView.RowFilter = "";
					}
					else if (CbSelected == "Yes")
					{
						_dtDetainedLicenses.DefaultView.RowFilter = "[IsReleased] = true";
					}
					else if (CbSelected == "No")
					{
						_dtDetainedLicenses.DefaultView.RowFilter = "[IsReleased] = false";
					}

					break;


				default:
					_dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", SelectedFilter, UserInputString);
					break;
			}

			_UpdateRecordsNo();
		}

		private void _IntializeComboBoxes()
		{
			cbFilterBy.Items.Add("None");
			cbFilterBy.Items.Add("Detain ID");
			cbFilterBy.Items.Add("Is Released");
			cbFilterBy.Items.Add("National No");
			cbFilterBy.Items.Add("Full Name");
			cbFilterBy.Items.Add("Release Application ID");
			cbFilterBy.SelectedIndex = 0;

			cbIsReleased.Items.Add("All");
			cbIsReleased.Items.Add("Yes");
			cbIsReleased.Items.Add("No");
			cbIsReleased.SelectedIndex = 0;
		}

		private void _IntializeDataGridView()
		{
			_dtDetainedLicenses = clsDetainedLicense.GetDetainedLicenseWithData();

			dgvDetainedLicenses.DataSource = _dtDetainedLicenses;
			_UpdateRecordsNo();

			if (dgvDetainedLicenses.Rows.Count > 0)
			{
				dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
				dgvDetainedLicenses.Columns[0].Width = 90;

				dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
				dgvDetainedLicenses.Columns[1].Width = 90;

				dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
				dgvDetainedLicenses.Columns[2].Width = 160;

				dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
				dgvDetainedLicenses.Columns[3].Width = 110;

				dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
				dgvDetainedLicenses.Columns[4].Width = 110;

				dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
				dgvDetainedLicenses.Columns[5].Width = 160;

				dgvDetainedLicenses.Columns[6].HeaderText = "N.No.";
				dgvDetainedLicenses.Columns[6].Width = 90;

				dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
				dgvDetainedLicenses.Columns[7].Width = 330;

				dgvDetainedLicenses.Columns[8].HeaderText = "Rlease App.ID";
				dgvDetainedLicenses.Columns[8].Width = 150;

			}
		}

		private void _RefreshData()
		{
			_dtDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();

			dgvDetainedLicenses.DataSource = _dtDetainedLicenses;

			_UpdateRecordsNo();
		}

		private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
		{
			_IntializeDataGridView();
			_IntializeComboBoxes();
		}

		private void txtFilterValue_TextChanged(object sender, EventArgs e)
		{
			_ApplyUserFilter();
		}

		private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			_ApplyUserFilter();

		}

		private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
		{
			_ApplyUserFilter();

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
