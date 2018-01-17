using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMySQLviaWinForm
{
    public partial class Form1 : Form
    {
        private string strServer = "testconnect.c7bynrothlke.us-west-1.rds.amazonaws.com";
        private string strUserID = "test";
        private string strPassword = "test123456789";
        private string strDatabase = "test";
        private string strPort = "3306";

        private static MySqlConnection MySqlConn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConn = CreateMySqlConnection();
        }

        public MySqlConnection CreateMySqlConnection()
        {
            string strConn = String.Format("server={0}; uid={1}; pwd={2}; database={3}; port={4}",
                strServer, strUserID, strPassword, strDatabase, strPort);
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
            }
            catch (MySqlException myex)
            {

            }
            catch (Exception ex)
            {

            }

            return conn;
        }
    }
}
