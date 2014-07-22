using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDTool
{
  public  class Media
    {
        public int ID { get; set; }
        public virtual List<xDirectory> Directories { get; set; }

    }

    public class xDirectory
    {
        public int ID { get; set; }
        public Media media { get; set; }
        public virtual List<xFiles> files { get; set; }
    }

    public class xFiles
    {
        public int ID { get; set; }
        public Media media { get; set; }
        public xDirectory Directory { get; set; }
        
    }
}
