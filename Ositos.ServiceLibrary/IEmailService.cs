using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ositos5.DAL;
using System.ServiceModel;

namespace Ositos.ServiceLibrary
{
    [ServiceContract]
   public interface IEmailService
    {
       [OperationContract]
       void SendEmail(OsitosEmail email);

    }

    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class EmailService:IEmailService
    {

        public void SendEmail(OsitosEmail email)
        {

            throw new NotImplementedException();
        }
    }


}
