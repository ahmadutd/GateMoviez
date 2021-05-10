using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GateMoviez.Domain;
using GateMoviez.Data;

namespace GateMoviezAdmin.Web.Pages.Post
{
    public class DetailsModel : PageModel
    {
        private readonly GateMoviezDbContext _context;

        public DetailsModel(GateMoviezDbContext context)
        {
            _context = context;
        }

        public Video Video { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Video = await _context.Video
                .Include(v => v.User).FirstOrDefaultAsync(m => m.VideoId == id);

            if (Video == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
