using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GateMoviez.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using domain=GateMoviez.Domain;

namespace GateMoviezManager.Web.Pages.ArtistArtistType
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;
        public IndexModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        [BindProperty]
        public domain.Artist_ArtistTypes Data{ get; set; }
        public List<domain.Artist_ArtistTypes> DataList { get; set; }

        public List<SelectListItem> artistselectlist = new List<SelectListItem>();
        public List<SelectListItem> artisttypeselectlist = new List<SelectListItem>();
        public void OnGet()
        {
            this.DataList  = _unitofwork.ArtistArtistTypeRepo.GetAll().ToList();

            var artistlist = _unitofwork.ArtistRepo.GetAll().ToList();
            artistselectlist = artistlist.Select(x => new SelectListItem
            {
                Text=x.FirstName,
                Value=x.Id.ToString()
            }).ToList();
            var artisttypelist = _unitofwork.ArtistTypeRepo.GetAll().ToList();
            artisttypeselectlist = artisttypelist.Select(x => new SelectListItem
            {
                Text = x.ArtistTypeName,
                Value = x.Id.ToString()
            }).ToList();
        }
        public IActionResult OnPost()
        {
            try
            {
                _unitofwork.ArtistArtistTypeRepo.Add(Data);
                _unitofwork.Commit();
                _unitofwork.Dispose();



                return RedirectToPage("index");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}