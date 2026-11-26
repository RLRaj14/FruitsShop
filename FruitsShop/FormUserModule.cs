using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FruitsShop
{
    public partial class FormUserModule: Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        dbConnection dbcon = new dbConnection();
        String title = "Fruits Shop";
        bool check = false;
        FormUser formUser;
        public FormUserModule(FormUser user)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            formUser = user;
            cmbRole.SelectedIndex = 0;  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                CheckField();
                if(check)
                {
                    if (MessageBox.Show("Are You Sure To Register This User?", "User Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("INSERT INTO tbUser(name,address,phone,role,dob,password)VALUES(@name,@address,@phone,@role,@dob,@password)", cn);
                        cm.Parameters.AddWithValue("@name", txtName.Text);
                        cm.Parameters.AddWithValue("@address", txtAddress.Text);
                        cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cm.Parameters.AddWithValue("@role", cmbRole.Text);
                        cm.Parameters.AddWithValue("@dob", dtDob.Value);
                        cm.Parameters.AddWithValue("@password", txtPassword.Text);
                         
                        cn.Open();
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("User register Succesfully");
                        Clear();
                        formUser.LoadUser();

                    }


                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                
            }

        }

        private void pnlUserModule_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
       
        private void pnlUserModule_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CheckField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to update this record?", "Edit Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbUser SET name=@name, address=@address, phone=@phone, role=@role, dob=@dob, password=@password WHERE id=@id", cn);
                    cm.Parameters.AddWithValue("@id", lblUid.Text);
                    cm.Parameters.AddWithValue("@name", txtName.Text);
                    cm.Parameters.AddWithValue("@address", txtAddress.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@role", cmbRole.Text);
                    cm.Parameters.AddWithValue("@dob", dtDob.Value);
                    cm.Parameters.AddWithValue("@password", txtPassword.Text);

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("User's data has been successfully updated!", title);
                    Clear();

                    formUser.LoadUser();
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

        private void FormUserModule_Load(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRole.Text == "Employee")

            {
               
                lblPassword.Visible = false;
                txtPassword.Visible = false;

            }
            else
            {
                
                lblPassword.Visible = true;
                txtPassword.Visible = true;

            }

        }
       

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
        #region Method

        public void Clear()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
            dtDob.Value = DateTime.Now;

            btnUpdate.Enabled = false;
        }

        //to check field and date of birth
        public void CheckField()
        {
            if (txtName.Text == "" | txtAddress.Text == "")
            {
                MessageBox.Show("Required data field!", "Warning");
                return;
            }

            if (checkAGe(dtDob.Value) < 18)
            {
                MessageBox.Show("User is child worker!. Under 18 year", "Warning");
                return;
            }
            check = true;
        }

        // to Calculate Age for under 18 
        private static int checkAGe(DateTime dateofBirth)
        {
            int age = DateTime.Now.Year - dateofBirth.Year;
            if (DateTime.Now.DayOfYear < dateofBirth.DayOfYear)
                age = age - 1;
            return age;
        }
        #endregion Method
    }
}
