using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using signUp.BL;

namespace signUp.DL
{
    class medicalDL
    {
        private static List<medicalBL> m = new List<medicalBL>();

        internal static List<medicalBL> M { get => m; set => m = value; }
		public static void addIntoMedicalList(medicalBL data, int idx)
		{
			CredentialDL.SignUpdata[idx].SeparateDataListForMedical.Add(data);

		}
		public static void medicalStoreData(medicalBL data)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\MedicalData.txt";
			StreamWriter file = new StreamWriter(path1 , true);
			file.WriteLine( CredentialDL.idx +"?" +data.Date + "?" + data.Group + "?" + data.Disease );
			file.Flush();
			file.Close();
		}
		public static void AllmedicalStoreData(medicalBL data)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\AllMedicalData.txt";
			StreamWriter file = new StreamWriter(path1, true);
			file.WriteLine( data.Date + "?" + data.Group + "?" + data.Disease);
			file.Flush();
			file.Close();
		}
		public static bool AllmedicalReadData()
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\AllMedicalData.txt";
			StreamReader file = new StreamReader(path1);
			string record;
			if (File.Exists(path1))
			{
				while ((record = file.ReadLine()) != null)
				{
					    string[] splittedRecord = record.Split('?');
						string date = splittedRecord[0];
						string group = splittedRecord[1];
						string disease = splittedRecord[2];
						medicalBL data = new medicalBL(date, group, disease);
						medicalDL.M.Add(data);
					
				}
				file.Close();
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool medicalReadData(int idx)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\MedicalData.txt";
			StreamReader file = new StreamReader(path1);
			string record;
			if (File.Exists(path1))
			{
				while ((record = file.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split('?');
					int TempIndex = int.Parse(splittedRecord[0]);
					if (TempIndex == CredentialDL.idx)
					{
						string date = splittedRecord[1];
						string group = splittedRecord[2];
						string disease = splittedRecord[3];

						medicalBL data = new medicalBL(date, group, disease);
						CredentialDL.SignUpdata[idx].SeparateDataListForMedical.Add(data);
					}
				}
				file.Close();
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
