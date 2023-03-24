using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using signUp.BL;
using signUp.DL;

namespace signUp
{
    class MyUser
    {
        

        private string username;
        private string password;
        private string userRole;
        private List<personalBL> separateDataList = new List<personalBL>();
        private List<medicalBL> separateDataListForMedical = new List<medicalBL>();
        public MyUser(string username, string password, string userRole)
        {
            this.Username = username;
            this.Password = password;
            this.UserRole = userRole;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        internal List<medicalBL> SeparateDataListForMedical { get => separateDataListForMedical; set => separateDataListForMedical = value; }
        internal List<personalBL> SeparateDataList { get => separateDataList; set => separateDataList = value; }
    }
}
