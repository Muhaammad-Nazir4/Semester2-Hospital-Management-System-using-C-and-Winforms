using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signUp.BL
{
    class appointment
    {
        private string name;
        private string doctor;
        private string day;

        public appointment(string name, string doctor, string day)
        {
            this.name = name;
            this.doctor = doctor;
            this.day = day;
        }

        public string Name { get => name; set => name = value; }
        public string Doctor { get => doctor; set => doctor = value; }
        public string Day { get => day; set => day = value; }

        
    }
}
