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
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUser());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProducts());  
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm( new FormCustomer());
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCash(this));
        }

        private void pnlChild_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                this.Dispose();
                login.ShowDialog();
            }
        }
        #region Method
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblTitle.Text = childForm.Text;
            pnlChild.Controls.Add(childForm);
            pnlChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        #endregion Method

    }
}
    

