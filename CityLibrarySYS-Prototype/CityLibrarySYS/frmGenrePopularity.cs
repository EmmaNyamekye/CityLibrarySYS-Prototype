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
    public partial class frmGenrePopularity : Form
    {
        frmMainManu parent;

        public frmGenrePopularity()
        {
            InitializeComponent();
        }

        public frmGenrePopularity(frmMainManu parent)
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
            chtGenrePopularity.Visible = true;
            btnConfirm.Visible = true;
            chtGenrePopularity.Series.Clear();

            int[] collectedBooks = { };
            string[] genre = { "Fiction", "Mystery", "Fantasy", "Romance", "Horror", 
                "Adventure", "Historical", "Biography", "Self-Help", "Science", 
                "Philosophy", "Crime" };

            if (cboMonth.SelectedIndex == 0)
            {
                //January
                collectedBooks = new int[] { 7000, 2300, 5400, 6500, 3000, 6000, 2000, 3000, 5000, 4000, 1200, 4500 };
            }
            else if (cboMonth.SelectedIndex == 1)
            {
                //February
                collectedBooks = new int[] { 6000, 2000, 3000, 5000, 4000, 7000, 2000, 3000, 4800, 3800, 3400, 5600 };
            }
            else if (cboMonth.SelectedIndex == 2)
            {
                //March
                collectedBooks = new int[] { 7000, 2000, 3000, 4800, 3800, 7000, 2300, 5400, 6500, 3000, 4300, 5400 };
            }
            else if (cboMonth.SelectedIndex == 3)
            {
                //April
                collectedBooks = new int[] { 3000, 4800, 3800, 7000, 2000, 6000, 2000, 3000, 5000, 4000, 6700, 5600 };
            }
            else if (cboMonth.SelectedIndex == 4)
            {
                //May
                collectedBooks = new int[] { 6000, 2200, 3100, 5000, 4000, 7000, 2000, 3000, 4800, 3800, 1200, 4500 };
            }
            else if (cboMonth.SelectedIndex == 5)
            {
                //June
                collectedBooks = new int[] { 7000, 2000, 3300, 4800, 3800, 6000, 2200, 3100, 5000, 4000, 3400, 5600 };
            }
            else if (cboMonth.SelectedIndex == 6)
            {
                //July
                collectedBooks = new int[] { 3000, 4000, 3800, 7000, 2000, 7000, 2000, 3000, 4800, 3800, 6700, 5600 };
            }

            Series series = new Series("CollectedBooks");
            series.ChartType = SeriesChartType.Column;

            for (int i = 0; i < genre.Length; i++)
            {
                series.Points.AddXY(genre[i], collectedBooks[i]);
            }

            chtGenrePopularity.Series.Add(series);

            chtGenrePopularity.ChartAreas[0].AxisX.Interval = 1;
            chtGenrePopularity.ChartAreas[0].AxisX.Title = "Library ID";
            chtGenrePopularity.ChartAreas[0].AxisY.Title = "Collected Books";
            chtGenrePopularity.Titles.Clear();
            chtGenrePopularity.Titles.Add("Library Popularity Chart");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("End of the Analysis!",
                            "Success!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            chtGenrePopularity.Visible = false;
            btnConfirm.Visible = false;
            cboMonth.Text = "";
        }
    }
}
