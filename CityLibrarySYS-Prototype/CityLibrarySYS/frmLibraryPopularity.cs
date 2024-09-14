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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CityLibrarySYS
{
    public partial class frmLibraryPopularity : Form
    {
        frmMainManu parent;

        public frmLibraryPopularity()
        {
            InitializeComponent();
        }

        public frmLibraryPopularity(frmMainManu parent)
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
            chtLibraryPopularity.Visible = true;
            btnConfirm.Visible = true;
            chtLibraryPopularity.Series.Clear();

            int[] collectedBooks = { };
            string[] libraryIDs = {"01", "02", "03", "04", "05"}; 

            if (cboMonth.SelectedIndex == 0)
            {
                //January
                collectedBooks = new int[] {7000, 2300, 5400, 6500, 3000};
            }
            else if (cboMonth.SelectedIndex == 1)
            {
                //February
                collectedBooks = new int[] {6000, 2000, 3000, 5000, 4000};
            }
            else if (cboMonth.SelectedIndex == 2)
            {
                //March
                collectedBooks = new int[] {7000, 2000, 3000, 4800, 3800};
            }
            else if (cboMonth.SelectedIndex == 3)
            {
                //April
                collectedBooks = new int[] {3000, 4800, 3800, 7000, 2000};
            }
            else if (cboMonth.SelectedIndex == 4)
            {
                //May
                collectedBooks = new int[] {6000, 2200, 3100, 5000, 4000};
            }
            else if (cboMonth.SelectedIndex == 5)
            {
                //June
                collectedBooks = new int[] {7000, 2000, 3300, 4800, 3800};
            }
            else if (cboMonth.SelectedIndex == 6)
            {
                //July
                collectedBooks = new int[] {3000, 4000, 3800, 7000, 2000};
            }

            Series series = new Series("CollectedBooks");
            series.ChartType = SeriesChartType.Column;

            for (int i = 0; i < libraryIDs.Length; i++)
            {
                series.Points.AddXY(libraryIDs[i], collectedBooks[i]);
            }

            chtLibraryPopularity.Series.Add(series);
            chtLibraryPopularity.ChartAreas[0].AxisX.Interval = 1;
            chtLibraryPopularity.ChartAreas[0].AxisX.Title = "Library ID";
            chtLibraryPopularity.ChartAreas[0].AxisY.Title = "Collected Books";
            chtLibraryPopularity.Titles.Clear();
            chtLibraryPopularity.Titles.Add("Library Popularity Chart");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("End of the Analysis!",
                            "Success!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            chtLibraryPopularity.Visible = false;
            btnConfirm.Visible = false;
            cboMonth.Text = "";
        }
    }
}
