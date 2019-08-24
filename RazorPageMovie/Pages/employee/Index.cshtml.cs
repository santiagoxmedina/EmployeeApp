using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Models;

namespace RazorPageMovie.Pages.employee
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageMovie.Models.RazorPageMovieContext _context;

        public IndexModel(RazorPageMovie.Models.RazorPageMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
