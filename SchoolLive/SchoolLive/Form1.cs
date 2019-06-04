using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLive
{
    public partial class Form1 : Form
    {

        string path = "member.chdb";


        public Form1()
        {
            InitializeComponent();
            string memnum = File.ReadAllText(path);
            label2.Text = memnum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }




    }
}
