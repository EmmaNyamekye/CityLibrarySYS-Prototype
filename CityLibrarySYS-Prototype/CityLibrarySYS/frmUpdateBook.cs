using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CityLibrarySYS
{
    public partial class frmUpdateBook : Form
    {
        frmMainManu parent;

        public frmUpdateBook()
        {
            InitializeComponent();
        }

        public frmUpdateBook(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtBookId.Text == "A0000000")
            {
                grpUpdate.Visible = true;
                txtISBN.Text = "812911612X";
                txtTitle.Text = "Animal Farm";
                txtAuthor.Text = "George Orwell";
                cboGenre.Text = "Novel";
                dtpPublication.Text = "17/08/1945";
                txtDescription.Text = "Animal Farm is a beast fable, in the form of a satirical allegorical novella";
                cboLibraryId.Text = "City Central Library";
            }
            else if (txtBookId.Text == "A0000001")
            {
                grpUpdate.Visible = true;
                txtISBN.Text = "1368051472";
                txtTitle.Text = "Percy Jackson & the Olympians";
                txtAuthor.Text = "Rick Riordan";
                cboGenre.Text = "Finction";
                dtpPublication.Text = "28/06/2005";
                txtDescription.Text = "Twelve-year-old Percy Jackson is on the most dangerous quest of his life.";
                cboLibraryId.Text = "County Library";
            }
            else if (txtBookId.Text == "A0000002")
            {
                grpUpdate.Visible = true;
                txtISBN.Text = "0345447832";
                txtTitle.Text = "The Surgeon";
                txtAuthor.Text = "Tess Gerritsen";
                cboGenre.Text = "Crime";
                dtpPublication.Text = "01/01/2001";
                txtDescription.Text = "A killer who targets lone women, who breaks into their apartments and performs terrifying ritualistic acts of torture on them before finishing them off.";
                cboLibraryId.Text = "Suburb Reading Haven";
            }
            else
            {
                MessageBox.Show("Invalid BookId!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                txtBookId.Focus();
                grpUpdate.Visible = false;
                return;
            }
         
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
                cboLibraryId.Text.Equals(""))
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
            else if (txtTitle.Text.All(char.IsDigit))
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
                MessageBox.Show("Book Has Been Updated into the Books File",
                                "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtBookId.Clear();
                txtISBN.Clear();
                txtTitle.Clear();
                txtAuthor.Clear();
                cboGenre.Items.Clear();
                dtpPublication.Text = "";
                txtDescription.Clear();
                cboLibraryId.Text = "";
                grpUpdate.Visible = false;
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
    }
}
