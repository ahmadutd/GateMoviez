using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GateMoviez.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using domain = GateMoviez.Domain;

namespace GateMoviezManager.Web.Pages.ArtistType
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;
        public IndexModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }


        [BindProperty]
        public domain.ArtistType ArtistType { get; set; }

        public List<domain.ArtistType> ArtistTypes { get; set; }

        public void OnGet()
        {
            ArtistTypes = _unitofwork.ArtistTypeRepo.GetAll().ToList();
           
        }
        public IActionResult OnPost()
        {
            _unitofwork.ArtistTypeRepo.Add(ArtistType);
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("index");
        }

    }
}
