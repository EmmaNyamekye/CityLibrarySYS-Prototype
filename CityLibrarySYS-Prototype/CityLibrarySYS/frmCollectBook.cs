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
    public partial class frmCollectBook : Form
    {
        frmMainManu parent;

        public frmCollectBook()
        {
            InitializeComponent();
        }

        public frmCollectBook(frmMainManu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnMemberID_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "A000000" || txtMemberId.Text == "A000001" ||
                txtMemberId.Text == "A000002" || txtMemberId.Text == "A000003")
            {
                // Enable text boxes
                grpMemberInfo.Visible = true;
                lblTitle.Visible = true;
                txtTitle.Visible = true;
                btnSearchTitle.Visible = true;

                if (txtMemberId.Text == "A000000")
                {
                    lblMemberInfo.Text = "Name: Sophia Loren        Phone: 0612345678" +
                        "\n\nAddress:  Galway Street 1, A65F4E2, Galway, Galway City" +
                        "\n\nEmail: not.sophia.loren@gmail.it";
                }
                else if (txtMemberId.Text == "A000001")
                {
                    lblMemberInfo.Text = "Name: Mario Rossi         Phone: 0687654321" +
                        "\n\nAddress: Tenth Street 2, A65F4E1, Limerick, Munster" +
                        "\n\nEmail: mariorossin1@gmail.com";
                }
                else if (txtMemberId.Text == "A000002")
                {
                    lblMemberInfo.Text = "Name: Luigi Bros          Phone: 0611223344" +
                        "\n\nAddress: Bros Street 3, A65F4E3, Shannon, Munster" +
                        "\n\nEmail: luigibros@yahoo.com";
                }
                else if (txtMemberId.Text == "A000003")
                {
                    lblMemberInfo.Text = "Name: Mario Bros          Phone: 0611113333" +
                        "\n\nAdddress: Clare Street 5, A65F4E7, Kilrush, Clare" +
                        "\n\nEmail: mariobros1@gmail.com";
                }

            }
            else
            {
                MessageBox.Show("Invalid MemberId!",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                txtMemberId.Focus();
                grpMemberInfo.Visible = false;
                lblTitle.Visible = false;
                txtTitle.Visible = false;
                btnSearchTitle.Visible = false;
                grpBookCart.Visible = false;
                return;
            }
        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.ToLower().Contains("the"))
            {
                dgvResults.Visible = true;
                dgvResults.Rows.Clear();
                dgvResults.Rows.Add("A0002340", "The Book Thief", "Markus Zusak", "National Library");
                dgvResults.Rows.Add("A0015678", "The Fault in Our Stars", "John Green", "County Library");
                dgvResults.Rows.Add("A0017890", "The Inferno", "Dante Alighieri", "Village Library");
                dgvResults.Rows.Add("A0017892", "Oliver Twist or, The Parish Boys Progress", "Charles Dickens", "Village Library");

                chkBook1.Visible = true;
                chkBook2.Visible = true;
                chkBook3.Visible = true;
                chkBook4.Visible = true;
                grpBookCart.Visible = true;
            }
            else
            {
                dgvResults.Visible = false;
                chkBook1.Visible = false;
                chkBook2.Visible = false;
                chkBook3.Visible = false;
                chkBook4.Visible = false;
                grpBookCart.Visible = false;
                dgvResults.Rows.Clear();
                MessageBox.Show("No Book found with this title!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }
        }

        private void chkBook1_CheckedChanged(object sender, EventArgs e)
        {
            grpBookCart.Visible = true;
            if (chkBook1.Checked && !lblBookCart.Text.Contains("The Book Thief"))
            {
                grpBookCart.Visible = true;
                lblBookCart.Text += "\nThe Book Thief,  Markus Zusak";
            }
            else if (chkBook1.Checked && lblBookCart.Text.Contains("The Book Thief"))
            {
                lblBookCart.Text += "";
            }
            else if (chkBook1.Checked == false && lblBookCart.Text.Contains("The Book Thief"))
            {
                String text = "\nThe Book Thief,  Markus Zusak";
                int thisPosition = lblBookCart.Text.IndexOf(text);


                if (thisPosition != -1)
                {
                    var theString = new StringBuilder(lblBookCart.Text);

                    for (int i = thisPosition + text.Length - 1; i >= thisPosition; i--)
                    {
                        theString.Remove(i, 1);
                    }
                    lblBookCart.Text = theString.ToString();
                }
            }
        }

        private void chkBook3_CheckedChanged_1(object sender, EventArgs e)
        {
            grpBookCart.Visible = true;
            if (chkBook3.Checked && !lblBookCart.Text.Contains("The Inferno"))
            {
                grpBookCart.Visible = true;
                lblBookCart.Text += "\nThe Inferno,  Dante Alighieri";
            }
            else if (chkBook3.Checked && lblBookCart.Text.Contains("The Inferno"))
            {
                lblBookCart.Text += "";
            }
            else if (!chkBook3.Checked && lblBookCart.Text.Contains("The Inferno"))
            {
                String text = "\nThe Inferno,  Dante Alighieri";
                int thisPosition = lblBookCart.Text.IndexOf(text);


                if (thisPosition != -1)
                {
                    var theString = new StringBuilder(lblBookCart.Text);

                    for (int i = thisPosition + text.Length - 1; i >= thisPosition; i--)
                    {
                        theString.Remove(i, 1);
                    }
                    lblBookCart.Text = theString.ToString();
                }
            }
        }

        private void chkBook4_CheckedChanged_1(object sender, EventArgs e)
        {
            grpBookCart.Visible = true;
            if (chkBook4.Checked && !lblBookCart.Text.Contains("Oliver Twist"))
            {
                grpBookCart.Visible = true;
                lblBookCart.Text += "\nOliver Twist,  Charles Dickens";
            }
            else if (chkBook4.Checked && lblBookCart.Text.Contains("Oliver Twist"))
            {
                lblBookCart.Text += "";
            }
            else if (!chkBook4.Checked && lblBookCart.Text.Contains("Oliver Twist"))
            {
                String text = "\nOliver Twist,  Charles Dickens";
                int thisPosition = lblBookCart.Text.IndexOf(text);


                if (thisPosition != -1)
                {
                    var theString = new StringBuilder(lblBookCart.Text);

                    for (int i = thisPosition + text.Length - 1; i >= thisPosition; i--)
                    {
                        theString.Remove(i, 1);
                    }
                    lblBookCart.Text = theString.ToString();
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lblBookCart.Text != "")
            {
                MessageBox.Show("These Books Have Now Been Collected!",
                                "Information", 
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                grpMemberInfo.Visible = false;
                lblTitle.Visible = false;
                txtTitle.Visible = false;
                btnSearchTitle.Visible = false;
                dgvResults.Visible = false;
                chkBook1.Visible = false;
                chkBook2.Visible = false;
                chkBook3.Visible = false;
                chkBook4.Visible = false;
                txtMemberId.Text = string.Empty;
                txtTitle.Text = string.Empty;
                dgvResults.Rows.Clear();
                chkBook1.Checked = false;
                chkBook2.Checked = false;
                chkBook3.Checked = false;
                chkBook4.Checked = false;
                lblBookCart.Text = string.Empty;
                grpBookCart.Visible = false;
            }
            else
            {
                MessageBox.Show("No Books in the Book Cart!",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                grpBookCart.Visible = false;
                return;
            }
        }

        private void chkBook2_CheckedChanged_1(object sender, EventArgs e)
        {
            grpBookCart.Visible = true;
            if (chkBook2.Checked && !lblBookCart.Text.Contains("The Fault in Our Stars"))
            {
                grpBookCart.Visible = true;
                lblBookCart.Text += "\nThe Fault in Our Stars,  John Green";
            }
            else if (chkBook2.Checked && lblBookCart.Text.Contains("The Fault in Our Stars"))
            {
                lblBookCart.Text += "";
            }
            else if (!chkBook2.Checked && lblBookCart.Text.Contains("The Fault in Our Stars"))
            {
                String text = "\nThe Fault in Our Stars,  John Green";
                int thisPosition = lblBookCart.Text.IndexOf(text);


                if (thisPosition != -1)
                {
                    var theString = new StringBuilder(lblBookCart.Text);

                    for (int i = thisPosition + text.Length - 1; i >= thisPosition; i--)
                    {
                        theString.Remove(i, 1);
                    }
                    lblBookCart.Text = theString.ToString();
                }
            }
        }

        
    }
}
