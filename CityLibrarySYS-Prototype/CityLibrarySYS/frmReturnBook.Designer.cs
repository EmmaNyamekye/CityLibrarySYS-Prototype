namespace CityLibrarySYS
{
    partial class frmReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnBook));
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMemberID = new System.Windows.Forms.Button();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblReturnBook = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.grpBookCart = new System.Windows.Forms.GroupBox();
            this.lblBookCart = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.chkBook2 = new System.Windows.Forms.CheckBox();
            this.chkBook1 = new System.Windows.Forms.CheckBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuBackStrip.SuspendLayout();
            this.grpMemberInfo.SuspendLayout();
            this.grpBookCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuBackStrip.Size = new System.Drawing.Size(884, 30);
            this.mnuBackStrip.TabIndex = 77;
            this.mnuBackStrip.Text = "Back";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(104)))));
            this.mnuBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Margin = new System.Windows.Forms.Padding(3);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(53, 20);
            this.mnuBack.Text = "BACK";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // btnMemberID
            // 
            this.btnMemberID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnMemberID.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberID.Location = new System.Drawing.Point(289, 134);
            this.btnMemberID.Margin = new System.Windows.Forms.Padding(10);
            this.btnMemberID.Name = "btnMemberID";
            this.btnMemberID.Size = new System.Drawing.Size(100, 30);
            this.btnMemberID.TabIndex = 144;
            this.btnMemberID.Text = "SEARCH";
            this.btnMemberID.UseVisualStyleBackColor = false;
            this.btnMemberID.Click += new System.EventHandler(this.btnMemberID_Click);
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Controls.Add(this.lblMemberInfo);
            this.grpMemberInfo.Location = new System.Drawing.Point(430, 67);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpMemberInfo.Size = new System.Drawing.Size(400, 100);
            this.grpMemberInfo.TabIndex = 143;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Member Info";
            this.grpMemberInfo.Visible = false;
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberInfo.Location = new System.Drawing.Point(15, 20);
            this.lblMemberInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(14, 13);
            this.lblMemberInfo.TabIndex = 102;
            this.lblMemberInfo.Text = "0";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberId.Location = new System.Drawing.Point(150, 139);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMemberId.MaxLength = 7;
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(114, 23);
            this.txtMemberId.TabIndex = 140;
            // 
            // lblReturnBook
            // 
            this.lblReturnBook.AutoSize = true;
            this.lblReturnBook.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnBook.Location = new System.Drawing.Point(49, 71);
            this.lblReturnBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnBook.Name = "lblReturnBook";
            this.lblReturnBook.Size = new System.Drawing.Size(182, 32);
            this.lblReturnBook.TabIndex = 142;
            this.lblReturnBook.Text = "Return Book";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(55, 144);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(77, 16);
            this.lblMemberId.TabIndex = 141;
            this.lblMemberId.Text = "Member ID";
            // 
            // grpBookCart
            // 
            this.grpBookCart.Controls.Add(this.lblBookCart);
            this.grpBookCart.Controls.Add(this.btnConfirm);
            this.grpBookCart.Location = new System.Drawing.Point(450, 360);
            this.grpBookCart.Margin = new System.Windows.Forms.Padding(2);
            this.grpBookCart.Name = "grpBookCart";
            this.grpBookCart.Padding = new System.Windows.Forms.Padding(2);
            this.grpBookCart.Size = new System.Drawing.Size(380, 150);
            this.grpBookCart.TabIndex = 150;
            this.grpBookCart.TabStop = false;
            this.grpBookCart.Text = "Book Cart";
            this.grpBookCart.Visible = false;
            // 
            // lblBookCart
            // 
            this.lblBookCart.AutoSize = true;
            this.lblBookCart.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCart.Location = new System.Drawing.Point(15, 20);
            this.lblBookCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookCart.Name = "lblBookCart";
            this.lblBookCart.Size = new System.Drawing.Size(13, 17);
            this.lblBookCart.TabIndex = 123;
            this.lblBookCart.Text = " ";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnConfirm.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(268, 108);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 122;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // chkBook2
            // 
            this.chkBook2.AutoSize = true;
            this.chkBook2.Location = new System.Drawing.Point(815, 247);
            this.chkBook2.Name = "chkBook2";
            this.chkBook2.Size = new System.Drawing.Size(15, 14);
            this.chkBook2.TabIndex = 147;
            this.chkBook2.UseVisualStyleBackColor = true;
            this.chkBook2.Visible = false;
            this.chkBook2.CheckedChanged += new System.EventHandler(this.chkBook2_CheckedChanged);
            // 
            // chkBook1
            // 
            this.chkBook1.AutoSize = true;
            this.chkBook1.Location = new System.Drawing.Point(815, 226);
            this.chkBook1.Name = "chkBook1";
            this.chkBook1.Size = new System.Drawing.Size(15, 14);
            this.chkBook1.TabIndex = 146;
            this.chkBook1.UseVisualStyleBackColor = true;
            this.chkBook1.Visible = false;
            this.chkBook1.CheckedChanged += new System.EventHandler(this.chkBook1_CheckedChanged);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitle,
            this.colAuthor});
            this.dgvResults.Enabled = false;
            this.dgvResults.Location = new System.Drawing.Point(55, 200);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.Size = new System.Drawing.Size(755, 125);
            this.dgvResults.TabIndex = 145;
            this.dgvResults.Visible = false;
            // 
            // colId
            // 
            this.colId.Frozen = true;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 200;
            // 
            // colTitle
            // 
            this.colTitle.Frozen = true;
            this.colTitle.HeaderText = "Title";
            this.colTitle.MinimumWidth = 6;
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 250;
            // 
            // colAuthor
            // 
            this.colAuthor.Frozen = true;
            this.colAuthor.HeaderText = "Author";
            this.colAuthor.MinimumWidth = 6;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            this.colAuthor.Width = 250;
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.grpBookCart);
            this.Controls.Add(this.chkBook2);
            this.Controls.Add(this.chkBook1);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnMemberID);
            this.Controls.Add(this.grpMemberInfo);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lblReturnBook);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.mnuBackStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReturnBook";
            this.Text = "Return Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.grpBookCart.ResumeLayout(false);
            this.grpBookCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnMemberID;
        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblReturnBook;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.GroupBox grpBookCart;
        private System.Windows.Forms.Label lblBookCart;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.CheckBox chkBook2;
        private System.Windows.Forms.CheckBox chkBook1;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
    }
}