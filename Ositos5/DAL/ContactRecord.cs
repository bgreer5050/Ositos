using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ositos5.DAL
{
    public class ContactRecord
    {
        public int ID { get; set; }
        public DateTime DateOfContact { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }

        public string City { get; set; }

        public int Adults { get; set; }
        public int Kids { get; set; }

        public string PropertyType { get; set; }

        public string BounceHouseRequested { get; set; }
        public string SnowConeMachineRequested { get; set; }
        public string BeanBagGameRequested { get; set; }
        public string ChairsRequested { get; set; }
        public string TablesRequested { get; set; }
        public string CanopyRequested { get; set; }
        public string TentRequested { get; set; }

        public DateTime DateOfParty { get; set; }
        public string Notes { get; set; }

        public string Emailed { get; set; }
    }
}