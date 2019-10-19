using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Cotterell
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            // List<DeskQuote> quotes = new List<DeskQuote>();
            //string file = File.ReadAllText("quotes.json");
            StreamReader reader = new StreamReader("quotes.json");
            List<DeskQuote> quotes = new List<DeskQuote>();
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                DeskQuote quote = JsonConvert.DeserializeObject<DeskQuote>(line);
                quotes.Add(quote);
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
