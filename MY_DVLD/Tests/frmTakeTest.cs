using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MY_DVLD_Business;
using System.Windows.Forms;
using MY_DVLD.GlobalClasses;

namespace MY_DVLD.Tests
{
	public partial class frmTakeTest : Form
	{
		int _AppointmentID;
		int _TestID;
		int _LDLID;
		clsTestType.enTestType _TestType;
		clsTest _Test;


		public frmTakeTest(int LDLID, clsTestType.enTestType TestType, int AppointmentID)
		{
			InitializeComponent();
			_LDLID = LDLID;
			_TestType = TestType;
			_AppointmentID = AppointmentID;
		}



		private void btnSave_Click(object sender, EventArgs e)
		{
			bool Result = (rbPass.Checked);
			string Notes = txtNotes.Text.Trim();


			_Test.Notes = Notes;
			_Test.TestResult = Result;
			_Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;
			_Test.TestAppointmentID = _AppointmentID;
			if (_Test.Save())
				MessageBox.Show("Test Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show($"Unable To Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			this.Close();


		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmTakeTest_Load(object sender, EventArgs e)
		{
			ucSecheduleTestInfo1.LoadData(_LDLID, _TestType, _AppointmentID);
			int TestID = clsTest.GetTestIDForTestAppointment(_AppointmentID);

			//if test is taken prevent changing results
			if (TestID != -1)
			{
				_Test = clsTest.FindTestByID(TestID);

				btnSave.Enabled = false;
				gbTestInfo.Enabled = false;
				lblUserMessage.Visible = true;

			}
			else
				_Test = new clsTest();

		}
	}
}
