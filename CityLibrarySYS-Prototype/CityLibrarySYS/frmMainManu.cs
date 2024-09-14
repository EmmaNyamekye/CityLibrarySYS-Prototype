using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibrarySYS
{
    public partial class frmMainManu : Form
    {
        public frmMainManu()
        { 
            InitializeComponent();
        }

        private void addLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddLibrary nextForm = new frmAddLibrary(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateLibrary_Click(object sender, EventArgs e)
        {
            frmUpdateLibrary nextForm = new frmUpdateLibrary(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuAddMember_Click(object sender, EventArgs e)
        {
            frmRegisterMember nextForm = new frmRegisterMember(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook nextForm = new frmAddBook(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuQueryLibrary_Click(object sender, EventArgs e)
        {
            frmQueryLibrary nextForm = new frmQueryLibrary(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuDeregisterMember_Click(object sender, EventArgs e)
        {
            frmDeregisterMember nextForm = new frmDeregisterMember(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            frmUpdateMember nextForm = new frmUpdateMember(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateBook_Click(object sender, EventArgs e)
        {
            frmUpdateBook nextForm = new frmUpdateBook(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuRemoveBook_Click(object sender, EventArgs e)
        {
            frmRemoveBook nextForm = new frmRemoveBook(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuReserveBook_Click(object sender, EventArgs e)
        {
            lblResult1 nextForm = new lblResult1(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuCollectBook_Click(object sender, EventArgs e)
        {
            frmCollectBook nextForm = new frmCollectBook(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuReturnBook_Click(object sender, EventArgs e)
        {
            frmReturnBook nextForm = new frmReturnBook(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuLibraryPopularity_Click(object sender, EventArgs e)
        {
            frmLibraryPopularity nextForm = new frmLibraryPopularity(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuGenrePopularity_Click(object sender, EventArgs e)
        {
            frmGenrePopularity nextForm = new frmGenrePopularity(this);
            this.Hide();
            nextForm.Show();
        }
    }
}
