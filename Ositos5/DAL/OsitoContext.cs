using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ositos5.DAL
{
    public class OsitoContext : DbContext
    {
        public DbSet<ContactRecord> ContactRecords { get; set; }
    }
}