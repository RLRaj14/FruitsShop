namespace FruitsShop
{
    partial class FormCustomerModule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCustomerModule = new System.Windows.Forms.Panel();
            this.lblCid = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCustomerRegistration = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnlCustomerModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCustomerModule
            // 
            this.pnlCustomerModule.Controls.Add(this.txtAddress);
            this.pnlCustomerModule.Controls.Add(this.lblCid);
            this.pnlCustomerModule.Controls.Add(this.btnClear);
            this.pnlCustomerModule.Controls.Add(this.btnUpdate);
            this.pnlCustomerModule.Controls.Add(this.btnSave);
            this.pnlCustomerModule.Controls.Add(this.lblAddress);
            this.pnlCustomerModule.Controls.Add(this.txtPhone);
            this.pnlCustomerModule.Controls.Add(this.lblPhone);
            this.pnlCustomerModule.Controls.Add(this.txtName);
            this.pnlCustomerModule.Controls.Add(this.lblName);
            this.pnlCustomerModule.Controls.Add(this.lblCustomerRegistration);
            this.pnlCustomerModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerModule.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomerModule.Name = "pnlCustomerModule";
            this.pnlCustomerModule.Size = new System.Drawing.Size(778, 544);
            this.pnlCustomerModule.TabIndex = 0;
            this.pnlCustomerModule.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustomerModule_Paint);
            // 
            // lblCid
            // 
            this.lblCid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCid.AutoSize = true;
            this.lblCid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCid.Location = new System.Drawing.Point(25, 462);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(37, 22);
            this.lblCid.TabIndex = 46;
            this.lblCid.Text = "Cid";
            this.lblCid.Visible = false;
            this.lblCid.Click += new System.EventHandler(this.lblCid_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.Location = new System.Drawing.Point(648, 456);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 35);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(488, 456);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.Location = new System.Drawing.Point(328, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 35);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(73, 190);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(104, 26);
            this.lblAddress.TabIndex = 44;
            this.lblAddress.Text = "Address :";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(242, 260);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(346, 28);
            this.txtPhone.TabIndex = 36;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(92, 261);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(87, 26);
            this.lblPhone.TabIndex = 43;
            this.lblPhone.Text = "Phone :";
            // 
            // lblCustomerRegistration
            // 
            this.lblCustomerRegistration.AutoSize = true;
            this.lblCustomerRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerRegistration.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCustomerRegistration.Location = new System.Drawing.Point(41, 19);
            this.lblCustomerRegistration.Name = "lblCustomerRegistration";
            this.lblCustomerRegistration.Size = new System.Drawing.Size(317, 32);
            this.lblCustomerRegistration.TabIndex = 41;
            this.lblCustomerRegistration.Text = "Customer Registration";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(96, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 26);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(242, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(346, 28);
            this.txtName.TabIndex = 34;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(242, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(346, 28);
            this.txtAddress.TabIndex = 47;
            // 
            // FormCustomerModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.pnlCustomerModule);
            this.Name = "FormCustomerModule";
            this.Text = "FormCustomerModule";
            this.pnlCustomerModule.ResumeLayout(false);
            this.pnlCustomerModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomerModule;
        public System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCustomerRegistration;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtAddress;
    }
}