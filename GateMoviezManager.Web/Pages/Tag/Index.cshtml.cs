using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GateMoviez.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using domain = GateMoviez.Domain;

namespace GateMoviezManager.Web.Pages.Tag
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [BindProperty]
        public domain.Tag Tag { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            try
            {
               

            }
            catch (Exception)
            {

                throw;
            }





            return RedirectToPage("Index");
        }
    }
}