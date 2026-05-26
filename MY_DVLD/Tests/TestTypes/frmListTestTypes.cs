using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MY_DVLD.Applications.Application_Types;
using MY_DVLD_Business;
namespace MY_DVLD.Tests.TestTypes
{
	public partial class frmListTestTypes : Form
	{
		public frmListTestTypes()
		{
			InitializeComponent();
		}

		DataTable _dtTestTypes = clsTestType.GetAllTestTypes();

		private void _IntializeDataGridView()
		{
			dgvTestTypes.DataSource = _dtTestTypes;

			dgvTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvTestTypes.AllowUserToResizeColumns = true;

			//dgvTestTypes.Columns.Clear();

			dgvTestTypes.Columns["TestTypeID"].HeaderText = "ID";
			dgvTestTypes.Columns["TestTypeID"].FillWeight = 20;

			dgvTestTypes.Columns["TestTypeTitle"].HeaderText = "Title";
			dgvTestTypes.Columns["TestTypeTitle"].FillWeight = 70;

			dgvTestTypes.Columns["TestTypeDescription"].HeaderText = "Description";
			dgvTestTypes.Columns["TestTypeDescription"].FillWeight = 150;

			dgvTestTypes.Columns["TestTypeFees"].HeaderText = "Fees";
			dgvTestTypes.Columns["TestTypeFees"].FillWeight = 30;


		}


		private void _UpdateRecordsNo()
		{
			lbRecordsNo.Text = dgvTestTypes.RowCount.ToString();
		}


		private void _RefreshData()
		{
			_dtTestTypes = clsTestType.GetAllTestTypes();
			//ReAssign DataGridView Instance to The New DataTable
			dgvTestTypes.DataSource = _dtTestTypes;
			_UpdateRecordsNo();
		}


		private void frmManageTestTypes_Load(object sender, EventArgs e)
		{
			_IntializeDataGridView();
			_RefreshData();
		}

		private void editToolStripTestTypeEditClick(object sender, EventArgs e)
		{

			clsTestType.enTestType TestTypeID = (clsTestType.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value;

			frmEditTestType frm = new frmEditTestType(TestTypeID);
			frm.ShowDialog();

			_RefreshData();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

}

