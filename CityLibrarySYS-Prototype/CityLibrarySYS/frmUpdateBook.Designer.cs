namespace CityLibrarySYS
{
    partial class frmUpdateBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateBook));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBookId = new System.Windows.Forms.Label();
            this.mnuBackStrip = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.dtpPublication = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboLibraryId = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblLibraryID = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPublication = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.mnuBackStrip.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 80;
            this.label1.Text = "Update Book";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(525, 125);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(272, 133);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(65, 17);
            this.lblBookId.TabIndex = 82;
            this.lblBookId.Text = "Book ID";
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
            this.mnuBackStrip.TabIndex = 100;
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
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.dtpPublication);
            this.grpUpdate.Controls.Add(this.btnSubmit);
            this.grpUpdate.Controls.Add(this.txtDescription);
            this.grpUpdate.Controls.Add(this.cboLibraryId);
            this.grpUpdate.Controls.Add(this.cboGenre);
            this.grpUpdate.Controls.Add(this.lblGenre);
            this.grpUpdate.Controls.Add(this.txtAuthor);
            this.grpUpdate.Controls.Add(this.lblAuthor);
            this.grpUpdate.Controls.Add(this.lblLibraryID);
            this.grpUpdate.Controls.Add(this.txtISBN);
            this.grpUpdate.Controls.Add(this.lblISBN);
            this.grpUpdate.Controls.Add(this.txtTitle);
            this.grpUpdate.Controls.Add(this.lblTitle);
            this.grpUpdate.Controls.Add(this.lblDescription);
            this.grpUpdate.Controls.Add(this.lblPublication);
            this.grpUpdate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdate.Location = new System.Drawing.Point(35, 170);
            this.grpUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Padding = new System.Windows.Forms.Padding(2);
            this.grpUpdate.Size = new System.Drawing.Size(820, 370);
            this.grpUpdate.TabIndex = 101;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update";
            this.grpUpdate.Visible = false;
            // 
            // dtpPublication
            // 
            this.dtpPublication.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPublication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublication.Location = new System.Drawing.Point(597, 59);
            this.dtpPublication.Margin = new System.Windows.Forms.Padding(2);
            this.dtpPublication.MaxDate = new System.DateTime(5000, 1, 1, 0, 0, 0, 0);
            this.dtpPublication.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpPublication.Name = "dtpPublication";
            this.dtpPublication.Size = new System.Drawing.Size(200, 24);
            this.dtpPublication.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnSubmit.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(364, 310);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(447, 119);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(350, 100);
            this.txtDescription.TabIndex = 8;
            // 
            // cboLibraryId
            // 
            this.cboLibraryId.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLibraryId.FormattingEnabled = true;
            this.cboLibraryId.Items.AddRange(new object[] {
            "City Central Library",
            "County Library",
            "Suburb Reading Haven",
            "Village Library",
            "Riverbank Library"});
            this.cboLibraryId.Location = new System.Drawing.Point(597, 248);
            this.cboLibraryId.Name = "cboLibraryId";
            this.cboLibraryId.Size = new System.Drawing.Size(200, 25);
            this.cboLibraryId.TabIndex = 9;
            // 
            // cboGenre
            // 
            this.cboGenre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Items.AddRange(new object[] {
            "Fiction",
            "Non-Fiction",
            "Mystery",
            "Science Fiction",
            "Fantasy",
            "Romance",
            "Thriller",
            "Horror",
            "Adventure",
            "Historical Fiction",
            "Biography",
            "Autobiography",
            "Self-Help",
            "Science",
            "Philosophy"});
            this.cboGenre.Location = new System.Drawing.Point(24, 248);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(350, 25);
            this.cboGenre.TabIndex = 6;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(24, 220);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(50, 17);
            this.lblGenre.TabIndex = 87;
            this.lblGenre.Text = "Genre";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(24, 179);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.MaxLength = 35;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(350, 24);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(24, 160);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(57, 17);
            this.lblAuthor.TabIndex = 86;
            this.lblAuthor.Text = "Author";
            // 
            // lblLibraryID
            // 
            this.lblLibraryID.AutoSize = true;
            this.lblLibraryID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryID.Location = new System.Drawing.Point(444, 250);
            this.lblLibraryID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibraryID.Name = "lblLibraryID";
            this.lblLibraryID.Size = new System.Drawing.Size(77, 17);
            this.lblLibraryID.TabIndex = 85;
            this.lblLibraryID.Text = "Library ID";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(24, 59);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBN.MaxLength = 10;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(350, 24);
            this.txtISBN.TabIndex = 3;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(24, 40);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(43, 17);
            this.lblISBN.TabIndex = 84;
            this.lblISBN.Text = "ISBN";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(24, 119);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.MaxLength = 25;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(350, 24);
            this.txtTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(24, 100);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 17);
            this.lblTitle.TabIndex = 83;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(444, 100);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 17);
            this.lblDescription.TabIndex = 81;
            this.lblDescription.Text = "Description";
            // 
            // lblPublication
            // 
            this.lblPublication.AutoSize = true;
            this.lblPublication.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublication.Location = new System.Drawing.Point(444, 60);
            this.lblPublication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPublication.Name = "lblPublication";
            this.lblPublication.Size = new System.Drawing.Size(82, 17);
            this.lblPublication.TabIndex = 82;
            this.lblPublication.Text = "Publication";
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(357, 130);
            this.txtBookId.Margin = new System.Windows.Forms.Padding(2);
            this.txtBookId.MaxLength = 8;
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(150, 24);
            this.txtBookId.TabIndex = 1;
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.mnuBackStrip);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateBook";
            this.Text = "Update Book";
            this.mnuBackStrip.ResumeLayout(false);
            this.mnuBackStrip.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.MenuStrip mnuBackStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.DateTimePicker dtpPublication;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboLibraryId;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblLibraryID;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPublication;
        private System.Windows.Forms.TextBox txtBookId;
    }
}