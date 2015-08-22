using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ositos5;
using Ositos5.DAL;

namespace Ositos.StoreContactRecordTest
{

    public class program
    {
        public static void Main(String[] args)
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
                    string time = DateTime.Now.Millisecond.ToString();

                    WriteToLog(file);
                    //File.Copy()
                    File.Move(file,"c:\\ositos\\logs\\pickup\\archived\\" + time + ".txt");
                }
            }
            catch (Exception ex)
            {
                WriteToLog(ex.Message);
                WriteToLog(ex.StackTrace);
            }
            WriteToLog("Success");
        }



        protected static void Test()
        {
            try
            {

                OsitoContext db = new OsitoContext();

                string[] files = System.IO.Directory.GetFiles(@"c:\ositos\logs\pickup");


                foreach (string file in files)
                {
                    //WriteToLog(file);
                    //WriteToLog(files.Length.ToString());

                    ContactRecord record = new ContactRecord();
                    string line;
                    int counter = 0;

                    //open file
                    System.IO.StreamReader sr = new System.IO.StreamReader(file);
                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter)
                        {
                            case 0:
                                record.FName = line;
                                break;

                            case 1:
                                record.LName = line;
                                break;

                            case 2:
                                record.Email = line;
                                break;

                            case 3:
                                record.City = line;
                                break;

                            case 4:
                                int adults = 0;
                                if (int.TryParse(line, out adults))
                                {
                                    record.Adults = adults;
                                }
                                else
                                {
                                    record.Adults = 0;
                                }
                                break;

                            case 5:
                                int kids = 0;
                                if (int.TryParse(line, out kids))
                                {
                                    record.Kids = kids;
                                }
                                else
                                {
                                    record.Kids = 0;
                                }
                                break;

                            case 6:
                                record.PropertyType = line;
                                break;

                            case 7:
                                record.BounceHouseRequested = line;
                                break;

                            case 8:
                                record.BeanBagGameRequested = line;
                                break;

                            case 9:
                                record.ChairsRequested = line;
                                break;

                            case 10:
                                record.TablesRequested = line;
                                break;

                            case 11:
                                record.CanopyRequested = line;
                                break;

                            case 12:
                                record.TentRequested = line;
                                break;

                            case 13:
                                record.SnowConeMachineRequested = line;
                                break;

                            case 14:
                                record.DateOfParty = DateTime.Parse(line);
                                break;

                            case 15:
                                record.Notes = line;
                                break;

                            default:
                                break;
                        }
                        Console.WriteLine(line);
                        counter++;
                    }

                    sr.Close();
                    //build record object

                    record.DateOfContact = DateTime.Today.Date.Date;
                    record.DateOfContact = record.DateOfContact.AddHours(DateTime.Now.Hour);
                    record.DateOfContact = record.DateOfContact.AddMinutes(DateTime.Now.Minute);


                    //store in db
                    db.ContactRecords.Add(record);
                    db.SaveChanges();
                    //close file
                    sr.Close();
                    sr.Dispose();
                    //move file


                    WriteToLog(file);
                    File.Move(file, @"c:\ositos\logs\pickup\archived\" + file);
                    WriteToLog("made it here");

                    //string oldfile = (@"C:\oldfile.txt");
                    //string newfile = (@"C:\newfolder\newfile.txt");
                    //System.IO.File.Move(oldfile, newfile);


                    db.Dispose();
                }
            }
            catch (Exception exT)
            {
                WriteToLog(exT.StackTrace);
                WriteToLog(exT.Message);
                WriteToLog(exT.InnerException.Message);

            }
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            try
            {

                OsitoContext db = new OsitoContext();

                string[] files = System.IO.Directory.GetFiles(@"c:\ositos\logs\pickup");
                foreach (string file in files)
                {
                    ContactRecord record = new ContactRecord();
                    string line;
                    int counter = 0;

                    //open file
                    System.IO.StreamReader sr = new System.IO.StreamReader(file);
                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter)
                        {
                            case 0:
                                record.FName = line;
                                break;

                            case 1:
                                record.LName = line;
                                break;

                            case 2:
                                record.Email = line;
                                break;

                            case 3:
                                record.City = line;
                                break;

                            case 4:
                                int adults = 0;
                                if (int.TryParse(line, out adults))
                                {
                                    record.Adults = adults;
                                }
                                else
                                {
                                    record.Adults = 0;
                                }
                                break;

                            case 5:
                                int kids = 0;
                                if (int.TryParse(line, out kids))
                                {
                                    record.Kids = kids;
                                }
                                else
                                {
                                    record.Kids = 0;
                                }
                                break;

                            case 6:
                                record.PropertyType = line;
                                break;

                            case 7:
                                record.BounceHouseRequested = line;
                                break;

                            case 8:
                                record.BeanBagGameRequested = line;
                                break;

                            case 9:
                                record.ChairsRequested = line;
                                break;

                            case 10:
                                record.TablesRequested = line;
                                break;

                            case 11:
                                record.CanopyRequested = line;
                                break;

                            case 12:
                                record.TentRequested = line;
                                break;

                            case 13:
                                record.SnowConeMachineRequested = line;
                                break;

                            case 14:
                                record.DateOfParty = DateTime.Parse(line);
                                break;

                            case 15:
                                record.Notes = line;
                                break;

                            default:
                                break;
                        }
                        Console.WriteLine(line);
                        counter++;
                    }

                    sr.Close();
                    //build record object

                    record.DateOfContact = DateTime.Today.Date.Date;
                    record.DateOfContact = record.DateOfContact.AddHours(DateTime.Now.Hour);
                    record.DateOfContact = record.DateOfContact.AddMinutes(DateTime.Now.Minute);


                    //store in db
                    db.ContactRecords.Add(record);
                    db.SaveChanges();
                    //close file
                    sr.Close();
                    sr.Dispose();
                    //move file


                    WriteToLog(file);
                    File.Move(file, @"c:\ositos\logs\pickup\archived\" + file);
                    WriteToLog("made it here");

                    //string oldfile = (@"C:\oldfile.txt");
                    //string newfile = (@"C:\newfolder\newfile.txt");
                    //System.IO.File.Move(oldfile, newfile);


                    db.Dispose();
                }
            }
            catch (Exception exT)
            {
                WriteToLog(exT.StackTrace);
                WriteToLog(exT.Message);
                WriteToLog(exT.InnerException.Message);

            }
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
