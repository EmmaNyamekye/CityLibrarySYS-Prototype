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
    public partial class frmDeregisterMember : Form
    {
        frmMainManu parent;

        public frmDeregisterMember()
        {
            InitializeComponent();
        }

        public frmDeregisterMember(frmMainManu parent)
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
                grpMemberInfo.Visible = true;
                lblMemberInfo.Text = "Name: Sophia Loren" +
                    "\n\nDate of Birth: 15/05/1956" +
                    "\n\nAddress: Galway Street, Galway, Galway City, A65F4E2" +
                    "\n\nPhone number: 0612345678" +
                    "\n\nEmail: not.sophia.loren@gmail.it";
            }
            else if (txtMemberId.Text == "A000001")
            {
                grpMemberInfo.Visible = true;
                lblMemberInfo.Text = "Name: Mario Rossi" +
                    "\n\nDate of Birth: 23/06/1966" +
                    "\n\nAddress: Tenth Street, Limerick, Munster, A65F4E1" +
                    "\n\nPhone number: 0687654321" +
                    "\n\nEmail: mariorossin1@gmail.com";
            }
            else if (txtMemberId.Text == "A000002")
            {
                grpMemberInfo.Visible = true;
                lblMemberInfo.Text = "Name: Luigi Bros" +
                    "\n\nDate of Birth: 06/09/1986" +
                    "\n\nAddress: Bros Street, Shannon, Munster, A65F4E3" +
                    "\n\nPhone number: 0611223344" +
                    "\n\nEmail: luigibros@yahoo.com";
            }
            else if (txtMemberId.Text == "A000003")
            {
                grpMemberInfo.Visible = true;
                lblMemberInfo.Text = "Name: Mario Bros" +
                    "\n\nDate of Birth: 25/02/1956" +
                    "\n\nAddress: Clare Street, Kilrush, Clare, A65F4E3" +
                    "\n\nPhone number: 0611113333" +
                    "\n\nEmail: mariobros1@gmail.com";
            }
            else
            {
                MessageBox.Show("Invalid MemberId!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                txtMemberId.Focus();
                grpMemberInfo.Visible = false;
                return;
            }
      
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Member Has Been Deregistered",
                            "Success!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            txtMemberId.Text = "";
            grpMemberInfo.Visible = false;
        }
    }
}
