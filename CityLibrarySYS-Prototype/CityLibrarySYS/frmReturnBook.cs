using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CityLibrarySYS
{
    public partial class frmReturnBook : Form
    {
        frmMainManu parent;
        public static string SetValueForLabel = "";

        public frmReturnBook()
        {
            InitializeComponent();
        }

        public frmReturnBook(frmMainManu parent)
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
            if (txtMemberId.Text == "A000000" || txtMemberId.Text == "A000001" || txtMemberId.Text == "A000002")
            {
                // Enable text boxes
                grpMemberInfo.Visible = true;

                if (txtMemberId.Text == "A000000")
                {
                    lblMemberInfo.Text = "Name: Sophia Loren        Phone: 0612345678" +
                        "\n\nAddress:  Galway Street 1, A65F4E2, Galway, Galway City" +
                        "\n\nEmail: not.sophia.loren@gmail.it";

                    dgvResults.Visible = true;
                    chkBook1.Visible = true;
                    chkBook2.Visible = true;
                    chkBook1.Checked = false;
                    chkBook2.Checked = false;
                    lblBookCart.Text = "";
                    dgvResults.Rows.Clear();
                    dgvResults.Rows.Add("A0017642", "The Little Prince", "Antoine de Saint-Exupéry");
                    dgvResults.Rows.Add("A0017892", "Oliver Twist", "Charles Dickens");
                }
                else if (txtMemberId.Text == "A000001")
                {
                    lblMemberInfo.Text = "Name: Mario Rossi         Phone: 0687654321" +
                        "\n\nAddress: Tenth Street 2, A65F4E1, Limerick, Munster" +
                        "\n\nEmail: mariorossin1@gmail.com";

                    dgvResults.Visible = true;
                    chkBook1.Visible = true;
                    chkBook2.Visible = true;
                    chkBook1.Checked = false;
                    chkBook2.Checked = false;
                    lblBookCart.Text = "";
                    dgvResults.Rows.Clear();
                    dgvResults.Rows.Add("A0002340", "The Book Thief", "Markus Zusak");
                    dgvResults.Rows.Add("A0017890", "The Inferno", "Dante Alighieri");
                }
                else if (txtMemberId.Text == "A000002")
                {
                    lblMemberInfo.Text = "Name: Luigi Bros          Phone: 0611223344" +
                        "\n\nAddress: Bros Street 3, A65F4E3, Shannon, Munster" +
                        "\n\nEmail: luigibros@yahoo.com";

                    MessageBox.Show("This Member Has Collected No Books!",
                                 "Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                    txtMemberId.Focus();
                    grpBookCart.Visible = false;
                    dgvResults.Visible = false;
                    chkBook1.Visible = false;
                    chkBook2.Visible = false;
                    return;
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
                grpBookCart.Visible = false;
                return;
            }
        }

        private void chkBook1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "A000000")
            {
                grpBookCart.Visible = true;
                if (chkBook1.Checked && !lblBookCart.Text.Contains("The Little Prince"))
                {
                    grpBookCart.Visible = true;
                    lblBookCart.Text += "\nThe Little Prince,  Antoine de Saint-Exupéry";
                }
                else if (chkBook1.Checked && lblBookCart.Text.Contains("The Little Prince"))
                {
                    lblBookCart.Text += "";
                }
                else if (chkBook1.Checked == false && lblBookCart.Text.Contains("The Little Prince"))
                {
                    String text = "\nThe Little Prince,  Antoine de Saint-Exupéry";
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
            if (txtMemberId.Text == "A000001")
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
        }

        private void chkBook2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMemberId.Text == "A000000")
            {
                grpBookCart.Visible = true;
                if (chkBook2.Checked && !lblBookCart.Text.Contains("Oliver Twist"))
                {
                    grpBookCart.Visible = true;
                    lblBookCart.Text += "\nOliver Twist,  Charles Dickens";
                }
                else if (chkBook2.Checked && lblBookCart.Text.Contains("Oliver Twist"))
                {
                    lblBookCart.Text += "";
                }
                else if (chkBook2.Checked == false && lblBookCart.Text.Contains("Oliver Twist"))
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
            if (txtMemberId.Text == "A000001")
            {
                grpBookCart.Visible = true;
                if (chkBook2.Checked && !lblBookCart.Text.Contains("The Inferno"))
                {
                    grpBookCart.Visible = true;
                    lblBookCart.Text += "\nThe Inferno,  Dante Alighieri";
                }
                else if (chkBook2.Checked && lblBookCart.Text.Contains("The Inferno"))
                {
                    lblBookCart.Text += "";
                }
                else if (chkBook2.Checked == false && lblBookCart.Text.Contains("The Inferno"))
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

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!lblBookCart.Text.Contains("The Inferno"))
            {
                MessageBox.Show("These Books Have Now Been Returned!",
                                 "Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                txtMemberId.Text = "";
                lblMemberInfo.Text = "";
                lblBookCart.Text = "";
                grpMemberInfo.Visible = false;
                grpBookCart.Visible = false;
                dgvResults.Visible = false;
                chkBook1.Visible = false;
                chkBook2.Visible = false;
            }
            else if (lblBookCart.Text == "")
            {
                MessageBox.Show("Books Must Be Added To The Book Cart To Proceed!",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The Inferno by Dante Alighieri Is Late!",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                this.Close();
                SetValueForLabel = "The Inferno by Dante Alighieri Is 2 Weeks Late" +
                                  "\n\nLate Fine Amount is €1.00 " +
                                  "(€0.50/Late Week)" +
                                  "\n\nWould you like to pay the late fine now?";
                frmPayLateFine frm2 = new frmPayLateFine();
                frm2.Show();

                /*
                 Title: How to Pass Data One Form to Another in Windows Form Application
                 Author: Hussain Ahmed
                 Site owner/sponsor: C# Corner
                 Date: Oct 16, 2023
                 Availability: https://www.c-sharpcorner.com/UploadFile/834980/how-to-pass-data-from-one-form-to-other-form-in-windows-form/ 
                 (Accessed 06/12/2023)
                 Modified: Variable name 
                 */
            }
        }
    }
}
