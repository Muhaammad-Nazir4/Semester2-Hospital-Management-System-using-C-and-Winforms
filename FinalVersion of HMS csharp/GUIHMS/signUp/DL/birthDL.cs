using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using signUp.BL;
namespace signUp.DL
{
    class birthDL
    {
        private static List<birthBL> baby = new List<birthBL>();

        internal static List<birthBL> Baby { get => baby; set => baby = value; }
		public static void birthStoreData(birthBL data)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\BirthData.txt";
			StreamWriter file = new StreamWriter(path1, true);
			file.WriteLine(data.Gbirth + "," + data.Fnbirth + "," + data.Conbirth + "," + data.Mnbirth + "," +data.Nmbrbirth );
			file.Flush();
			file.Close();
		}
		public static void birthStoreDataForDelete()
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\BirthData.txt";
			StreamWriter file = new StreamWriter(path1);
			foreach (birthBL data in Baby)
			{
				file.WriteLine(data.Gbirth + "," + data.Fnbirth + "," + data.Conbirth + "," + data.Mnbirth + "," + data.Nmbrbirth);
			}
			file.Flush();
			file.Close();
		}
		public static void deleteBirthFromFile(birthBL data)
		{
			for (int i = 0; i < Baby.Count; i++)
			{
				if (Baby[i].Fnbirth == data.Fnbirth && Baby[i].Gbirth == data.Gbirth && Baby[i].Mnbirth == data.Mnbirth &&
					Baby[i].Conbirth == data.Conbirth && Baby[i].Nmbrbirth == data.Nmbrbirth )
				{
					Baby.RemoveAt(i);
				}
			}
		}

		public static bool birthReadData()
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\BirthData.txt";
			StreamReader file = new StreamReader(path1);
			string record;
			if (File.Exists(path1))
			{
				while ((record = file.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split(',');
					string gender = splittedRecord[0];
					string fname = splittedRecord[1];
					string condition = splittedRecord[2];
					string mname = splittedRecord[3];
					string number = splittedRecord[4];

					birthBL data = new birthBL( gender, fname, condition, mname ,number);
					Baby.Add(data);
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
