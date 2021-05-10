using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GateMoviez.Data.Interface;
using GateMoviez.Data.Repositories;
using GateMoviez.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using domain = GateMoviez.Domain;

namespace GateMoviezManager.Web.Pages.Artist
{
    public class IndexModel : PageModel
    {
        
        private readonly IUnitOfWork _unitofwork;
        
        public IndexModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
          

        }
        [BindProperty]
        public domain.Artist Artist { get; set; }
        [BindProperty]
        public int[] ArtistTypeIds { get; set; }

        public List<domain.Artist> ArtistList { get; set; }
        public List<domain.ArtistType> ArtistTypeList { get; set; }

        public List<SelectListItem> ArtisttypeSelectList = new List<SelectListItem>();

        public void OnGet()
        {
            ArtistTypeList = _unitofwork.ArtistTypeRepo.GetAll().ToList();
            ArtistList = _unitofwork.ArtistRepo.GetAll().ToList();
            ArtisttypeSelectList = ArtistTypeList.Select(x => new SelectListItem
            {
                Text = x.ArtistTypeName,
                Value = x.Id.ToString(),
            }).ToList();

            //ArtisttypeSelectList = _unitofwork.ArtistTypeRepo.GetAll().Select(x => new SelectListItem
            //{
            //    Text=x.ArtistTypeName,
            //    Value=x.Id.ToString(),

            //});
        }
        public IActionResult OnPost()
        {
            try
            {
                _unitofwork.ArtistRepo.Add(Artist);
                _unitofwork.Commit();

                var artist = _unitofwork.ArtistRepo.Get(x => x.FirstName == Artist.FirstName);

                List<Artist_ArtistTypes> artistArtistTypeList = new List<Artist_ArtistTypes>();
                foreach (var item in ArtistTypeIds)
                {
                    var artistArtistType = new Artist_ArtistTypes
                    {
                        ArtistId = artist.Id,
                        ArtistTypeId = item
                    };
                    artistArtistTypeList.Add(artistArtistType);
                }
                
                _unitofwork.ArtistArtistTypeRepo.AddRange(artistArtistTypeList);
                _unitofwork.Commit();
                _unitofwork.Dispose();
                return RedirectToPage("index");

            }
            catch (Exception )
            {

               
                return RedirectToPage("index");
            }
        }
    }
}
