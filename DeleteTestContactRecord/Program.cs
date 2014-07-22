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
            try
            { 

            OsitoContext db = new OsitoContext();

            string[] files =  System.IO.Directory.GetFiles(@"c:\ositos\logs\pickup");
            foreach(string file in files)
            {
                ContactRecord record = new ContactRecord();
                string line;
                int counter = 0;

                //open file
                System.IO.StreamReader sr = new System.IO.StreamReader(file);
                while ((line = sr.ReadLine()) != null)
                {  
                    switch(counter)
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
                            if(int.TryParse(line, out adults))
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
                            if(int.TryParse(line, out kids))
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


                foreach(string strFile in files)
                {
                    File.Move(strFile,@"c:\ositos\log\pickup\archived\");
                }

                db.Dispose();
                }
            }
        catch(Exception exT)
            {

                string fileName = @"C:\ositos\log.txt";
                System.IO.StreamWriter sw = System.IO.File.AppendText(fileName);    
                sw.WriteLine(exT.Message);
                sw.Close();
                sw.Dispose();

            }
        }
    }
}
