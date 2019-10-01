using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SchoolLive
{
    public class LoginDB
    {
        public static String strcon = "Server=schoolivedb.clcbck0utech.ap-northeast-2.rds.amazonaws.com; Database=SchoolDB; Uid=********;Pwd=********;"
    + "PORT=3306;";



        private MySqlConnection dbcon;
        private MySqlCommand dbcmd;
        private MySqlDataReader dbread;

        public string tempid;
        public string temppass;
        string path = "member.chdb";
        string memnum;

        public void loginDBbring(LoginForm lfrm)
        {
            dbcon = new MySqlConnection(strcon);
            dbcmd = new MySqlCommand();
            dbcmd.Connection = dbcon;

            string querys = "SELECT * FROM login_DB WHERE id='" + lfrm.loginid.Text + "'AND pass='" + lfrm.loginpass.Text + "'";
            dbcmd.CommandText = querys;
            dbcmd.CreateParameter();
            dbcon.Open();
            dbread = dbcmd.ExecuteReader();

            while (dbread.Read())
            {
                
                tempid = dbread["id"].ToString();
                temppass = dbread["pass"].ToString();
                memnum = dbread["number"].ToString();
            }

            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(memnum);
            sw.Close();


        }


    }
}
