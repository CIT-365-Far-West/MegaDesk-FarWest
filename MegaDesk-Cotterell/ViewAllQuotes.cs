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
    public partial class ViewAllQuotes : Form
    {
        List<DeskQuote> quotes = new List<DeskQuote>();
        AllQuotes allQuotes = new AllQuotes();
        public ViewAllQuotes()
        {
            InitializeComponent();
            quotes = allQuotes.RetrieveAllQuotes();
            foreach (DeskQuote quote in quotes)
            {
                string[] filtered = allQuotes.FilterQuote(quote);
                dataGridView1.Rows.Add(filtered);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
