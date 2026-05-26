using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_DVLD.GlobalClasses
{
	public class clsUtil
	{
		static string _DefaultSavingLocation = @"C:\DVLDPeopleImages\";

		public static string GenerateGUID()
		{

			// Generate a new GUID
			Guid newGuid = Guid.NewGuid();

			// convert the GUID to a string
			return newGuid.ToString();

		}

		public static bool CreateFolder(string FolderPath)
		{
			if (!Directory.Exists(FolderPath))
			{
				try
				{
					Directory.CreateDirectory(FolderPath);
					return true;
				}


				catch (Exception ex)
				{
					MessageBox.Show("Error Creating Folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

					return false;
				}

			}
			return true;
		}

		public static string GetGuidFileName(string SourceFile)
		{
			string FileName = SourceFile;

			FileInfo F_I = new FileInfo(FileName);

			return GenerateGUID() + F_I.Extension;
		}

		public static (bool Success, string DestinationFilePath) CopyImageFile(string SourceFile, string UserInputPath = null)
		{
			string SavingPath = UserInputPath ?? _DefaultSavingLocation;

			string GuidImageName = GetGuidFileName(SourceFile);

			string DestinationFilePath = SavingPath + GuidImageName;

			//if we can't make a folder
			if (!CreateFolder(SavingPath))
			{
				return (false, null);
			}

			try
			{
				File.Copy(SourceFile, DestinationFilePath, true);
				return (true, DestinationFilePath);
			}


			catch (Exception ex)
			{
				MessageBox.Show("Error Copying New Image" + ex);
				return (false, null);
			}
		}


		public static string TrimSpaces(string Input)
		{
			string Output=Regex.Replace(Input, @"\s+", "");
			return Output;
		}



	}
}
