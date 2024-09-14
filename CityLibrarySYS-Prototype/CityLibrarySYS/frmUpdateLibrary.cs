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
    public partial class frmUpdateLibrary : Form
    {
        frmMainManu parent;

        public frmUpdateLibrary()
        {
            InitializeComponent();
        }

        public frmUpdateLibrary(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void updateLibrary_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
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
                MessageBox.Show("Library " + txtName.Text + " Has Been Updated Into The Libraries File",
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
                cboLibraryID.Text = "";
                grpUpdate.Visible = false;  
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboLibraryID.SelectedIndex != -1)
            {
                // Enable text boxes
                grpUpdate.Visible = true;

                if (cboLibraryID.SelectedIndex == 0)
                {
                    txtName.Text = "City Central Library";
                    txtStreet.Text = "Maple Avenue";
                    txtTown.Text = "Galway City";
                    txtCounty.Text = "Galway";
                    txtEircode.Text = "A65F4E2";
                    txtPhone.Text = "0655512345";
                    txtEmail.Text = "central.library@city.library.ie";
                    txtSupervisor.Text = "John Smith";
                }
                else if (cboLibraryID.SelectedIndex == 1)
                {
                    txtName.Text = "County Library";
                    txtStreet.Text = "Main Street";
                    txtTown.Text = "Ennis";
                    txtCounty.Text = "Clare";
                    txtEircode.Text = "V93E0X2";
                    txtPhone.Text = "0655812345";
                    txtEmail.Text = "county.library@city.library.ie";
                    txtSupervisor.Text = "Zelda Hyrule";
                }
                else if (cboLibraryID.SelectedIndex == 2)
                {
                    txtName.Text = "Suburb Reading Haven";
                    txtStreet.Text = "High Street";
                    txtTown.Text = "Limerick";
                    txtCounty.Text = "Limerick";
                    txtEircode.Text = "D04V4X7";
                    txtPhone.Text = "0655912345";
                    txtEmail.Text = "reading.haven@city.library.ie";
                    txtSupervisor.Text = "Maria Rossi";
                }
                else if (cboLibraryID.SelectedIndex == 3)
                {
                    txtName.Text = "Village Library";
                    txtStreet.Text = "Church Street";
                    txtTown.Text = "Kilrush";
                    txtCounty.Text = "Clare";
                    txtEircode.Text = "D08VF8H";
                    txtPhone.Text = "0655712345";
                    txtEmail.Text = "village.library@city.library.ie";
                    txtSupervisor.Text = "Max Mustermann";
                }
                else if (cboLibraryID.SelectedIndex == 4)
                {
                    txtName.Text = "Riverbank Library";
                    txtStreet.Text = "Riverside Avenue";
                    txtTown.Text = "Castleconnell";
                    txtCounty.Text = "Limerick";
                    txtEircode.Text = "A65F4E2";
                    txtPhone.Text = "0655591234";
                    txtEmail.Text = "riverbank.library@city.library.ie";
                    txtSupervisor.Text = "Luigi Bros";
                }
            }

        }
    }
}
