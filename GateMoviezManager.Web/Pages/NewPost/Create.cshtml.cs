using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GateMoviez.Data.Interface;
using GateMoviez.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GateMoviezManager.Web.Pages.NewPost
{
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;
        public CreateModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Video Video { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _unitofwork.VideoRepo.Add(Video);
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}
