using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Cotterell
{
    class AllQuotes
    {
        public AllQuotes()
        {
            
        }

        public List<DeskQuote> RetrieveAllQuotes()
        {
            StreamReader reader = new StreamReader("quotes.json");
            List<DeskQuote> quotes = new List<DeskQuote>();
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                DeskQuote quote = JsonConvert.DeserializeObject<DeskQuote>(line);
                quotes.Add(quote);
            }
            reader.Close();
            return quotes;
        }

        public bool SaveAllQuotes(List<DeskQuote> quotes)
        {
            string json = null;
            foreach (DeskQuote quote in quotes)
            {
                string temp = JsonConvert.SerializeObject(quote);
                if (json == null)
                {
                    json = temp;
                }
                else
                {
                    json = json + "\r\n" + temp;
                }
            }
            File.WriteAllText("quotes.json", json);

            return true;
        }
        
        public string[] FilterQuote(DeskQuote quote)
        {
            string[] filtered = new string[7];
            filtered[0] = quote.desk.CustomerFirstName + " " + quote.desk.CustomerLastName;
            filtered[1] = quote.date.ToShortDateString();
            filtered[2] = quote.desk.DeskWidth.ToString();
            filtered[3] = quote.desk.DeskDepth.ToString();
            filtered[4] = quote.desk.NumDrawers.ToString();
            filtered[5] = quote.desk.SurfaceMaterial.ToString();
            filtered[6] = quote.priceQuote.ToString("C0");

            return filtered;
        }
    }
}
