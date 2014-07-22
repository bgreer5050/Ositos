using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace CDTool
{
   public class FileContext :DbContext
    {
       public DbSet<Media> medias { get; set; }
       public DbSet<xDirectory> directories { get; set; }
       public DbSet<xFiles> files { get; set; }

    }
}
