using MY_DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using MY_DVLD.GlobalClasses;

namespace MY_DVLD.Users
{
	public partial class frmListUsers : Form
	{
		//UserId PersonID UserName FUllName IsActive
		DataTable _dtUsers = clsUser.GetAllUsers();

		public frmListUsers()
		{

			InitializeComponent();

		}

		void _IntializeFilterByIsActiveComboBox()
		{
			cbIsActive.Items.Add("True");
			cbIsActive.Items.Add("False");
			cbIsActive.Visible = false;
			cbIsActive.SelectedIndex = 0;
		}

		void _IntializeFilterByComboBox()
		{
			cbFilterBy.Items.Add("None");
			cbFilterBy.Items.Add("User ID");
			cbFilterBy.Items.Add("Person ID");
			cbFilterBy.Items.Add("User Name");
			cbFilterBy.Items.Add("Full Name");
			cbFilterBy.Items.Add("Is Active");

			cbFilterBy.SelectedIndex = 0;
		}

		void _IntializeDataGridView()
		{
			dgvListUsers.DataSource = _dtUsers;

			dgvListUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvListUsers.AllowUserToResizeColumns = true;
			// Then adjust key columns

			dgvListUsers.Columns["UserID"].FillWeight = 40;
			dgvListUsers.Columns["PersonID"].FillWeight = 40;
			dgvListUsers.Columns["UserName"].FillWeight = 50;
			dgvListUsers.Columns["FullName"].FillWeight = 150;
			dgvListUsers.Columns["IsActive"].FillWeight = 20;

		}

		void frmListUsers_Load(object sender, EventArgs e)
		{
			_IntializeFilterByComboBox();

			_IntializeDataGridView();

			_IntializeFilterByIsActiveComboBox();

			_RefreshData();

			txtFilterValue.Visible = false;
		}

		void _RefreshData()
		{
			_dtUsers = clsUser.GetAllUsers();

			dgvListUsers.DataSource = _dtUsers;

			_ApplyUserFilter();
		}

		string _GetFilterByTrimmedString()
		{
			string SelectedText = cbFilterBy.SelectedItem?.ToString();

			string SelectedTextTrimmed = clsUtil.TrimSpaces(SelectedText);

			return SelectedTextTrimmed;
		}

		void _SetFilterControlsVisibility(string SelectedFilterTrimmed)
		{
			txtFilterValue.Visible = !(SelectedFilterTrimmed == "None" || SelectedFilterTrimmed == "IsActive");
			cbIsActive.Visible = (SelectedFilterTrimmed == "IsActive");
		}

		void _UpdateRecordNo()
		{
			lbRecordsNo.Text = $"RecordsNo: {dgvListUsers.Rows.Count}";
		}

		private void _ApplyUserFilter()
		{
			string SelectedFilter = cbFilterBy.SelectedItem?.ToString();

			if (SelectedFilter == null)
				return;

			string SelectedFilterTrimmed = _GetFilterByTrimmedString();
			string UserInputString = txtFilterValue.Text.Trim();
			string UserInputIsActiveString = cbIsActive.SelectedItem?.ToString();

			_SetFilterControlsVisibility(SelectedFilterTrimmed);

			bool IsNoneFilter = (SelectedFilterTrimmed == "None");
			bool IsValueEmptyAndNotIsActive = (UserInputString == "" && SelectedFilterTrimmed != "IsActive");

			if (IsNoneFilter || IsValueEmptyAndNotIsActive)
			{
				_dtUsers.DefaultView.RowFilter = "";
				_UpdateRecordNo();
				return;
			}



			switch (SelectedFilterTrimmed)
			{
				case "UserID":
				case "PersonID":
					_dtUsers.DefaultView.RowFilter = $"[{SelectedFilterTrimmed}]={UserInputString}";
					break;

				case "IsActive":
					_dtUsers.DefaultView.RowFilter = $"[{SelectedFilterTrimmed}]={UserInputIsActiveString}";
					break;


				default:
					_dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", SelectedFilterTrimmed, UserInputString);
					break;
			}

			_UpdateRecordNo();
		}

		private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void pbRefresh_Click(object sender, EventArgs e)
		{
			_RefreshData();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AnyChangestoFilters(object sender, EventArgs e)
		{
			_ApplyUserFilter();
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			frmAddUpdateUser frm = new frmAddUpdateUser();
			frm.ShowDialog();
			_RefreshData();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
			frmAddUpdateUser frm = new frmAddUpdateUser(UserID);
			frm.ShowDialog();

			_RefreshData();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;


			if (MessageBox.Show("Are You Sure ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				if (clsUser.DeleteUser(UserID))
				{
					MessageBox.Show("Deleted Succefully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				else
					MessageBox.Show($"Error Deleting User With UserID:{UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}




		}

		private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdateUser frm = new frmAddUpdateUser();
			frm.ShowDialog();
			_RefreshData();
		}

		private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
			frmShowUserDetails frm = new frmShowUserDetails(UserID);
			frm.ShowDialog();
		}

		private void toolStripChangePasswordMenuItem_Click(object sender, EventArgs e)
		{
			int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;
			frmChangeUserPassword frm = new frmChangeUserPassword(UserID);
			frm.ShowDialog();
		}
	}
}

