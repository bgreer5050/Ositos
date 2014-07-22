using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;

namespace Ositos.ServiceLibrary
{
    [DataContract]
   public class OsitosEmail
    {

        public int ID { get; set; }
        [DataMember]
        public List<string> EmailToAddresses { get; set; }
        [DataMember]
        public string EmailFrom { get; set; }
        [DataMember]
        public string EmailUserName { get; set; }
        [DataMember]
        public string EmailPassword { get; set; }
        [DataMember]
        public string EmailMessage { get; set; }
        [DataMember]
        public SmtpClient Client { get; set; }
    }
}
