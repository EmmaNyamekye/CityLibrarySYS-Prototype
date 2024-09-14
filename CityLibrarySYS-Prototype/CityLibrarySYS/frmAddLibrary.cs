using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CityLibrarySYS
{
    public partial class frmAddLibrary : Form
    {
        frmMainManu parent;

        public frmAddLibrary()
        {
            InitializeComponent();
        }

        public frmAddLibrary(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validate if all fields are entered
            if (txtName.Text.Equals("") || txtStreet.Text.Equals("") || txtTown.Text.Equals("") ||
                txtCounty.Text.Equals("") || txtEircode.Text.Equals("") || txtPhone.Text.Equals("") ||
                txtEmail.Text.Equals("") || txtSupervisor.Equals(""))
            {
                MessageBox.Show("All Fields Must Be Entered!",
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

            //Validate if Name, Street, Town, County and Supervisor are Not Numeric
            else if (txtName.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Name cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtName.Focus();
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
                MessageBox.Show("Street cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }
            else if (txtCounty.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Street cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }
            else if (txtSupervisor.Text.All(c => char.IsDigit(c)))
            {
                MessageBox.Show("Street cannot be numeric!",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                txtSupervisor.Focus();
                return;
            }

            //Validate if Eircode is valid
            string eircode = txtEircode.Text;

            //Define Pattern for Eircode Validation
            string eircodePattern = @"(?:^[AC-FHKNPRTV-Y][0-9]{2}|D6W)[ -]?[0-9AC-FHKNPRTV-Y]{4}$"; ;
            
             /*
             Title: Validation for Irish Eircode
             Author: Asunez
             Site ownwer/sponcer: Stackoverflow
             Date: Oct 29, 2015
             Code version: edited Mar 26, 2021 by user Andrew
             Availability: https://stackoverflow.com/questions/33391412/validation-for-irish-eircode
             (Accessed 25/11/2023)
             Modified: No*/

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
                MessageBox.Show("Library " + txtName.Text + " Has Been Added To The Libraries File",
                                "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtName.Clear();
                txtStreet.Clear();
                txtTown.Clear();
                txtCounty.Clear();
                txtEircode.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtSupervisor.Clear();
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
