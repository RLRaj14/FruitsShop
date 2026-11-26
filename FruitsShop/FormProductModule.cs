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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FruitsShop
{
    public partial class FormProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        dbConnection dbcon = new dbConnection();
        string title = "Fruits Shop";
        bool check = false;
        FormProducts formProducts;

        public FormProductModule(FormProducts products)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            formProducts = products;
            cmbCategory.SelectedIndex = 0;
        }

        private void lblUserRegistration_Click(object sender, EventArgs e)
        {

        }

        private void lblPcode_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to register this product?", "Product Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("INSERT INTO tbProduct(pname,category,quantity,price)VALUES(@pname,@category,@quantity,@price)", cn);
                        cm.Parameters.AddWithValue("@pname", txtName.Text);
                        cm.Parameters.AddWithValue("@category", cmbCategory.Text);
                        cm.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                        cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Product register Successfully", title);
                        Clear();
                        formProducts.LoadProduct();
                    }

                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void FormProductModule_Load(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to Update this product?", "Product updated", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("UPDATE tbProduct set pname=pname,category=@catagory,quantity=@quantity,price WHERE  pcode=@pcode", cn);
                        cm.Parameters.AddWithValue("@pcode", txtName.Text);
                        cm.Parameters.AddWithValue("@pname", txtName.Text);
                        cm.Parameters.AddWithValue("@category", cmbCategory.Text);
                        cm.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                        cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Product Update Successfully", title);
                        Clear();
                        formProducts.LoadProduct();
                        this.Dispose();
                    }

                }

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }
        #region Method
        public void Clear()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbCategory.SelectedIndex = 0;

            btnUpdate.Enabled = false;
        }

        public void CheckField()
        {
            if (txtName.Text == "" | txtPrice.Text == "" | txtQuantity.Text == "")
            {
                MessageBox.Show("Required data field!", "Warning");
                return;
            }
            check = true;
        }

        #endregion Method
    }
}

