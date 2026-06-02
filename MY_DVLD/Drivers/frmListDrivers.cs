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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.Drivers
{
	public partial class frmListDrivers : Form
	{
		public frmListDrivers()
		{
			InitializeComponent();
		}

		DataTable _dtDrivers = clsDriver.GetAllDrivers();

		private void frmListDrivers_Load(object sender, EventArgs e)
		{
			_RefreshData();
			_IntializeDataGridView();
			_IntializeFilterByComboBox();
		}
		private void _IntializeFilterByComboBox()
		{
			cbFilterBy.Items.Add("None");
			cbFilterBy.Items.Add("DriverID");
			cbFilterBy.Items.Add("PersonID");
			cbFilterBy.Items.Add("National No");
			cbFilterBy.Items.Add("FullName");

			cbFilterBy.SelectedIndex = 0;
		}

		private void _IntializeDataGridView()
		{
			if (dgvDrivers.RowCount <= 0)
				return;

			//Database== DriverID PersonID NationalNo FullName  CreatedDate ActiveLicensesNo
			//Filter == DriverID PersonID National No FullName  CreatedDate NoActiveLicenses
			//dgv == 
			var columnSettings = new[]
			{
			new { Name = "DriverID",                  Header = "DriverID", Weight = 30  },
			new { Name = "PersonID",                  Header = "PersonID",       Weight = 30  },
			new { Name = "NationalNo",                Header = "National No", Weight = 40 },
			new { Name = "FullName",                  Header = "FullName",        Weight = 110  },
			new { Name = "CreatedDate",               Header = "Created Date", Weight = 50 },
			new { Name = "ActiveLicensesNo",          Header = "Active Licenses No", Weight = 30 }

			};

			foreach (var col in columnSettings)
			{
				var column = dgvDrivers.Columns[col.Name];
				column.HeaderText = col.Header;
				column.FillWeight = col.Weight;
			}

			dgvDrivers.DataSource = _dtDrivers;

			dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDrivers.AllowUserToResizeColumns = true;

		}

		private void _UpdateRecordsNo()
		{
			lbRecordsNO.Text = dgvDrivers.RowCount.ToString();
		}

		private void _RefreshData()
		{
			_dtDrivers = clsDriver.GetAllDrivers();
			//ReAssign DataGridView Instance to The New DataTable
			dgvDrivers.DataSource = _dtDrivers;
			_UpdateRecordsNo();
		}




		string _GetFilterByTrimmedString()
		{
			string SelectedText = cbFilterBy.SelectedItem?.ToString();
			//Database== DriverID PersonID NationalNo FullName  CreatedDate ActiveLicensesNo
			//Filter == DriverID PersonID National No FullName  CreatedDate NoActiveLicenses
			//dgv == 

			string SelectedTextTrimmed = clsUtil.TrimSpaces(SelectedText);

			return SelectedTextTrimmed;
		}

		void _SetFilterControlsVisibility(string SelectedFilterTrimmed)
		{
			txtFilterValue.Visible = !(SelectedFilterTrimmed == "None");
		}

		private void _ApplyUserFilter()
		{
			string SelectedFilter = cbFilterBy.SelectedItem?.ToString();

			if (SelectedFilter == null)
				return;

			SelectedFilter = _GetFilterByTrimmedString();
			string UserInputString = txtFilterValue.Text.Trim();

			_SetFilterControlsVisibility(SelectedFilter);


			bool IsValueEmptyORNone = (UserInputString == "" || SelectedFilter == "None");

			if (IsValueEmptyORNone)
			{
				_dtDrivers.DefaultView.RowFilter = "";
				_UpdateRecordsNo();
				return;
			}

			switch (SelectedFilter)
			{
				case "DriverID":
				case "PersonID":
					_dtDrivers.DefaultView.RowFilter = $"[{SelectedFilter}]={UserInputString}";
					break;

				default:
					_dtDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", SelectedFilter, UserInputString);
					break;
			}

			_UpdateRecordsNo();
		}

		private void _ApplyUserFilter(object sender, EventArgs e)
		{
			_ApplyUserFilter();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ShowPersonInfo_Click(object sender, EventArgs e)
		{
			int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;
			frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
			frm.ShowDialog();

		}

		private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;
			frmShowDrivingLicenseHistory frm = new frmShowDrivingLicenseHistory(PersonID);
			frm.ShowDialog();
		}
	}
}
