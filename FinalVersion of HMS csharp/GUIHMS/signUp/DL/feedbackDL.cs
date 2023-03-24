using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using signUp.BL;
using System.IO;

namespace signUp.DL
{
    class feedbackDL
    {
        private static List<feedback> commentList = new List<feedback>();

        internal static List<feedback> CommentList { get => commentList; set => commentList = value; }
		public static void FeedbackStoreData(feedback data)
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\FeedbackData.txt";
			StreamWriter file = new StreamWriter(path1, true);
			file.WriteLine(data.Name + "," + data.MyComment );
			file.Flush();
			file.Close();
		}

		public static bool FeedbackReadData()
		{
			string path1 = "D:\\GUIHMS\\signUp\\files\\FeedbackData.txt";
			StreamReader file = new StreamReader(path1);
			string record;
			if (File.Exists(path1))
			{
				while ((record = file.ReadLine()) != null)
				{
					string[] splittedRecord = record.Split(',');
					string name = splittedRecord[0];
					string comment = splittedRecord[1];
					feedback data = new feedback(name, comment);
					CommentList.Add(data);
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
