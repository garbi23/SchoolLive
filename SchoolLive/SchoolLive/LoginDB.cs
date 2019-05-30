using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SchoolLive
{
    public class LoginDB
    {
        public static String strcon = "Server=schoolivedb.clcbck0utech.ap-northeast-2.rds.amazonaws.com; Database=SchoolDB; Uid=garbi23;Pwd=chlgkxo56;"
    + "PORT=3306;";

        private MySqlConnection dbcon;
        private MySqlCommand dbcmd;
        private MySqlDataReader dbread;

        public string tempid;
        public string temppass;
        public string tempnum;


        public void loginDBbring()
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
                tempnum = dbread["number"].ToString();
            }
            dbcon.Close();
        }

    }
}
