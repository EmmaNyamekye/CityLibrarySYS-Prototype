namespace CityLibrarySYS
{
    partial class frmPayLateFine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayLateFine));
            this.grpLateFine = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPayLateFine = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFineInfo = new System.Windows.Forms.Label();
            this.grpLateFine.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLateFine
            // 
            this.grpLateFine.Controls.Add(this.lblFineInfo);
            this.grpLateFine.Controls.Add(this.btnExit);
            this.grpLateFine.Controls.Add(this.btnPay);
            this.grpLateFine.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLateFine.Location = new System.Drawing.Point(265, 205);
            this.grpLateFine.Name = "grpLateFine";
            this.grpLateFine.Size = new System.Drawing.Size(667, 367);
            this.grpLateFine.TabIndex = 0;
            this.grpLateFine.TabStop = false;
            this.grpLateFine.Text = "Fine Amount";
            // 
            // lblPayLateFine
            // 
            this.lblPayLateFine.AutoSize = true;
            this.lblPayLateFine.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayLateFine.Location = new System.Drawing.Point(80, 86);
            this.lblPayLateFine.Name = "lblPayLateFine";
            this.lblPayLateFine.Size = new System.Drawing.Size(245, 41);
            this.lblPayLateFine.TabIndex = 84;
            this.lblPayLateFine.Text = "Pay Late Fine";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnPay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(150, 267);
            this.btnPay.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(157, 37);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(188)))));
            this.btnExit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(360, 267);
            this.btnExit.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 37);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFineInfo
            // 
            this.lblFineInfo.AutoSize = true;
            this.lblFineInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineInfo.Location = new System.Drawing.Point(67, 87);
            this.lblFineInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFineInfo.Name = "lblFineInfo";
            this.lblFineInfo.Size = new System.Drawing.Size(25, 25);
            this.lblFineInfo.TabIndex = 15;
            this.lblFineInfo.Text = "0";
            // 
            // frmPayLateFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 690);
            this.Controls.Add(this.lblPayLateFine);
            this.Controls.Add(this.grpLateFine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPayLateFine";
            this.Text = "Pay Late Fine";
            this.Load += new System.EventHandler(this.frmPayLateFine_Load);
            this.grpLateFine.ResumeLayout(false);
            this.grpLateFine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLateFine;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPayLateFine;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFineInfo;
    }
}