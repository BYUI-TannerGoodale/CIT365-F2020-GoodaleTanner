using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Goodale
{
    class DeskQuote
    {
        // Define attributes of a DeskQuote
        public string CustName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Desk Desk = new Desk();
        public int ShippingRush { get; set; }
        public int QuoteTotal { get; set; }

        // Used for calculations
        private int DeskArea = 0;
        public DeskQuote(string custName, DateTime quoteDate, int width, int depth, int drawersNumber, int surfaceMaterial, int shippingRush)
        {
            CustName = custName;
            QuoteDate = quoteDate;
            Desk.width = width;
            Desk.depth = depth;
            Desk.drawersNumber = drawersNumber;
            Desk.surfaceMaterial = surfaceMaterial;
            ShippingRush = shippingRush;

            DeskArea = Desk.width * Desk.depth;
        }

        public int CalcQuoteTotal(DeskQuote deskQuote)
        {
            const int basePrice = 200;
            const int costPerSqrInch = 1;
            const int costPerDrawer = 50;
            // Array 0 is for 3 day shipping.  Array 1 is for 5 day shipping.  Array 2 is for 7 day shipping.
            // Position 0 is for < 1000 in^2. Position 1 is for 1000-2000 in^2. Position 2 is for > 2000 in^2.
            int[,] RushPriceChart = new int[,] { { 60, 70, 80 }, { 40, 50, 60 }, { 30, 35, 40 } };

            int total = 0;
            total += basePrice;
            total += deskQuote.DeskArea * costPerSqrInch;
            total += deskQuote.Desk.drawersNumber * costPerDrawer;
            total += deskQuote.Desk.surfaceMaterial;
            
            if(deskQuote.DeskArea < 1000)
            {
                if(deskQuote.ShippingRush == 3)
                {
                    total += RushPriceChart[0, 0];
                }
                else if(deskQuote.ShippingRush == 5)
                {
                    total += RushPriceChart[1, 0];
                }
                else if(deskQuote.ShippingRush == 7)
                {
                    total += RushPriceChart[2, 0];
                }
            }
            else if(deskQuote.DeskArea >= 1000 && deskQuote.DeskArea <= 2000)
            {
                if (deskQuote.ShippingRush == 3)
                {
                    total += RushPriceChart[0, 1];
                }
                else if (deskQuote.ShippingRush == 5)
                {
                    total += RushPriceChart[1, 1];
                }
                else if (deskQuote.ShippingRush == 7)
                {
                    total += RushPriceChart[2, 1];
                }
            }
            else if(deskQuote.DeskArea > 2000)
            {
                if (deskQuote.ShippingRush == 3)
                {
                    total += RushPriceChart[0, 2];
                }
                else if (deskQuote.ShippingRush == 5)
                {
                    total += RushPriceChart[1, 2];
                }
                else if (deskQuote.ShippingRush == 7)
                {
                    total += RushPriceChart[2, 2];
                }
            }

            this.QuoteTotal = total;
            return total;
        }
    }
}
