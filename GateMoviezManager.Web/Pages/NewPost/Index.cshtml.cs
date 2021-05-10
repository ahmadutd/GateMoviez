using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GateMoviez.Domain;

using GateMoviez.Data.Interface;


namespace GateMoviezManager.Web.Pages.NewPost
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;
        public IndexModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public List<Video> Videos  { get; set; }

        public void OnGet()
        {
            Videos = _unitofwork.VideoRepo.GetAll().ToList();

        }

    }
}
