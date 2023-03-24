using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using signUp.BL;

namespace signUp.DL
{
    class personalDL
    {
        private static List<personalBL> p = new List<personalBL>();

        internal static List<personalBL> P { get => p; set => p = value; }
		public static void addIntoList(personalBL data , int idx)
        {
			CredentialDL.SignUpdata[idx].SeparateDataList.Add(data);

		}

		public static void PersonalStoreData(personalBL data)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\PersonalData.txt";
			StreamWriter file = new StreamWriter(path1,true);
			file.WriteLine(CredentialDL.idx + "," + data.Name + "," + data.Fname + "," + data.Gender );
			file.Flush();
			file.Close();
		}

		public static bool PersonalReadData(int idx)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\PersonalData.txt";
			StreamReader file = new StreamReader(path1);
			string record;
			if (File.Exists(path1))
			{
				while ((record = file.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split(',');
					int TempIndex = 0;
					if (splittedRecord[0] != "")
					{
					TempIndex = int.Parse(splittedRecord[0]);
					}
					if (TempIndex == CredentialDL.idx)
                    {
						string name = splittedRecord[1];
						string fname = splittedRecord[2];
						string gender = splittedRecord[3];
						personalBL data = new personalBL(name, fname, gender);
						CredentialDL.SignUpdata[idx].SeparateDataList.Add(data);
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

		public static void AllPersonalStoreData(personalBL data)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\AllPersonalData.txt";
			StreamWriter file = new StreamWriter(path1, true);
			file.WriteLine( data.Name + "," + data.Fname + "," + data.Gender);
			file.Flush();
			file.Close();
		}
	
		public static bool AllPersonalReadData()
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\AllPersonalData.txt";
			StreamReader file = new StreamReader(path1);
			string record;
			if (File.Exists(path1))
			{
				while ((record = file.ReadLine()) != null)
				{
					    string[] splittedRecord = record.Split(',');
						string name = splittedRecord[0];
						string fname = splittedRecord[1];
						string gender = splittedRecord[2];
						personalBL data = new personalBL(name, fname, gender);
						personalDL.P.Add(data);
					

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
