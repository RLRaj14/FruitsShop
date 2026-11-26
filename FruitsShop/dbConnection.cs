using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FruitsShop
{
    class dbConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;


        public string Connection()
        {
            con = @"Data Source=LAPTOP-CSGT9HE4;Initial Catalog=FruitsShopDb;Integrated Security=True;Encrypt=False;Connect Timeout =30";
            return con;
        }
        public void executeQuery(string sql)
        {
            try
            {
                cn.ConnectionString = Connection();
                cn.Open();
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         
        }
    }
}
