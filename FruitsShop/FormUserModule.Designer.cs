namespace FruitsShop
{
    partial class FormUserModule
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
            this.pnlUserModule = new System.Windows.Forms.Panel();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblUid = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserRegistration = new System.Windows.Forms.Label();
            this.pnlUserModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUserModule
            // 
            this.pnlUserModule.Controls.Add(this.dtDob);
            this.pnlUserModule.Controls.Add(this.cmbRole);
            this.pnlUserModule.Controls.Add(this.lblUid);
            this.pnlUserModule.Controls.Add(this.btnClear);
            this.pnlUserModule.Controls.Add(this.btnUpdate);
            this.pnlUserModule.Controls.Add(this.btnSave);
            this.pnlUserModule.Controls.Add(this.txtPassword);
            this.pnlUserModule.Controls.Add(this.lblPassword);
            this.pnlUserModule.Controls.Add(this.txtAddress);
            this.pnlUserModule.Controls.Add(this.lblAddress);
            this.pnlUserModule.Controls.Add(this.txtPhone);
            this.pnlUserModule.Controls.Add(this.lblPhone);
            this.pnlUserModule.Controls.Add(this.lblRole);
            this.pnlUserModule.Controls.Add(this.lblDateOfBirth);
            this.pnlUserModule.Controls.Add(this.txtName);
            this.pnlUserModule.Controls.Add(this.lblName);
            this.pnlUserModule.Controls.Add(this.lblUserRegistration);
            this.pnlUserModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserModule.Location = new System.Drawing.Point(0, 0);
            this.pnlUserModule.Name = "pnlUserModule";
            this.pnlUserModule.Size = new System.Drawing.Size(778, 544);
            this.pnlUserModule.TabIndex = 0;
            this.pnlUserModule.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUserModule_Paint_1);
            // 
            // dtDob
            // 
            this.dtDob.CustomFormat = "dd-MM-yyyy";
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDob.Location = new System.Drawing.Point(149, 381);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(346, 26);
            this.dtDob.TabIndex = 4;
            this.dtDob.ValueChanged += new System.EventHandler(this.dtDob_ValueChanged);
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Cashier",
            "Employee"});
            this.cmbRole.Location = new System.Drawing.Point(149, 315);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(346, 28);
            this.cmbRole.TabIndex = 3;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // lblUid
            // 
            this.lblUid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUid.AutoSize = true;
            this.lblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUid.Location = new System.Drawing.Point(10, 510);
            this.lblUid.Name = "lblUid";
            this.lblUid.Size = new System.Drawing.Size(37, 22);
            this.lblUid.TabIndex = 16;
            this.lblUid.Text = "UId";
            this.lblUid.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.Location = new System.Drawing.Point(568, 497);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(429, 497);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSave.Location = new System.Drawing.Point(295, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(149, 445);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(346, 28);
            this.txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(9, 448);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 26);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password :";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(149, 183);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(346, 28);
            this.txtAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 184);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(104, 26);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address :";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(149, 250);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(346, 28);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(30, 250);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(87, 26);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone :";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(48, 316);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(69, 26);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role :";
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(12, 384);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(124, 22);
            this.lblDateOfBirth.TabIndex = 3;
            this.lblDateOfBirth.Text = "Date Of Birth :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(149, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(346, 28);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(34, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblUserRegistration
            // 
            this.lblUserRegistration.AutoSize = true;
            this.lblUserRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRegistration.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblUserRegistration.Location = new System.Drawing.Point(24, 30);
            this.lblUserRegistration.Name = "lblUserRegistration";
            this.lblUserRegistration.Size = new System.Drawing.Size(250, 32);
            this.lblUserRegistration.TabIndex = 0;
            this.lblUserRegistration.Text = "User Registration";
            this.lblUserRegistration.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormUserModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.pnlUserModule);
            this.Name = "FormUserModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserModule";
            this.Load += new System.EventHandler(this.FormUserModule_Load);
            this.pnlUserModule.ResumeLayout(false);
            this.pnlUserModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUserModule;
        private System.Windows.Forms.Label lblUserRegistration;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.ComboBox cmbRole;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Label lblUid;
        public System.Windows.Forms.DateTimePicker dtDob;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
    }
}