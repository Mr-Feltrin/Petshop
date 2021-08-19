using System;
using System.IO;

namespace PetShop.Entities.Exceptions
{
    public static class ErrorLogger
    {
        public static void CreateErrorLog(Exception ex)
        {
            string FilePath = $@"{AppDomain.CurrentDomain.BaseDirectory}\ErrorLog.txt";
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Dispose();
            }
            using (StreamWriter sw = File.AppendText(FilePath))
            {
                sw.WriteLine("=============Error Logging ===========");
                sw.WriteLine("===========Start============= " + DateTime.Now);
                sw.WriteLine("Error Message: " + ex.Message);
                sw.WriteLine("Stack Trace: " + ex.StackTrace);
                sw.WriteLine("===========End============= " + DateTime.Now);
                sw.WriteLine();
            }
        }
    }
}
