using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLive
{
    public partial class Form1 : Form
    {
        LoginDB logindb = new LoginDB();

        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logindb.loginDBbring();
            label2.Text = logindb.tempnum;

        }

        public void Test()
        {
            
        }


    }
}
