using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using signUp.BL;
using signUp.DL;

namespace signUp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CredentialDL.readData();
            patientDL.readData();
            birthDL.birthReadData();
            deathDL.deathReadData();
            personalDL.AllPersonalReadData();
            medicalDL.AllmedicalReadData();
            feedbackDL.FeedbackReadData();
            appointmentDL.readData();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FirstForm());
        }
    }
}
