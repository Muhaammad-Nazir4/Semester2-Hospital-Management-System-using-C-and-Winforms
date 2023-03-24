using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signUp.BL
{
    class birthBL
    {
        
        
        private string gbirth;
        private string fnbirth;
        private string conbirth;
        private string mnbirth;
        private string nmbrbirth;

        public birthBL(string gbirth, string fnbirth, string conbirth, string mnbirth, string nmbrbirth)
        {
            this.gbirth = gbirth;
            this.fnbirth = fnbirth;
            this.conbirth = conbirth;
            this.mnbirth = mnbirth;
            this.nmbrbirth = nmbrbirth;
        }

        public string Gbirth { get => gbirth; set => gbirth = value; }
        public string Fnbirth { get => fnbirth; set => fnbirth = value; }
        public string Conbirth { get => conbirth; set => conbirth = value; }
        public string Mnbirth { get => mnbirth; set => mnbirth = value; }
        public string Nmbrbirth { get => nmbrbirth; set => nmbrbirth = value; }

       

    }
}
