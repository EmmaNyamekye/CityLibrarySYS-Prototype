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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CityLibrarySYS
{
    public partial class frmQueryLibrary : Form
    {
        frmMainManu parent;

        public frmQueryLibrary()
        {
            InitializeComponent();
        }

        public frmQueryLibrary(frmMainManu parent)
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
            grpLibraryInfo.Visible = true;
            
            if (cboLibraryID.SelectedIndex == 0)
            {
                lblLibraryInfo.Text = "Name: City Central Library" +
                    "\n\nAddress: Maple Avenue, Galway City, Galway, A65F4E2" +
                    "\n\nPhone number: 0655512345" +
                    "\n\nEmail: central.library@city.library.ie" +
                    "\n\nSupervisor: John Smith";
            }
            else if (cboLibraryID.SelectedIndex == 1)
            {
                lblLibraryInfo.Text = "Name: County Library" +
                    "\n\nAddress: Main Street, Ennis, Clare, V93E0X2" +
                    "\n\nPhone number: 0655812345" +
                    "\n\nEmail: county.library@city.library.ie" +
                    "\n\nSupervisor: Zelda Hyrule";
            }
            else if (cboLibraryID.SelectedIndex == 2)
            {
                lblLibraryInfo.Text = "Name: Suburb Reading Haven" +
                    "\n\nAddress: High Street, Limerick, Limerick, D04V4X7" +
                    "\n\nPhone number: 0655912345" +
                    "\n\nEmail: reading.haven@city.library.ie" +
                    "\n\nSupervisor: Maria Rossi";
            }
            else if (cboLibraryID.SelectedIndex == 3)
            {
                lblLibraryInfo.Text = "Name: Village Library" +
                    "\n\nAddress: Church Street, Kilrush, Clare, A65F4E2" +
                    "\n\nPhone number: 0655712345" +
                    "\n\nEmail: village.library@city.library.ie" +
                    "\n\nSupervisor: Max Mustermann";
            }
            else if (cboLibraryID.SelectedIndex == 4)
            {
                lblLibraryInfo.Text = "Name: Riverbank Library" +
                    "\n\nAddress: Riverside Avenue, Castleconnell, Limerick, A65F4E2" +
                    "\n\nPhone number: 0655591234" +
                    "\n\nEmail:riverbank.library@city.library.ie" +
                    "\n\nSupervisor: Luigi Bros";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("End of the Query!",
                                "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            grpLibraryInfo.Visible = false;
            cboLibraryID.Text = "";
        }
    }
}
