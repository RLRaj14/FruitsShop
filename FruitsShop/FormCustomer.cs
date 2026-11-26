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
    public partial class FormCustomer: Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        dbConnection dbcon = new dbConnection();
        SqlDataReader dr;
        string title = "Fruits Shop";
        public FormCustomer()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            LoadCustomer();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormCustomerModule module = new FormCustomerModule(this);
            module.ShowDialog();    

        }

        private void dataGridViewFormCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String columnName = dataGridViewFormCustomer.Columns[e.ColumnIndex].Name;
            if (columnName == "Edit")
            {
                FormCustomerModule module = new FormCustomerModule(this);
                module.lblCid.Text = dataGridViewFormCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtName.Text = dataGridViewFormCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtAddress.Text = dataGridViewFormCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtPhone.Text = dataGridViewFormCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.ShowDialog();

            }
            else if (columnName == "Delete")
            {
                if (MessageBox.Show("Are you sure?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.executeQuery("DELETE FROM tbcustomer WHERE pcode LIKE '" + dataGridViewFormCustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    MessageBox.Show("Customer data has been Successfully removes", title, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
            LoadCustomer();

        }
        #region method
        public void LoadCustomer()
        {
            int i = 0;
            dataGridViewFormCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbCustomer WHERE CONCAT(name,address,phone) LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewFormCustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
        }
        #endregion method
    }
}
