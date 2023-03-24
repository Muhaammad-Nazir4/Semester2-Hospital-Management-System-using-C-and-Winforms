using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signUp.BL
{
    class medicalBL
    {
        
        private string date;
        private string group;
        private string disease;

        public medicalBL(string date, string group, string disease)
        {
            this.date = date;
            this.group = group;
            this.disease = disease;
        }

        public string Date { get => date; set => date = value; }
        public string Group { get => group; set => group = value; }
        public string Disease { get => disease; set => disease = value; }

       
    }
}
