using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitsShop
{
    public partial class FormCashProduct: Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        dbConnection dbcon = new dbConnection();
        SqlDataReader dr;
        string title = "Fruits Shop";
        public string uname;
        FormCash cash;
        public FormCashProduct(FormCash form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            cash =form;
            LoadProduct();
           
        }

        private void dataGridViewFormProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridViewFormProduct.Rows)
            {
                bool chkbox = Convert.ToBoolean(dr.Cells["Select"].Value);
                if (chkbox)
                {
                    try
                    {
                        cm = new SqlCommand("INSERT INTO tbCash(transno, pcode, pname, quantity, price, cashier) VALUES (@transno, @pcode, @pname, @quantity, @price, @cashier)", cn);
                        cm.Parameters.AddWithValue("@transno", cash.lblTransno.Text);
                        cm.Parameters.AddWithValue("@pcode", dr.Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@pname", dr.Cells[2].Value.ToString());
                        cm.Parameters.AddWithValue("@quaantity", 1);
                        cm.Parameters.AddWithValue("@price", Convert.ToDouble(dr.Cells[5].Value.ToString()));
                        cm.Parameters.AddWithValue("@cashier", uname);

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();

                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message, title);
                    }
                }
            }

            cash.loadCash();
            this.Dispose();
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region Method

        public void LoadProduct()
        {
            int i = 0;
            dataGridViewFormProduct.Rows.Clear();
            cm = new SqlCommand("SELECT pcode,pname,category,price FROM tbProduct WHERE CONCAT(pname,category,price) LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewFormProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }
        #endregion Method

    }
}
