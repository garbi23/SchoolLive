using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace SchoolLive
{


    public partial class LoginForm : Form
    {

        public static String strcon = "Server=schoolivedb.clcbck0utech.ap-northeast-2.rds.amazonaws.com; Database=SchoolDB; Uid=garbi23;Pwd=chlgkxo56;" 
            + "PORT=3306;";

        MySqlConnection conne = new MySqlConnection(strcon);

        private MySqlConnection dbcon;
        private MySqlCommand dbcmd;
        private MySqlDataReader dbread;

        Form1 MainForm = new Form1();

        public static string tempid;
        public static string temppass;


        private void LoginForm_Load(object sender, EventArgs e)
        {
            dbcon = new MySqlConnection(strcon);
            dbcmd = new MySqlCommand();
            dbcmd.Connection = dbcon;

            dbcmd.CommandText = "SELECT * FROM login_DB;";
            dbcon.Open();
            dbread = dbcmd.ExecuteReader();

            while (dbread.Read())
            {
                tempid = dbread["id"].ToString();
                temppass = dbread["pass"].ToString();
            }
            dbcon.Close();
        }

        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginFormClose()
        {
            this.Hide();
            MainForm.ShowDialog(); //폼의 주체를 변경
            this.Close();

        }

        private void LoginStatsCh(TextBox textbox  ,String ifs, String boxtext, Char chr, Color forcolor)
        {
            if (textbox.Text == ifs)
            {
                textbox.Text = boxtext;
                textbox.PasswordChar = chr;
                textbox.ForeColor = forcolor;
            }
        }

        private void Loginid_Enter(object sender, EventArgs e)
        {
            LoginStatsCh(loginid , "아이디" , "", '\0' , Color.Black);
        }

        private void Loginid_Leave(object sender, EventArgs e)
        {
            LoginStatsCh(loginid ,"", "아이디", '\0', Color.FromArgb(255, 128, 128));
        }

        private void Loginpass_Enter(object sender, EventArgs e)
        {
            LoginStatsCh(loginpass , "비밀번호", "", '*', Color.Black);
        }

        private void Loginpass_Leave(object sender, EventArgs e)
        {
            LoginStatsCh(loginpass, "", "비밀번호", '\0', Color.FromArgb(255, 128, 128));
        }

        private void Loginpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && loginid.Text == tempid && loginpass.Text == temppass)
            {
                LoginFormClose();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (loginid.Text == tempid && loginpass.Text == temppass)
            {
                LoginFormClose();
            }
        }

    }
}
