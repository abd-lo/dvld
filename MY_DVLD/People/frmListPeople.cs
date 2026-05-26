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

namespace MY_DVLD.People
{
	public partial class frmListPeople : Form
	{
		/*
	  P.PersonID, P.NationalNo, P.FirstName, P.SecondName, P.ThirdName, P.LastName,P.DateOfBirth, 

	P.Gender, P.Address, P.Phone, P.Email, P.NationalityCountryID, C.CountryName, P.ImagePath
	*/

		/*
		PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,DateOfBirth, 

		Gender, Address, Phone, Email, NationalityCountryID, C.CountryName, ImagePath
		*/

		static DataTable _dtPeople;
		DataTable _dtPeopleSelectedColumns;



		public frmListPeople()
		{
			InitializeComponent();

		}

		private void frmListPeople_Load(object sender, EventArgs e)
		{
			_RefreshData();
			cbFilterBy.SelectedIndex = 0;

		}

		private void _RefreshData()
		{
			_dtPeople = clsPerson.GetAllPersons();

			_dtPeopleSelectedColumns = _dtPeople.DefaultView.ToTable(false, "PersonID",
			"NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "DateOfBirth",
		   "Gender", "Address", "Phone", "Email", "CountryName");

			dgvListPersons.DataSource = _dtPeopleSelectedColumns;

			lbRecordsNo.Text = $"RecordsNo: {dgvListPersons.Rows.Count}";


			_ChangeFilter();
		}

		private string _GetFilterByString()
		{
			string SelectedTextTrimmed;
			string SelectedText = cbFilterBy.SelectedItem?.ToString();

			SelectedTextTrimmed = Regex.Replace(SelectedText, @"\s+", "");
			if (SelectedTextTrimmed == "Nationality")
				SelectedTextTrimmed = "CountryName";
			/*
			switch (Selected)
			{
				
				case "Person ID":

					FilterByString = "PersonID";

					break;

				case "First Name":
					FilterByString = "FirstName";
					break;

				case "Second Name":
					FilterByString = "SecondName";
					break;

				case "Third Name":
					FilterByString = "ThirdName";
					break;

				case "Gender":

					FilterByString = "Gender";

					break;

				case "Nationality":
					FilterByString = "Nationality";
					break;



				case "Phone":
					FilterByString = "Phone";
					break;



				case "Email":
					FilterByString = "Email";
					break;

				case "National No":
					FilterByString = "NationalNo";
					break;


				default:
					FilterByString = "None";
					break;

			}
			*/


			return SelectedTextTrimmed;
		}
		private void _ChangeFilter()
		{
			if (cbFilterBy.SelectedItem == null)
				return;

			txtFilterValue.Visible = (cbFilterBy.SelectedItem.ToString() != "None");

			string FilterColumn = _GetFilterByString();

			if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
			{
				_dtPeopleSelectedColumns.DefaultView.RowFilter = "";
				lbRecordsNo.Text = $"RecordsNo: {dgvListPersons.Rows.Count}";
				return;
			}


			if (FilterColumn == "PersonID")
				//in this case we deal with integer not string.

				_dtPeopleSelectedColumns.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());

			else
				_dtPeopleSelectedColumns.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());


			lbRecordsNo.Text = $"RecordsNo: {dgvListPersons.Rows.Count}";
		}

		private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			_ChangeFilter();
		}
		private void txtFilterValue_TextChanged(object sender, EventArgs e)
		{
			_ChangeFilter();

		}


		private void btnAddPerson_Click(object sender, EventArgs e)
		{
			frmAddUpdatePerson frmAddEditPerson = new frmAddUpdatePerson();
			frmAddEditPerson.ShowDialog();
			_RefreshData();

		}

		private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (cbFilterBy.Text == "Person ID")
				e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}


		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmAddUpdatePerson frm = new frmAddUpdatePerson((int)dgvListPersons.CurrentRow.Cells[0].Value);
			frm.ShowDialog();

			_RefreshData();
			_ChangeFilter();
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			frmAddUpdatePerson frmAddEditPerson = new frmAddUpdatePerson();
			frmAddEditPerson.ShowDialog();
			_RefreshData();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			_RefreshData();

		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete Person [" + dgvListPersons.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

			{

				//Perform Delele and refresh
				if (clsPerson.Delete((int)dgvListPersons.CurrentRow.Cells[0].Value))
				{
					MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					_RefreshData();
				}

				else
					MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			_RefreshData();
		}

		private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvListPersons.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
		}

		private void dgvListPersons_DoubleClick(object sender, EventArgs e)
		{
			frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvListPersons.CurrentRow.Cells[0].Value);
			frm.ShowDialog();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

