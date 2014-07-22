using Ositos5.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using Ositos5.Models;
using System.Text;
using System.ComponentModel;


namespace Ositos5.Controllers
{
    public class OsitoContactController : Controller
    {
        //
        // GET: /OsitoContact/


        public ActionResult test()
        {
            try
            {

                OsitoContext db = new OsitoContext();
                ContactRecord cr = new ContactRecord();
                cr.DateOfContact = DateTime.Today.Date.Date;
                cr.DateOfParty = DateTime.Today.Date.Date;
                db.ContactRecords.Add(cr);
                db.SaveChanges();
                Response.Write("success");
                return View();
            }
            catch(Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        public JsonResult Send(ContactRecord record)
        {
            ServerResponse sr = new ServerResponse();

            try
            {
                OsitoContext db = new OsitoContext();

                

                if (HttpContext.Request.IsAjaxRequest())
                {

                   

                    record.DateOfContact = DateTime.Now.Date.Date;
                    record.Emailed = "No";

                    if (ModelState.IsValid)
                    {
                        DateTime dt = DateTime.Today.Date.Date;
                        dt=dt.AddHours(DateTime.Now.Hour);
                        dt=dt.AddMinutes(DateTime.Now.Minute);
                        dt=dt.AddSeconds(DateTime.Now.Second);

                        string[] lines ={
                                            record.FName,
                                            record.LName,
                                            record.Email,
                                            record.City,
                                            record.Adults.ToString(),
                                            record.Kids.ToString(),
                                            record.PropertyType,
                                            record.BounceHouseRequested,
                                            record.BeanBagGameRequested,
                                            record.ChairsRequested,
                                            record.TablesRequested,
                                            record.CanopyRequested,
                                            record.TentRequested,
                                            record.SnowConeMachineRequested,
                                            record.DateOfParty.ToShortDateString(),
                                            record.Notes

                                        };

                        System.IO.File.AppendAllLines(@"c:\ositos\logs\pickup\" + dt.ToLongDateString() + ".txt", lines);
                        


                        //db.ContactRecords.Add(record);
                        //db.SaveChanges();
                      
                       // StartBackgroundWorker(record);
                       //record.Emailed = "Y";
                        //NotifyViaEmail(record);
                        sr.OperationMessage = "Message Sent!";
                        sr.Message = "success";
                    }
                    else
                    {

                        sr.ErrorMessage = "Invalid Form Data";
                        sr.ErrorType = "validation";
                        sr.Message = "Invalid Form Data";
                        sr.OperationMessage = "Invalid Form Data";

                    }

                }
                else
                {
                    sr.ErrorMessage = "Access Denied";
                    sr.ErrorType = "Security";
                    sr.Message = "Access Denied";
                    sr.OperationMessage = "Access Denied";
                }

                return Json(sr);
            }
            catch(Exception ex)
            {

                sr.ErrorMessage = ex.Message;
                return Json(sr);
            }
            }

        

        //private void StartBackgroundWorker(ContactRecord record)
        //{
        //    BackgroundWorker bg = new BackgroundWorker();
           
        //    bg.WorkerReportsProgress = false;
        //    bg.WorkerSupportsCancellation = false;


        //    bg.RunWorkerAsync(record);

        //}

        //private void bg_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    try
        //    {
        //        ContactRecord record = (ContactRecord)e.Argument;
        //        NotifyViaEmail(record);
        //    }
        //    catch(Exception ex)
        //    {
        //        StringBuilder sb = new StringBuilder(ex.Message);
        //        SendEmail(sb, "Error", "bgreer5050@gmail.com", "bgreer5050@gmail.com", "bgreer5050@gmail.com", "Kab,123Kab,123");
        //    }
        //}


     //public void NotifyViaEmail(ContactRecord record)
   //     {
            //StringBuilder sb = new StringBuilder();

            //sb.Append(@"<h2 style='background-color:yellow;display:inline;'>OsitosPartyRental.com Customer Inquiry</h2>");
            //sb.Append("<table>");


            //sb.Append("<tr style='border: 1px solid black';>");
            //sb.Append("<th style='border: 1px solid black';>");

            //sb.Append("</th>");

            //sb.Append("<th style='border: 1px solid black';>");
            //sb.Append("</th>");

            //sb.Append("</tr>");

            
            ////hbhbhb
            
            //sb.Append("<tr style='border: 1px solid black';>");
            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("ID");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.ID);
            //sb.Append("</td>");

            //sb.Append("</tr>");


            //sb.Append("<tr style='border: 1px solid black';>");
            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Date of Party");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.DateOfParty);
            //sb.Append("</td>");

            //sb.Append("</tr>");


            //sb.Append("<tr style='border: 1px solid black';>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("First Name");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.FName);
            //sb.Append("</td>");

            //sb.Append("</tr>");




            //sb.Append("<tr style='border: 1px solid black';>");
            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Last Name");

            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.LName);
            //sb.Append("</td>");

            //sb.Append("</tr>");



            //sb.Append("<tr style='border: 1px solid black';>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Email Address");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.Email);
            //sb.Append("</td>");

            //sb.Append("</tr>");



            //sb.Append("<tr style='border: 1px solid black';>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("City");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.City);
            //sb.Append("</td>");
            //sb.Append("</tr>");

            //sb.Append("<tr style='border: 1px solid black';>");
            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Adult Count:");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.Adults);
            //sb.Append("</td>");
            //sb.Append("</tr>");

            //sb.Append("<tr style='border: 1px solid black';>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Kid Count");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.Kids);
            //sb.Append("</td>");

            //sb.Append("</tr>");



            //sb.Append("<tr style='border: 1px solid black';>");
            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Property Type");

            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.PropertyType);
            //sb.Append("</td>");

            //sb.Append("</tr>");


            //sb.Append("<tr style='border: 1px solid black';>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Bounce House");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.BounceHouseRequested);
            //sb.Append("</td>");

            //sb.Append("</tr>");


            //sb.Append("<tr style='border: 1px solid black';>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Snowcone Machine");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.SnowConeMachineRequested);
            //sb.Append("</td>");

            //sb.Append("</tr>");



            //sb.Append("<tr style='border: 1px solid black';>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Bean Bag Game");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.BeanBagGameRequested);
            //sb.Append("</td>");

            //sb.Append("</tr>");


            //sb.Append("<tr style='border: 1px solid black';>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Chairs");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.ChairsRequested);
            //sb.Append("</td>");

            //sb.Append("</tr>");


            //sb.Append("<tr style='border: 1px solid black';>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Tables");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.TablesRequested);
            //sb.Append("</td>");

            //sb.Append("</tr>");



            //sb.Append("<tr style='border: 1px solid black';>");
            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Canopy");

            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.CanopyRequested);
            //sb.Append("</td>");

            //sb.Append("</tr>");


            //sb.Append("<tr style='border: 1px solid black';>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append("Tent");
            //sb.Append("</td>");

            //sb.Append("<td style='border: 1px solid black';>");
            //sb.Append(record.TentRequested);
            //sb.Append("</td>");

            //sb.Append("</tr>");
            //sb.Append("</table>");


            //SendEmail(sb, "OsitosPartyRentals Site Message","ositospartyrentals@gmail.com" ,"ositospartyrentals@gmail.com", "ositospartyrentals@gmail.com", "mauricio69");
             //SendEmail(sb, "OsitosPartyRentals Site Message", "bgreer5050@gmail.com", "bgreer5050@gmail.com", "bgreer5050@gmail.com", "Kab,123Kab,123");

//             StringBuilder textMsg = new StringBuilder("Please check your ositospartyrentals@gmail.com email account.  A customer has sent you a message via the web contact form.");
            //SendEmail(textMsg, "OsitosMessageWaiting", "ositospartyrentals@gmail.com", "7739888582@tmomail.net", "ositospartyrentals@gmail.com", "mauricio69");


     //  }

        //private static void SendEmail(StringBuilder sb,string _subject,string _emailFrom, string _emailTo, string _strUserName, string _strPassword)
        //{
        //     MailAddress emailFrom = new MailAddress(_emailFrom);

        //    //MailAddress addressTo1 = new MailAddress("ositospartyrentals@gmail.com");

        //    var smtp = new SmtpClient
        //    {
        //        Host = "smtp.gmail.com",
        //        Port = 587,
        //        EnableSsl = true,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential(_strUserName, _strPassword)
        //    };

        //    MailMessage msg = new MailMessage();
        //    msg.IsBodyHtml = true;
        //    msg.From = emailFrom;
        //    msg.Body = sb.ToString();
        //    msg.Subject = _subject;

        //    //msg.To.Add("ositospartyrentals@gmail.com");
        //    //msg.Bcc.Add("bgreer5050@gmail.com");
        //    msg.To.Add(_emailTo);
        //    smtp.Send(msg);
        //}

        public void NotifyViaText(ContactRecord redord)
        {
            StringBuilder sb = new StringBuilder();
            MailAddressCollection emailAddresses = new MailAddressCollection();
            MailAddress addressTo1 = new MailAddress("7739888582@tmomail.net");
            SmtpClient client = new SmtpClient();
            MailMessage msg = new MailMessage();

        }

    }
}
