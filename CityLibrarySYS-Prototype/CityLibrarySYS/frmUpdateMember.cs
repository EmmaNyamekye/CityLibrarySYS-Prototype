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
    public partial class frmUpdateMember : Form
    {
        frmMainManu parent;

        public frmUpdateMember()
        {
            InitializeComponent();
        }

        public frmUpdateMember(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtMemberId.Text == "A000000")
            {
                grpUpdate.Visible = true;
                txtForename.Text = "Sophia";
                txtSurname.Text = "Loren";
                dtpDateBirth.Text = "15/05/1956";
                txtStreet.Text = "Galway Street";
                txtTown.Text = "Galway";
                txtCounty.Text = "Galway City";
                txtEircode.Text = "A65F4E2";
                txtPhone.Text = "0612345678";
                txtEmail.Text = "not.sophia.loren@gmail.it";
            }
            else if (txtMemberId.Text == "A000001")
            {
                grpUpdate.Visible = true;
                txtForename.Text = "Mario";
                txtSurname.Text = "Rossi";
                dtpDateBirth.Text = "23/06/1966";
                txtStreet.Text = "Tenth Street";
                txtTown.Text = "Limerick";
                txtCounty.Text = "Munster";
                txtEircode.Text = "A65F4E1";
                txtPhone.Text = "0687654321";
                txtEmail.Text = "mariorossin1@gmail.com";
            }
            else if (txtMemberId.Text == "A000002")
            {
                grpUpdate.Visible = true;
                txtForename.Text = "Luigi";
                txtSurname.Text = "Bros";
                dtpDateBirth.Text = "06/09/1986";
                txtStreet.Text = "Bros Street";
                txtTown.Text = "Shannon";
                txtCounty.Text = "Munster";
                txtEircode.Text = "A65F4E3";
                txtPhone.Text = "0611223344";
                txtEmail.Text = "luigibros@yahoo.com";
            }
            else if (txtMemberId.Text == "A000003")
            {
                grpUpdate.Visible = true;
                txtForename.Text = "Mario";
                txtSurname.Text = "Bros";
                dtpDateBirth.Text = "25/02/1956";
                txtStreet.Text = "Clare Street";
                txtTown.Text = "Kilrush";
                txtCounty.Text = "Clare";
                txtEircode.Text = "A65F4E7";
                txtPhone.Text = "0611113333";
                txtEmail.Text = "mariobros1@gmail.com";
            }
            else
            {
                MessageBox.Show("Invalid MemberId!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                txtMemberId.Focus();
                return;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
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
                MessageBox.Show(txtForename.Text + " " + txtSurname.Text + " Has Been Updated Into The Members File",
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
                txtMemberId.Clear();
                grpUpdate.Visible = false;
            }
        }
    }
}
