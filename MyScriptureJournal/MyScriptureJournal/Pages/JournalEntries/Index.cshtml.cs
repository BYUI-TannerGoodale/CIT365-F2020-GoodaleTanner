using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;
using System.Linq;

namespace MyScriptureJournal.Pages.JournalEntries
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournalContext context)
        {
            _context = context;
        }

        // Used to generate session message content
        public string Message;

        // Properties for filter logic
        public IList<JournalEntry> JournalEntry { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Book { get; set; }

        // Properties for sorting logic
        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentBook { get; set; }



        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, string currentBook, string book)
        {
            // Sorting Logic
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            if(searchString == null)
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            if(book == null)
            {
                book = currentBook;
            }

            CurrentBook = book;

            if(book == "")
            {
                CurrentBook = null;
            }

            IQueryable<JournalEntry> entriesQuery = from s in _context.JournalEntry
                                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                entriesQuery = entriesQuery.Where(s => s.Note.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "book_desc":
                    entriesQuery = entriesQuery.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    entriesQuery = entriesQuery.OrderBy(s => s.EntryDate);
                    break;
                case "date_desc":
                    entriesQuery = entriesQuery.OrderByDescending(s => s.EntryDate);
                    break;
                default:
                    entriesQuery = entriesQuery.OrderBy(s => s.Book);
                    break;
            }

            IQueryable<string> bookQuery = from m in _context.JournalEntry
                                           orderby m.Book
                                           select m.Book;

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());

            if (!string.IsNullOrEmpty(Book))
            {
                entriesQuery = entriesQuery.Where(x => x.Book == Book);
            }

            JournalEntry = await entriesQuery.AsNoTracking().ToListAsync();

            // Session Message
            Message = HttpContext.Session.GetString("_Message");
            // Clear the session after displaying the message
            HttpContext.Session.Clear();
        }
    }
}
