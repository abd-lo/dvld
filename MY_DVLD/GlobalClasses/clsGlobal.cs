using MY_DVLD_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.IO;

namespace MY_DVLD.GlobalClasses
{
	public class clsGlobal
	{
		public static clsUser CurrentUser { set; get; }

		public static bool GetStoredCredential(ref string Username, ref string Password)
		{

			try
			{
				string ProjectFolderPath = System.IO.Directory.GetCurrentDirectory();
				string FilePath = ProjectFolderPath + @"\User.txt";

				if (!File.Exists(FilePath))
					return false;

				string content = File.ReadAllText(FilePath);
				string[] parts = content.Split(new string[] { "##//##" }, StringSplitOptions.None);

				Username = parts[0];
				Password = parts[1];
				if (Username == "")
					return false;
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error Getting Stored Credentials \n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}



			return true;
		}

		public static bool SetStoredCredential(string Username, string Password)
		{
			try
			{
				string ProjectFolderPath = System.IO.Directory.GetCurrentDirectory();
				string FilePath = ProjectFolderPath + @"\User.txt";


				if (Username == "" && File.Exists(FilePath))
				{
					File.Delete(FilePath);
					return true;
				}

				string InfoLine = $"{Username}##//##{Password}";

				File.WriteAllText(FilePath, InfoLine);
				return true;


			}


			catch (Exception ex)
			{

				MessageBox.Show("Error Writing to file\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		public static bool ClearStoredCredential()
		{
			try
			{
				string ProjectFolderPath = System.IO.Directory.GetCurrentDirectory();
				string FilePath = ProjectFolderPath + @"\User.txt";

				if (File.Exists(FilePath))
					File.Delete(FilePath);
			}

			catch (Exception ex)
			{
				MessageBox.Show("Error Clearing Credential\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}


			return true;
		}
	}






}

