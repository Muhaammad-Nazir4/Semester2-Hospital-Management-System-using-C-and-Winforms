using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace signUp.BL
{
   public class patientBL
    {
       

            //data members......................
            private string patient_name;
            private string patientf_name;
            private string patient_gender;
            private float patient_age;
            private int patient_room;
            private string patient_date;
            private string patient_group;
            private string patient_disease;

        public patientBL(string patient_name, string patientf_name, string patient_gender, float patient_age,
            int patient_room, string patient_date, string patient_group, string patient_disease)
        {
            this.patient_name = patient_name;
            this.patientf_name = patientf_name;
            this.patient_gender = patient_gender;
            this.patient_age = patient_age;
            this.patient_room = patient_room;
            this.patient_date = patient_date;
            this.patient_group = patient_group;
            this.patient_disease = patient_disease;
        }

        public string Patient_name { get => patient_name; set => patient_name = value; }
        public string Patientf_name { get => patientf_name; set => patientf_name = value; }
        public string Patient_gender { get => patient_gender; set => patient_gender = value; }
        public float Patient_age { get => patient_age; set => patient_age = value; }
        public int Patient_room { get => patient_room; set => patient_room = value; }
        public string Patient_date { get => patient_date; set => patient_date = value; }
        public string Patient_group { get => patient_group; set => patient_group = value; }
        public string Patient_disease { get => patient_disease; set => patient_disease = value; }

        
        }
}
