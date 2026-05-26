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
using MY_DVLD_Business;
using MY_DVLD.Applications.Application_Types;

namespace MY_DVLD.Applications.Application_Types
{
	public partial class frmListApplicationTypes : Form
	{
		public frmListApplicationTypes()
		{
			InitializeComponent();
		}

		DataTable _dtTypes = clsApplicationType.GetAllApplicationTypes();



		private void _IntializeDataGridView()
		{
			dgvApplicationTypes.DataSource = _dtTypes;

			dgvApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvApplicationTypes.AllowUserToResizeColumns = true;

			dgvApplicationTypes.Columns["ApplicationTypeID"].FillWeight = 30;
			dgvApplicationTypes.Columns["ApplicationTypeTitle"].FillWeight = 100;
			dgvApplicationTypes.Columns["ApplicationFees"].FillWeight = 30;

		}

		private void _UpdateRecordsNo()
		{
			lbRecordsNo.Text = dgvApplicationTypes.RowCount.ToString();
		}
		private void _RefreshData()
		{
			_dtTypes = clsApplicationType.GetAllApplicationTypes();
			//ReAssign DataGridView Instance to The New DataTable
			dgvApplicationTypes.DataSource = _dtTypes;
			_UpdateRecordsNo();
		}
		private void frmManageApplicationTypes_Load(object sender, EventArgs e)
		{
			_IntializeDataGridView();
			_RefreshData();
		}

		private void editToolStripApplicationEditClick(object sender, EventArgs e)
		{

			int ApplicationTypeID = (int)dgvApplicationTypes.CurrentRow.Cells[0].Value;
			frmEditApplicationType frm = new frmEditApplicationType(ApplicationTypeID);
			frm.ShowDialog();

			_RefreshData();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

