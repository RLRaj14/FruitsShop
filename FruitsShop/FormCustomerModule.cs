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
    public partial class FormCustomerModule: Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        dbConnection dbcon = new dbConnection();
        String title = "Fruits Shop";

        bool check = false;
        FormCustomer formCustomer;
        public FormCustomerModule(FormCustomer Form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            formCustomer = Form;
        }

        private void lblCid_Click(object sender, EventArgs e)
        {

        }

        private void pnlCustomerModule_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are You Sure To Register This Customer?", "Customer Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("INSERT INTO tbCustomer(name,address,phone)VALUES(@name,@address,@phone)", cn);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                       

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Customer register Succesfully");
                        Clear();
                        formCustomer.LoadCustomer();

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are You Sure To Update This Customer?", "Record Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("UPDATE tbCustomer set name =@name,address=@address,phone=@phone WHERE id=@id", cn);
                        cm.Parameters.AddWithValue("@id", lblCid.Text);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);


                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record Update Succesfully");
                        Clear();
                        formCustomer.LoadCustomer();
                        this.Dispose();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #region method
        public void CheckField()
        {
            if (txtName.Text == "" | txtAddress.Text == "" | txtPhone.Text=="")
            {
                MessageBox.Show("Required data field!", "Warning");
                return;
            }
            check = true;
        }
        public void Clear()
        { 
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }


        #endregion method
    }
}
