using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityLibrarySYS
{
    public partial class frmRegisterMember : Form
    {
        frmMainManu parent;

        public frmRegisterMember()
        {
            InitializeComponent();
        }

        public frmRegisterMember(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            // Validate if all fields are entered
            if (txtForename.Text.Equals("") || txtSurname.Text.Equals("") || dtpDateBirth.Text.Equals("") ||
                txtStreet.Text.Equals("") || txtTown.Text.Equals("") || txtCounty.Text.Equals("") ||
                txtEircode.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //Validate phone and eircode length
            else if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone must be 10 characters long!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            else if (txtEircode.Text.Length != 7)
            {
                MessageBox.Show("Ericode must be 7 characters long!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }

            // Validate if fields are not numeric
            else if (txtForename.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Forename cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtForename.Focus();
                return;
            }
            else if (txtSurname.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Surname cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }
            else if (txtStreet.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Street cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }
            else if (txtTown.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Town cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }
            else if (txtCounty.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("County cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }

            //Validate if Eircode is valid
            string eircode = txtEircode.Text;

            //Define Pattern for Eircode Validation
            string eircodePattern = @"(?:^[AC-FHKNPRTV-Y][0-9]{2}|D6W)[ -]?[0-9AC-FHKNPRTV-Y]{4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(eircode, eircodePattern))
            {
                MessageBox.Show("Invalid Eircode format! Eircode must be all capital letters with no spaces",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }

            //Validate if Phone is numeric and starts with '06'
            else if (!txtPhone.Text.All(char.IsDigit) || !txtPhone.Text.StartsWith("06"))
            {
                MessageBox.Show("Phone number is invalid! Phone has to be all digits and start with 06",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            // Validate if email is valid
            string email = txtEmail.Text;

            // Define Pattern for email validation
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            else
            {
                MessageBox.Show(txtForename.Text + " " + txtSurname.Text + " Has Been Added To Members File",
                                "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtForename.Clear();
                txtSurname.Clear();
                txtStreet.Clear();
                txtTown.Clear();
                txtCounty.Clear();
                txtEircode.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
            }
        }

    }
}
