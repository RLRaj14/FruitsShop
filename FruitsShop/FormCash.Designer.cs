namespace FruitsShop
{
    partial class FormCash
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFormCash = new System.Windows.Forms.DataGridView();
            this.pnlFormUser = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.lblTotalprice = new System.Windows.Forms.Label();
            this.lblTransno = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormCash)).BeginInit();
            this.pnlFormUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFormCash
            // 
            this.dataGridViewFormCash.AllowUserToAddRows = false;
            this.dataGridViewFormCash.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewFormCash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFormCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFormCash.ColumnHeadersHeight = 34;
            this.dataGridViewFormCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewFormCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Edit,
            this.Delete});
            this.dataGridViewFormCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFormCash.EnableHeadersVisualStyles = false;
            this.dataGridViewFormCash.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewFormCash.Location = new System.Drawing.Point(0, 41);
            this.dataGridViewFormCash.Name = "dataGridViewFormCash";
            this.dataGridViewFormCash.RowHeadersVisible = false;
            this.dataGridViewFormCash.RowHeadersWidth = 62;
            this.dataGridViewFormCash.RowTemplate.Height = 28;
            this.dataGridViewFormCash.Size = new System.Drawing.Size(978, 203);
            this.dataGridViewFormCash.TabIndex = 3;
            this.dataGridViewFormCash.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFormCash_CellContentClick);
            // 
            // pnlFormUser
            // 
            this.pnlFormUser.Controls.Add(this.btnCash);
            this.pnlFormUser.Controls.Add(this.lblPrice);
            this.pnlFormUser.Controls.Add(this.lblTransno);
            this.pnlFormUser.Controls.Add(this.lblTotalprice);
            this.pnlFormUser.Controls.Add(this.lblTransaction);
            this.pnlFormUser.Controls.Add(this.lblProduct);
            this.pnlFormUser.Controls.Add(this.btnAdd);
            this.pnlFormUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormUser.Location = new System.Drawing.Point(0, 0);
            this.pnlFormUser.Name = "pnlFormUser";
            this.pnlFormUser.Size = new System.Drawing.Size(978, 41);
            this.pnlFormUser.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAdd.Location = new System.Drawing.Point(13, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduct.Location = new System.Drawing.Point(81, 7);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(75, 26);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Product ";
            this.lblProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.Location = new System.Drawing.Point(298, 13);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(100, 20);
            this.lblTransaction.TabIndex = 3;
            this.lblTransaction.Text = "Transaction :";
            // 
            // lblTotalprice
            // 
            this.lblTotalprice.AutoSize = true;
            this.lblTotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalprice.Location = new System.Drawing.Point(562, 9);
            this.lblTotalprice.Name = "lblTotalprice";
            this.lblTotalprice.Size = new System.Drawing.Size(91, 20);
            this.lblTotalprice.TabIndex = 4;
            this.lblTotalprice.Text = "Total Price :";
            // 
            // lblTransno
            // 
            this.lblTransno.Location = new System.Drawing.Point(391, 11);
            this.lblTransno.Name = "lblTransno";
            this.lblTransno.Size = new System.Drawing.Size(98, 27);
            this.lblTransno.TabIndex = 5;
            this.lblTransno.Text = "00000";
            this.lblTransno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTransno.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(659, 6);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 27);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "0.0000";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCash.Location = new System.Drawing.Point(853, 3);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(86, 33);
            this.btnCash.TabIndex = 7;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 65;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "CashId";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Pcode";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 93;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Name";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Quantity";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Price";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 83;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Total";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 83;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Customer Name";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 171;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cashier";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Width = 8;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Width = 66;
            // 
            // FormCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 244);
            this.Controls.Add(this.dataGridViewFormCash);
            this.Controls.Add(this.pnlFormUser);
            this.Name = "FormCash";
            this.Text = "FormCash";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormCash)).EndInit();
            this.pnlFormUser.ResumeLayout(false);
            this.pnlFormUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFormUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTotalprice;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        public System.Windows.Forms.Label lblTransno;
        public System.Windows.Forms.DataGridView dataGridViewFormCash;
    }
}