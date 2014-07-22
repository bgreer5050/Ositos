using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CDTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Enter A New CD / DVD";
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");
            SearchOption so = new SearchOption();

            var jjs = dirInfo.GetFiles("*", SearchOption.TopDirectoryOnly);
            MessageBox.Show(jjs.Length.ToString());
            FileContext db = new FileContext();
            db.medias.Add(new Media { ID = 1 });
            MessageBox.Show(db.SaveChanges().ToString());
            db.Dispose();


        }
    }
}
