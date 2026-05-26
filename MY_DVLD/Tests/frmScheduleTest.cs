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

namespace MY_DVLD.Tests
{
	public partial class frmScheduleTest : Form
	{


		clsTestType.enTestType _TestType;
		int _LDLAppID;
		int _TestAppointmentID;



		public frmScheduleTest(int LDLAppID, clsTestType.enTestType testType, int TestAppointment = -1)
		{
			InitializeComponent();
			_LDLAppID = LDLAppID;
			_TestType = testType;
			_TestAppointmentID = TestAppointment;
		}

		private void frmScheduleTest_Load(object sender, EventArgs e)
		{
			ucScheduleTest1.TestType = _TestType;
			ucScheduleTest1.LoadData(_LDLAppID, _TestAppointmentID);
		}
	}
}
