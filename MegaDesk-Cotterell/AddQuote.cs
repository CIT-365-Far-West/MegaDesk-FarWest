using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Cotterell
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void deskWidthBox_Validating(object sender, CancelEventArgs e)
        {
            int deskWidth;
            if (int.TryParse(deskWidthBox.Text, out deskWidth))
            {
                if (deskWidth >= 24 && deskWidth <= 96)
                {
                    //MessageBox.Show("You've entered a valid width!");
                    deskWidthBox.BackColor = Color.LightGreen;
                }
                else
                {
                    deskWidthBox.BackColor = Color.LightSalmon;
                    MessageBox.Show("Please enter a valid width between 24 and 96 inches.");
                }
            }
            else
            {
                deskWidthBox.BackColor = Color.LightSalmon;
                MessageBox.Show("Please enter a valid width between 24 and 96 inches.");
            }
        }

        private void deskDepthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char test = e.KeyChar;
            if (!char.IsControl(test) && !char.IsDigit(test))
            {
                e.Handled = true;
                deskDepthBox.BackColor = Color.LightSalmon;
                MessageBox.Show("Please enter a valid depth between 12 and 48 inches.");
            }
            else
            {
                deskDepthBox.BackColor = Color.Empty;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            int width = int.Parse(deskWidthBox.Text);
            int depth = int.Parse(deskDepthBox.Text);
            int drawers = int.Parse(numDrawersBox.Text);
            string surface = surfaceBox.Text;
            int days = int.Parse(rushBox.Text);

            Desk newDesk = new Desk(firstName, lastName, width, depth, drawers, surface, days);
            DeskQuote newQuote = new DeskQuote(newDesk);
        }
    }
}
