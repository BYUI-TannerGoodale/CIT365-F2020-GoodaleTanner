using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;
using Microsoft.AspNetCore.Http;

namespace MegaDesk.Pages.DeskQuotes
{
    public class EditModel : PageModel
    {
        private readonly MegaDesk.Data.MegaDeskContext _context;

        public EditModel(MegaDesk.Data.MegaDeskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }

            // Save the true entry date
            HttpContext.Session.SetString("_QuoteDate", DeskQuote.QuoteDate.ToString());

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string trueDate = HttpContext.Session.GetString("_QuoteDate");

            DeskQuote.QuoteDate = Convert.ToDateTime(trueDate);

            HttpContext.Session.Clear();

            DeskQuote.DeskArea = DeskQuote.DeskWidth * DeskQuote.DeskDepth;

            // Calculate total price, start with base price of $200
            int total = 200;

            switch (DeskQuote.Material)
            {
                case "Pine":
                    total += 50;
                    break;
                case "Laminate":
                    total += 100;
                    break;
                case "Veneer":
                    total += 125;
                    break;
                case "Oak":
                    total += 200;
                    break;
                case "Rosewood":
                    total += 300;
                    break;
                default:
                    break;
            }

            // Add $50 to the total for ever drawer
            total += DeskQuote.Drawers * 50;

            // If the desk's area is greater than 1000 square inches, add $1 per square inch
            if (DeskQuote.DeskArea > 1000)
            {
                total += DeskQuote.DeskArea;
            }

            // Calculate shipping cost

            // Create 2d-array to store shipping costs
            int[,] shippingPriceChart = new int[,]
            {
                { 60, 70, 80 }, // Row 0, 3 day shipping
                { 40, 50, 60 }, // Row 1, 5 day shipping
                { 30, 35, 40 } // Row 2, 7 day shipping
            };

            // Create variables to access shippingPriceChart
            int areaIndex, dayIndex = 0;

            if (DeskQuote.ShippingTime == 14)
            {
                total += 0;
            }
            else
            {
                //Get array index in relation to size
                if (DeskQuote.DeskArea < 1000)
                {
                    areaIndex = 0;
                }
                else if (DeskQuote.DeskArea >= 1000 && DeskQuote.DeskArea <= 2000)
                {
                    areaIndex = 1;
                }
                else
                {
                    areaIndex = 2;
                }

                //Get array index in relation to days
                switch (DeskQuote.ShippingTime)
                {
                    case 3:
                        dayIndex = 0;
                        break;
                    case 5:
                        dayIndex = 1;
                        break;
                    case 7:
                        dayIndex = 2;
                        break;
                }

                //Get appropriate cost from shippingPriceChart
                total += shippingPriceChart[dayIndex, areaIndex];
            }

            DeskQuote.TotalPrice = total;

            _context.Attach(DeskQuote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeskQuoteExists(DeskQuote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DeskQuoteExists(int id)
        {
            return _context.DeskQuote.Any(e => e.ID == id);
        }
    }
}
