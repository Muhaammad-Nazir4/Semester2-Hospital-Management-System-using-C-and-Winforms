using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace signUp.BL
{
    class deathBL
    {
        private string name;
        private string fndeath;
        private string mndeath;
        private string gdeath;
        private string nmbrdeath;

        public deathBL(string name, string fndeath, string mndeath, string gdeath, string nmbrdeath)
        {
            this.name = name;
            this.fndeath = fndeath;
            this.mndeath = mndeath;
            this.gdeath = gdeath;
            this.nmbrdeath = nmbrdeath;
        }

        public string Name { get => name; set => name = value; }
        public string Fndeath { get => fndeath; set => fndeath = value; }
        public string Mndeath { get => mndeath; set => mndeath = value; }
        public string Gdeath { get => gdeath; set => gdeath = value; }
        public string Nmbrdeath { get => nmbrdeath; set => nmbrdeath = value; }
       

        
    }
}
