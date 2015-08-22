using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ositos5.DAL;
using System.Net;
using System.Net.Mail;

namespace DeleteTestContactRecord
{
    class TestEmail
    {

        public static void Start()
        {
            try
            {

                string fileName = @"C:\test\log.txt";
                DateTime dt = DateTime.Today.Date.Date;
                dt = dt.AddHours(DateTime.Now.Hour);
                dt = dt.AddMinutes(DateTime.Now.Minute);
                dt = dt.AddSeconds(DateTime.Now.Second);
                System.IO.StreamWriter sw = System.IO.File.AppendText(fileName);


                StringBuilder sbtest = new StringBuilder("This is a test");
                try
                {
                    OsitoContext db = new OsitoContext();
                    foreach (ContactRecord record in db.ContactRecords.Where(c => c.Emailed != "Yes"))
                    {

                        NotifyViaEmail(record);
                        record.Emailed = "Yes";
                    }
                    db.SaveChanges();

                    //SendEmail(sbtest, "Test", "bgreer5050@gmail.com", "bgreer5050@gmail.com", "bgreer5050@gmail.com", "Kab,123Kab,123");
                    sw.WriteLine("success");
                    sw.Close();
                    sw.Dispose();
                }
                catch (Exception exT)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }
            catch (Exception ex)
            {
                WriteToLog(ex.StackTrace);
                WriteToLog(ex.Message);
                WriteToLog(ex.InnerException.Message);
            }
        }


        private static void NotifyViaEmail(ContactRecord record)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(@"<h2 style='background-color:yellow;display:inline;'>OsitosPartyRental.com Customer Inquiry</h2>");
            sb.Append("<table>");


            sb.Append("<tr style='border: 1px solid black';>");
            sb.Append("<th style='border: 1px solid black';>");

            sb.Append("</th>");

            sb.Append("<th style='border: 1px solid black';>");
            sb.Append("</th>");

            sb.Append("</tr>");


            //hbhbhb

            sb.Append("<tr style='border: 1px solid black';>");
            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("ID");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.ID);
            sb.Append("</td>");

            sb.Append("</tr>");


            sb.Append("<tr style='border: 1px solid black';>");
            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Date of Party");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.DateOfParty);
            sb.Append("</td>");

            sb.Append("</tr>");


            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("First Name");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.FName);
            sb.Append("</td>");

            sb.Append("</tr>");




            sb.Append("<tr style='border: 1px solid black';>");
            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Last Name");

            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.LName);
            sb.Append("</td>");

            sb.Append("</tr>");



            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Email Address");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.Email);
            sb.Append("</td>");

            sb.Append("</tr>");



            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("City");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.City);
            sb.Append("</td>");
            sb.Append("</tr>");

            sb.Append("<tr style='border: 1px solid black';>");
            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Adult Count:");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.Adults);
            sb.Append("</td>");
            sb.Append("</tr>");

            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Kid Count");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.Kids);
            sb.Append("</td>");

            sb.Append("</tr>");



            sb.Append("<tr style='border: 1px solid black';>");
            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Property Type");

            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.PropertyType);
            sb.Append("</td>");

            sb.Append("</tr>");


            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Bounce House");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.BounceHouseRequested);
            sb.Append("</td>");

            sb.Append("</tr>");


            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Snowcone Machine");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.SnowConeMachineRequested);
            sb.Append("</td>");

            sb.Append("</tr>");



            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Bean Bag Game");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.BeanBagGameRequested);
            sb.Append("</td>");

            sb.Append("</tr>");


            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Chairs");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.ChairsRequested);
            sb.Append("</td>");

            sb.Append("</tr>");


            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Tables");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.TablesRequested);
            sb.Append("</td>");

            sb.Append("</tr>");



            sb.Append("<tr style='border: 1px solid black';>");
            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Canopy");

            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.CanopyRequested);
            sb.Append("</td>");

            sb.Append("</tr>");


            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Tent");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.TentRequested);
            sb.Append("</td>");

            sb.Append("</tr>");

            sb.Append("<tr style='border: 1px solid black';>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append("Tent");
            sb.Append("</td>");

            sb.Append("<td style='border: 1px solid black';>");
            sb.Append(record.Notes);
            sb.Append("</td>");

            sb.Append("</tr>");


            sb.Append("</table>");


            SendEmail(sb, "OsitosPartyRentals Site Message", "bgreer5050@gmail.com", "ositospartyrentals@gmail.com", "bgreer5050@gmail.com", "Kab,123Kab,123");

        }

        private static void SendEmail(StringBuilder sb, string _subject, string _emailFrom, string _emailTo, string _strUserName, string _strPassword)
        {
            MailAddress emailFrom = new MailAddress(_emailFrom);

            //MailAddress addressTo1 = new MailAddress("ositospartyrentals@gmail.com");

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_strUserName, _strPassword)
            };

            MailMessage msg = new MailMessage();
            msg.IsBodyHtml = true;
            msg.From = emailFrom;
            msg.Body = sb.ToString();
            msg.Subject = _subject;

            //msg.To.Add("ositospartyrentals@gmail.com");
            //msg.Bcc.Add("bgreer5050@gmail.com");
            msg.To.Add(_emailTo);
            msg.Bcc.Add("bgreer5050@gmail.com");
            smtp.Send(msg);
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
