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
    public partial class FormUser : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        dbConnection dbcon = new dbConnection();
        SqlDataReader dr;
        string title = "Fruits Shop";
        public FormUser()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.Connection());
            LoadUser();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            FormUserModule module = new FormUserModule(this);
            module.ShowDialog();
        }

        private void dataGridViewFormUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String columnName = dataGridViewFormUser.Columns[e.ColumnIndex].Name;
            if (columnName == "Edit")
            {
                FormUserModule module = new FormUserModule(this);
                module.lblUid.Text = dataGridViewFormUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtName.Text = dataGridViewFormUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtAddress.Text = dataGridViewFormUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtPhone.Text = dataGridViewFormUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.cmbRole.Text = dataGridViewFormUser.Rows[e.RowIndex].Cells[5].Value.ToString();
                module.dtDob.Text = dataGridViewFormUser.Rows[e.RowIndex].Cells[6].Value.ToString();
                module.txtPassword.Text = dataGridViewFormUser.Rows[e.RowIndex].Cells[7].Value.ToString();

                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.ShowDialog();

            }
            else if (columnName =="Delete")
            {
                if(MessageBox.Show("Are you sure?","Delete record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    dbcon.executeQuery("DELETE FROM tbProduct WHERE pcode LIKE '" + dataGridViewFormUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    MessageBox.Show("User data has been Successfully removes",title,MessageBoxButtons.OK,MessageBoxIcon.Question);
                }

            }
            LoadUser();
        }
       

        private void pnlFormUser_Paint(object sender, PaintEventArgs e)
        {

        }
        #region Method
        public void LoadUser()
        {
            int i = 0;
            dataGridViewFormUser.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbUser WHERE CONCAT(name,address,phone,dob,role) LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewFormUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse(dr[5].ToString()).ToShortDateString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        #endregion Method
    }
}
