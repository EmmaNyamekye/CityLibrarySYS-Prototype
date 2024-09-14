using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibrarySYS
{
    public partial class frmPayLateFine : Form
    {
        public frmPayLateFine()
        {
            InitializeComponent();
        }

        private void frmPayLateFine_Load(object sender, EventArgs e)
        {
            lblFineInfo.Text = frmReturnBook.SetValueForLabel;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Book Has Now Been Paid!",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            this.Close();
            frmMainManu parent = new frmMainManu();
            parent.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately the Member will have to make the payment at a later date and return the book on that date!",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            this.Close();
            frmMainManu parent = new frmMainManu();
            parent.Show();
        }
    }
}
