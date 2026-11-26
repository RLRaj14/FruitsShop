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
using System.Xml.Linq;

namespace FruitsShop
{
    public partial class FormLogin: Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        dbConnection dbcon = new dbConnection();
        SqlDataReader dr;
        string title = "Fruits Shop";
        FormMain main;
        public FormLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            //main = form;
            //getTransno();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string _name = "", _role = "";
                cn.Open();
                cm = new SqlCommand("SELECT name,role FROM tbUser WHERE name=@name and password=@password", cn);
                cm.Parameters.AddWithValue("@name", txtUserName.Text);
                cm.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    _name = dr["name"].ToString();
                    _role = dr["role"].ToString();
                    MessageBox.Show("Welcome  " + _name + " |", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   FormMain main = new FormMain();
                    main.lblUsername.Text = _name;
                    main.lblRole.Text = _role;
                    if (_role == "Administrator")
                        main.btnUser.Enabled = true;
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username and password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your Boss!","Forget Password",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
