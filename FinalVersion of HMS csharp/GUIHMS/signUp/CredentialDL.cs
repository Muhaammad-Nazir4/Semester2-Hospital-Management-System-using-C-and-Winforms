using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace signUp
{
    class CredentialDL
    {
        public static int idx = 0;

        private static List<MyUser> signUpdata = new List<MyUser>();

        internal static List<MyUser> SignUpdata { get => signUpdata; set => signUpdata = value; }

        public static void addSignUpIntoList(MyUser credential)
        {
            SignUpdata.Add(credential);
        }
       
        public static string SignIn(string username, string password)
        {
            for (int i= 0 ; i<SignUpdata.Count; i++)
            {
                if (username == SignUpdata[i].Username && password == SignUpdata[i].Password)
                {
                    idx = i;
                    return SignUpdata[i].UserRole;
                }
            } 
            return "NA";

        }
        public static void storeData(MyUser data)
        {

            string path1 = "D:\\GUIHMS\\signUp\\files\\LoginData.txt";
            StreamWriter file = new StreamWriter(path1, true);
            file.WriteLine(data.Username + "," + data.Password + "," + data.UserRole);
            file.Flush();
            file.Close();
        }

        public static bool readData()
        {
            string path1 = "D:\\GUIHMS\\signUp\\files\\LoginData.txt";
                 StreamReader file = new StreamReader(path1);
            string record;
            if (File.Exists(path1))
            {
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string username = splittedRecord[0];
                    string password = splittedRecord[1];
                    string userRole = splittedRecord[2];

                    MyUser data = new MyUser(username, password, userRole);
                    SignUpdata.Add(data);
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
