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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Loginid_Enter(object sender, EventArgs e)
        {
            if(loginid.Text == "아이디")
            {
                loginid.Text = "";
                loginid.ForeColor = Color.Black;
            }
        }

        private void Loginid_Leave(object sender, EventArgs e)
        {
            if (loginid.Text == "")
            {
                loginid.Text = "아이디";
                loginid.ForeColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void Loginpass_Enter(object sender, EventArgs e)
        {
            if (loginpass.Text == "비밀번호")
            {
                loginpass.Text = "";
                loginpass.PasswordChar = '*';
                loginpass.ForeColor = Color.Black;
            }
        }

        private void Loginpass_Leave(object sender, EventArgs e)
        {
            if (loginpass.Text == "")
            {
                loginpass.Text = "비밀번호";
                loginpass.PasswordChar = '\0';
                loginpass.ForeColor = Color.FromArgb(255, 128, 128);
            }
        }
    }
}
