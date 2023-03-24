using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using signUp.BL;
using System.IO;

namespace signUp.DL
{
    class appointmentDL
    {
        private static List<appointment> appointmentList = new List<appointment>();

        internal static List<appointment> AppointmentList { get => appointmentList; set => appointmentList = value; }

		public static void storeData(string name,appointment data)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\AppointmentData.txt";
			StreamWriter file = new StreamWriter(path1, true);
			file.WriteLine(name+","+data.Doctor + "," + data.Day);
			file.Flush();
			file.Close();
		}
		public static bool readData()
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\AppointmentData.txt";
			StreamReader file = new StreamReader(path1);
			string record;
			if (File.Exists(path1))
			{
				while ((record = file.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split(',');
					string name = splittedRecord[0];
					string doctor = splittedRecord[1];
					string day = splittedRecord[2];
					appointment data = new appointment(name,doctor, day);
					appointmentList.Add(data);
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
