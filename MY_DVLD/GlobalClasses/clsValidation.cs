using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MY_DVLD_GlobalClasses
{
	public class clsValidation
	{

		public static bool IsValidEmail(string Email)
		{
			var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
			var regex = new Regex(pattern);

			return regex.IsMatch(Email);
		}


		public static void ValidateControlRequired(object ob, CancelEventArgs e, ErrorProvider ErrorProvider, string ErrorMessage = "This Field Is Required")
		{
			Control control = ob as Control;
			if (string.IsNullOrWhiteSpace(control.Text))
			{
				ErrorProvider.SetError(control, ErrorMessage);
				e.Cancel = true;
			}

			else
			{
				ErrorProvider.SetError(control, null);
			

			}

		}


		public static bool IsValidFloat(string Num)
		{
			var pattern = @"^[0-9]*(?:\.[0-9]*)?$";
			var regex = new Regex(pattern);

			return regex.IsMatch(Num);

		}		
		public static bool IsValidInt(string Num)
		{
			var pattern = @"^[0-9]+$";
			var regex = new Regex(pattern);

			return regex.IsMatch(Num);

		}



	}
}
