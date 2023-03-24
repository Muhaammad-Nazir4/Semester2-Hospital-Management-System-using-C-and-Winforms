using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signUp.BL
{
    class feedback
    {
        private string name;
        private string myComment;

        public feedback(string name, string comment)
        {
            this.name = name;
            MyComment = comment;
        }

        public string Name { get => name; set => name = value; }
        public string MyComment { get => myComment; set => myComment = value; }
    }
}
