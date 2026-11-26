using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitsShop
{
    public partial class FormProducts: Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        dbConnection dbcon = new dbConnection();
        SqlDataReader dr;
        string title = "Fruits Shop";

        public FormProducts()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            LoadProduct();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormProductModule module = new FormProductModule(this);
            module.ShowDialog();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();

        }

        private void dataGridViewFormProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewFormProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FormProductModule module = new FormProductModule(this);
                module.lblPcode.Text = dataGridViewFormProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtName.Text = dataGridViewFormProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.cmbCategory.Text = dataGridViewFormProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtQuantity.Text = dataGridViewFormProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txtPrice.Text = dataGridViewFormProduct.Rows[e.RowIndex].Cells[5].Value.ToString();

                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this items?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    dbcon.executeQuery("DELETE FROM tbProduct WHERE pcode LIKE " + dataGridViewFormProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "");
                    MessageBox.Show("Item record has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            LoadProduct();
        }
        

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormProductModule module = new FormProductModule(this);
            module.ShowDialog();
        }
        #region Method

        public void LoadProduct()
        {
            int i = 0;
            dataGridViewFormProduct.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbProduct WHERE CONCAT(pname,category) LIKE '%" + txtSearch.Text + "%'", cn);
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
