using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ositos5;
using Ositos5.DAL;



namespace DeleteTestContactRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();

            
        }

        protected static void Test2()
        {

            try
            {


                string[] files = System.IO.Directory.GetFiles(@"c:\ositos\logs\pickup");



                foreach (string file in files)
                {
                

                   string DtTime = DateTime.Today.Month.ToString();
                   DtTime = DtTime + DateTime.Today.Day.ToString();
                   DtTime = DtTime + DateTime.Today.Year.ToString();
                   DtTime = DtTime + DateTime.Now.Hour.ToString();
                   DtTime = DtTime + DateTime.Now.Minute.ToString();
                   DtTime = DtTime + DateTime.Now.Second.ToString();
                   DtTime = DtTime + DateTime.Now.Millisecond.ToString();

                    File.Move(file, @"c:\ositos\logs\pickup\archived\" + DtTime + ".txt");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               // WriteToLog(ex.Message);
                // WriteToLog(ex.StackTrace);
            }
            // WriteToLog("Success");
        }
        private static void WriteToLog(string msg)
        {
            string fileName = @"C:\ositos\log.txt";
            System.IO.StreamWriter sw = System.IO.File.AppendText(fileName);
            sw.WriteLine(msg);
            sw.Close();
            sw.Dispose();
        }
    }

    


}
