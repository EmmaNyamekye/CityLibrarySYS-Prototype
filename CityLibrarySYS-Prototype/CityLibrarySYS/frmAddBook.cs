using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CityLibrarySYS
{
    public partial class frmAddBook : Form
    {
        frmMainManu parent;

        public frmAddBook()
        {
            InitializeComponent();
        }

        public frmAddBook(frmMainManu parent)
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
            //Validate if all fields are entered
            if (txtISBN.Text.Equals("") || txtTitle.Text.Equals("") || txtAuthor.Text.Equals("") ||
                cboGenre.Text.Equals("") || dtpPublication.Text.Equals("") || txtDescription.Text.Equals("") ||
                cboLibraryID.Text.Equals(""))
            {
                MessageBox.Show("All Fields Must Be Entered!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Validate if ISBN is valid
            if (!isValidISBN(txtISBN.Text))
            {
                MessageBox.Show("Invalid ISBN! ISBN must be a valid 10-digit ISBN.",
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                txtISBN.Focus();
                return;
            }

            // Validate if Title, Author and Description are valid
            else if  (txtTitle.Text.All(char.IsDigit))
            {
                MessageBox.Show("Invalid title! Title must not be numeric!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            else if (txtAuthor.Text.All(char.IsDigit))
            {
                MessageBox.Show("Invalid author! Author must not be numeric!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtAuthor.Focus();
                return;
            }

            else if (txtDescription.Text.All(char.IsDigit))
            {
                MessageBox.Show("Invalid description! Description must not be numeric!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            else
            {
                MessageBox.Show(txtTitle.Text + " Has Been Added to Books File",
                                "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtISBN.Clear();
                txtTitle.Clear();
                txtAuthor.Clear();
                cboGenre.Items.Clear();
                dtpPublication.Text = "";
                txtDescription.Clear();
                cboLibraryID.Text = "";
            }

        }
        static bool isValidISBN(string isbn)
        {
            // length must be 10 
            int n = isbn.Length;
            if (n != 10)
                return false;

            // Computing weighted sum of  
            // first 9 digits 
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = isbn[i] - '0';

                if (0 > digit || 9 < digit)
                    return false;

                sum += (digit * (10 - i));
            }

            // Checking last digit. 
            char last = isbn[9];
            if (last != 'X' && (last < '0'
                             || last > '9'))
                return false;

            // If last digit is 'X', add 10  
            // to sum, else add its value. 
            sum += ((last == 'X') ? 10 :
                              (last - '0'));

            // Return true if weighted sum  
            // of digits is divisible by 11. 
            return (sum % 11 == 0);
        }

        /*
            Title: Program to check for ISBN
            Author: dewangNautiyal
            Site ownwer/sponcer: geeksforgeeks
            Date: 17 Feb, 2023
            Availability: https://www.geeksforgeeks.org/program-check-isbn/
            (Accessed 06/12/2023)
            Modified: No
        */
    }
}
