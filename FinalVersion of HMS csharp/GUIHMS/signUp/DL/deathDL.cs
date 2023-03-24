using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using signUp.BL;
namespace signUp.DL
{
    class deathDL
    {
        private static List<deathBL> death = new List<deathBL>();

        internal static List<deathBL> Death { get => death; set => death = value; }
		public static void deathStoreData(deathBL data)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\DeathData.txt";
			StreamWriter file = new StreamWriter(path1, true);
			file.WriteLine(data.Name + "," + data.Fndeath + "," + data.Mndeath + "," + data.Gdeath + "," + data.Nmbrdeath);
			file.Flush();
			file.Close();
		}
		public static void deathStoreDataFromFile()
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\DeathData.txt";
			StreamWriter file = new StreamWriter(path1, true);
			foreach (deathBL data in Death)
			{
				file.WriteLine(data.Name + "," + data.Fndeath + "," + data.Mndeath + "," + data.Gdeath + "," + data.Nmbrdeath);
			}
			file.Flush();
			file.Close();
		}
		public static void deleteDeathFromFile(deathBL data)
		{
			for (int i = 0; i < Death.Count; i++)
			{
				if (Death[i].Fndeath == data.Fndeath && Death[i].Gdeath == data.Gdeath && Death[i].Mndeath == data.Mndeath &&
					Death[i].Name == data.Name && Death[i].Nmbrdeath == data.Nmbrdeath)
				{
					Death.RemoveAt(i);
				}
			}
		}

		public static bool deathReadData()
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\DeathData.txt";
			StreamReader file = new StreamReader(path1);
			string record;
			if (File.Exists(path1))
			{
				while ((record = file.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split(',');
					string name = splittedRecord[0];
					string fname = splittedRecord[1];
					string mname = splittedRecord[2];
					string condition = splittedRecord[3];
					string number = splittedRecord[4];

					deathBL data = new deathBL(name, fname, mname, condition, number);
					Death.Add(data);
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
