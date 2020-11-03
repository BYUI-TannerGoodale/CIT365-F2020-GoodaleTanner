using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace MegaDesk.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk.Data.MegaDeskContext _context;

        public IndexModel(MegaDesk.Data.MegaDeskContext context)
        {
            _context = context;
        }

        // Set property for session messages
        public string Message;

        public IList<DeskQuote> DeskQuote { get;set; }

        // Set properties to build view
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList CustNames { get; set; }

        public string NameSort { get; set; }

        public string DateSort { get; set; }

        public string CurrentFilter { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString)
        {
            // Sorting and searching logic
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString == null)
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<DeskQuote> quoteQuery = from s in _context.DeskQuote
                                               select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                quoteQuery = quoteQuery.Where(s => s.CustName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    quoteQuery = quoteQuery.OrderByDescending(s => s.CustName);
                    break;
                case "Date":
                    quoteQuery = quoteQuery.OrderBy(s => s.QuoteDate);
                    break;
                case "date_desc":
                    quoteQuery = quoteQuery.OrderByDescending(s => s.QuoteDate);
                    break;
                default:
                    quoteQuery = quoteQuery.OrderBy(s => s.CustName);
                    break;
            }

            IQueryable<string> custQuery = from m in _context.DeskQuote
                                           orderby m.CustName
                                           select m.CustName;

            CustNames = new SelectList(await custQuery.Distinct().ToListAsync());

            DeskQuote = await quoteQuery.AsNoTracking().ToListAsync();

            // Session Message
            Message = HttpContext.Session.GetString("_Message");
            // Clear the session after displaying the message
            HttpContext.Session.Clear();
        }
    }
}
