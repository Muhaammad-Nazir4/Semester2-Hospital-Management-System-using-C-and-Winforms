using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using signUp.BL;

namespace signUp.DL
{
    class patientDL
    {
		


		private static List<patientBL> data1 = new List<patientBL>();

        internal static List<patientBL> Data1 { get => data1; set => data1 = value; }

		
		public static void storeData(patientBL  data)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\PatientData.txt";
			StreamWriter file = new StreamWriter(path1, true);
			file.WriteLine(data.Patient_name + "?" + data.Patientf_name + "?" + data.Patient_gender + "?" +
				data.Patient_age + "?" + data.Patient_room + "?" + data.Patient_date + "?" + data.Patient_group
				+ "?" + data.Patient_disease);
			file.Flush();
			file.Close();
		}
		public static void storeDataForDelete()
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\PatientData.txt";
			StreamWriter file = new StreamWriter(path1);
			foreach(patientBL data in Data1)
            {
				file.WriteLine(data.Patient_name + "?" + data.Patientf_name + "?" + data.Patient_gender + "?" +
								data.Patient_age + "?" + data.Patient_room + "?" + data.Patient_date + "?" + data.Patient_group
								+ "?" + data.Patient_disease);
			}
			
			file.Flush();
			file.Close();
		}
		public static void EditUserFromList(patientBL previous, patientBL updated)
		{
			foreach (patientBL patient in Data1)
			{
				if (patient.Patient_name == previous.Patient_name && patient.Patientf_name == previous.Patientf_name
					&& patient.Patient_gender == previous.Patient_gender && patient.Patient_age == previous.Patient_age
					&& patient.Patient_room == previous.Patient_room && patient.Patient_date == previous.Patient_date
					&& patient.Patient_group == previous.Patient_group && patient.Patient_disease == previous.Patient_disease)
				{
					patient.Patient_name = updated.Patient_name;
					patient.Patientf_name = updated.Patientf_name;
					patient.Patient_gender = updated.Patient_gender;
					patient.Patient_age = updated.Patient_age;
					patient.Patient_room = updated.Patient_room;
					patient.Patient_date = updated.Patient_date;
					patient.Patient_group = updated.Patient_group;
					patient.Patient_disease = updated.Patient_disease;
				}
			}

		}
		public static void deletePatientsFromFile( patientBL data)
        {
			for(int i=0; i< Data1.Count; i++)
            {
				if(Data1[i].Patient_name == data.Patient_name && Data1[i].Patientf_name == data.Patientf_name &&
					Data1[i].Patient_gender == data.Patient_gender && Data1[i].Patient_age == data.Patient_age &&
					Data1[i].Patient_room == data.Patient_room && Data1[i].Patient_date == data.Patient_date &&
					Data1[i].Patient_group == data.Patient_group && Data1[i].Patient_disease == data.Patient_disease)
                {
					Data1.RemoveAt(i);
                }
            }
        }
		public static void sorting() {
			Data1 = Data1.OrderByDescending(o => o.Patient_date).ToList();
		}

		public static bool readData()
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\PatientData.txt";
			StreamReader file = new StreamReader(path1);
			string record;
			if (File.Exists(path1))
			{
				while ((record = file.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split('?');
					string name = splittedRecord[0];
					string fname = splittedRecord[1];
					string gender = splittedRecord[2];
					float age = float.Parse(splittedRecord[3]);
					int room = int.Parse(splittedRecord[4]);
					string date = splittedRecord[5];
					string group = splittedRecord[6];
					string disease = splittedRecord[7];

					patientBL data = new patientBL(name , fname, gender , age , room, date , group , disease);
					Data1.Add(data);
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
