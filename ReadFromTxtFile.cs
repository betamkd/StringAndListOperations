using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace StringAndListOperations
{
	public class ReadFromTxtFile
	{	
		public string ReadFromFile()
		{
		
			string folderName = "EmailTemplates";
			string filename = "emailTemplate.txt";

			string currentDirectory = Directory.GetCurrentDirectory();


			string projectBinDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
			string projectDirectoryName = Directory.GetParent(projectBinDirectory).Parent.Name; // "StringAndListOperations"
			//string projectDirectory = Directory.GetParent(projectBinDirectory).Parent.FullName;
			string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

			// string test = "C:\\Users\\Filip.Gjurcheski\\Desktop\\.NET Academy\\StringAndListOperations\\EmailTemplates\\EmailTemplate.txt";
			//	current directory		"C:\\Users\\Filip.Gjurcheski\\Desktop\\.NET Academy\\StringAndListOperations \\bin\\Debug\\net7.0";
			//	projectBinDirectory		"C:\\Users\\Filip.Gjurcheski\\Desktop\\.NET Academy\\StringAndListOperations\\bin"
			//	projectDirectory		"C:\\Users\\Filip.Gjurcheski\\Desktop\\.NET Academy\\StringAndListOperations\\"


			//  "C:\\Users\\Filip.Gjurcheski\\Desktop\\.NET Academy\\StringAndListOperations\\EmailTemplates\\emailTemplate.txt" LOCATION OF THE DOCUMENT
			//  "C:\\Users\\ilip.Gjurcheski\\Desktop\\.NET Academy\\StringAndListOperations\\EmailTemplates\\emailTemplate.txt"

			// "C:\\Users\\Filip.Gjurcheski\\Desktop\\.NET Academy\\StringAndListOperations\\EmailTemplates + "\\
			//  projectDirectory + ProjectDirectoryName + folderName + fileName

			string text = "";

			//*** relative path ***
			//example StringandOperations\\EmailTemplates\\a\\b 

			//mora redosledno da se pishuvaat
			string filePath = Path.Combine(projectDirectoryName, projectDirectory, folderName, filename);


			try
			{
				using (StreamReader sr = new StreamReader(filePath))
				{
					text = sr.ReadToEnd();
				}
			}
			catch (IOException ex)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("File cannot be read");
				Console.WriteLine(ex.Message);
				Console.ResetColor();
			
			}

			return text;
		}
	}
}
