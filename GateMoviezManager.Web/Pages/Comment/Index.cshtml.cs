using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GateMoviez.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using domain = GateMoviez.Domain;

namespace GateMoviezManager.Web.Pages.Comment
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;
        public IndexModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public List<domain.Comment> ListComments { get; set; }

        public void OnGet()
        {
            ListComments = _unitofwork.CommentRepo.GetAll().ToList();
        }
    }
}
