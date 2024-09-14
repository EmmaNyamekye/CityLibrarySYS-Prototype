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
    public partial class frmRemoveBook : Form
    {
        frmMainManu parent;

        public frmRemoveBook()
        {
            InitializeComponent();
        }

        public frmRemoveBook(frmMainManu parent)
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

                if (txtBookId.Text == "A0000000")
                {
                    grpBookInfo.Visible = true;
                    lblBookInfo.Text = "Title: Animal Farm" +
                        "\n\nAuthor: George Orwell" +
                        "\n\nGenre: Novel" +
                        "\n\nDescription: Animal Farm is a beast fable, in the form of a satirical allegorical novella." +
                        "\n\nPublication: 17/08/1945" +
                        "\n\nISBN: 9788129116123" +
                        "\n\nLibrary Location: City Central Library";
                }
                else if (txtBookId.Text == "A0000001")
                {
                    grpBookInfo.Visible = true;
                    lblBookInfo.Text = "Title: Percy Jackson & the Olympians" +
                        "\n\nAuthor: Rick Riordan" +
                        "\n\nGenre: Finction" +
                        "\n\nDescription: Twelve-year-old Percy Jackson is on the most dangerous quest of his life." +
                        "\n\nPublication: 28/06/2005" +
                        "\n\nISBN: 9781368051477" +
                        "\n\nLibrary Location: County Library";
                }
                else if (txtBookId.Text == "A0000002")
                {
                    grpBookInfo.Visible = true;
                    lblBookInfo.Text = "Title: The Surgeon" +
                        "\n\nAuthor: Tess Gerritsen" +
                        "\n\nGenre: Crime" +
                        "\n\nDescription: A killer who targets lone women, who breaks into their apartments and performs terrifying ritualistic acts of torture on them before finishing them off." +
                        "\n\nPublication: 01/01/2001" +
                        "\n\nISBN: 9780739420416" +
                        "\n\nLibrary Location: County Library";
                }
                else if (txtBookId.Text == "A0000003")
                {
                    grpBookInfo.Visible = true;
                    lblBookInfo.Text = "Title: To Kill a Mockingbird" +
                        "\n\nAuthor: Harper Lee" +
                        "\n\nGenre: Novel" +
                        "\n\nDescription: Set in small-town Alabama, the novel is a bildungsroman, or coming-of-age story, and chronicles the childhood of Scout and Jem Finch as their father Atticus defends a Black man falsely accused of rape." +
                        "\n\nPublication: 11/07/1960" +
                        "\n\nISBN: 9780099419785" +
                        "\n\nLibrary Location: Suburb Reading Haven";
                }
                else
                {
                    MessageBox.Show("Invalid BookId!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtBookId.Focus();
                    grpBookInfo.Visible = false;
                    return;
                }
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Book Has Been Removed From the Books File",
                            "Success!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            grpBookInfo.Visible = false;
            txtBookId.Text = "";
            return;
        }
    }
}
