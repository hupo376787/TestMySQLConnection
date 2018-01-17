using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace TestMySQLviaUWP
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private static string strServer = "testconnect.c7bynrothlke.us-west-1.rds.amazonaws.com";
        private static string strUserID = "test";
        private static string strPassword = "test123456789";
        private static string strDatabase = "test";
        private static string strPort = "3306";

        private static MySqlConnection MySqlConn;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MySqlConn = CreateMySqlConnection();
        }

        public MySqlConnection CreateMySqlConnection()
        {
            string strConn = String.Format("server={0}; uid={1}; pwd={2}; database={3}",
                strServer, strUserID, strPassword, strDatabase);
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = strConn;
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
