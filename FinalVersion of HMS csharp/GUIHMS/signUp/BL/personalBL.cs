using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signUp.BL
{
    class personalBL
    {

        private string name;
        private string fname;
        private string gender;
       

        public personalBL(string name, string fname, string gender)
        {
            this.name = name;
            this.fname = fname;
            this.gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Gender { get => gender; set => gender = value; }
     
    }
}
