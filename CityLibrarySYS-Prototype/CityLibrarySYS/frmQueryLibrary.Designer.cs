namespace CityLibrarySYS
{
    partial class frmQueryLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryLibrary));
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboLibraryID = new System.Windows.Forms.ComboBox();
            this.lblQueryLibrary = new System.Windows.Forms.Label();
            this.lblLibaryId = new System.Windows.Forms.Label();
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLibraryInfo = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblLibraryInfo = new System.Windows.Forms.Label();
            this.mnuBackStrip.SuspendLayout();
            this.grpLibraryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(707, 154);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 37);
            this.btnSearch.TabIndex = 84;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboLibraryID
            // 
            this.cboLibraryID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLibraryID.FormattingEnabled = true;
            this.cboLibraryID.Items.AddRange(new object[] {
            "City Central Library",
            "County Library",
            "Suburb Reading Haven",
            "Village Library",
            "Riverbank Library"});
            this.cboLibraryID.Location = new System.Drawing.Point(473, 160);
            this.cboLibraryID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLibraryID.Name = "cboLibraryID";
            this.cboLibraryID.Size = new System.Drawing.Size(212, 26);
            this.cboLibraryID.TabIndex = 81;
            // 
            // lblQueryLibrary
            // 
            this.lblQueryLibrary.AutoSize = true;
            this.lblQueryLibrary.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueryLibrary.Location = new System.Drawing.Point(80, 86);
            this.lblQueryLibrary.Name = "lblQueryLibrary";
            this.lblQueryLibrary.Size = new System.Drawing.Size(252, 41);
            this.lblQueryLibrary.TabIndex = 83;
            this.lblQueryLibrary.Text = "Query Library";
            // 
            // lblLibaryId
            // 
            this.lblLibaryId.AutoSize = true;
            this.lblLibaryId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibaryId.Location = new System.Drawing.Point(360, 166);
            this.lblLibaryId.Name = "lblLibaryId";
            this.lblLibaryId.Size = new System.Drawing.Size(95, 20);
            this.lblLibaryId.TabIndex = 82;
            this.lblLibaryId.Text = "Library ID";
            // 
            // mnuBackStrip
            // 
            this.mnuBackStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.mnuBackStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBackStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuBackStrip.Name = "mnuBackStrip";
            this.mnuBackStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuBackStrip.Size = new System.Drawing.Size(1179, 34);
            this.mnuBackStrip.TabIndex = 85;
            this.mnuBackStrip.Text = "Back";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(104)))));
            this.mnuBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Margin = new System.Windows.Forms.Padding(3);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(71, 24);
            this.mnuBack.Text = "BACK";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpLibraryInfo
            // 
            this.grpLibraryInfo.Controls.Add(this.btnOk);
            this.grpLibraryInfo.Controls.Add(this.lblLibraryInfo);
            this.grpLibraryInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLibraryInfo.Location = new System.Drawing.Point(160, 246);
            this.grpLibraryInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLibraryInfo.Name = "grpLibraryInfo";
            this.grpLibraryInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpLibraryInfo.Size = new System.Drawing.Size(867, 369);
            this.grpLibraryInfo.TabIndex = 86;
            this.grpLibraryInfo.TabStop = false;
            this.grpLibraryInfo.Text = "Library Information";
            this.grpLibraryInfo.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(380, 295);
            this.btnOk.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 37);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblLibraryInfo
            // 
            this.lblLibraryInfo.AutoSize = true;
            this.lblLibraryInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryInfo.Location = new System.Drawing.Point(120, 62);
            this.lblLibraryInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibraryInfo.Name = "lblLibraryInfo";
            this.lblLibraryInfo.Size = new System.Drawing.Size(25, 25);
            this.lblLibraryInfo.TabIndex = 1;
            this.lblLibraryInfo.Text = "0";
            // 
            // frmQueryLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.mnuBackStrip);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboLibraryID);
            this.Controls.Add(this.lblQueryLibrary);
            this.Controls.Add(this.lblLibaryId);
            this.Controls.Add(this.grpLibraryInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQueryLibrary";
            this.Text = "Query Library";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpLibraryInfo.ResumeLayout(false);
            this.grpLibraryInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboLibraryID;
        private System.Windows.Forms.Label lblQueryLibrary;
        private System.Windows.Forms.Label lblLibaryId;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpLibraryInfo;
        private System.Windows.Forms.Label lblLibraryInfo;
        private System.Windows.Forms.Button btnOk;
    }
}