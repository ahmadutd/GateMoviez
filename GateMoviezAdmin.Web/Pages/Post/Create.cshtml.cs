using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GateMoviez.Application;
using GateMoviez.Domain;
using GateMoviezAdmin.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GateMoviezAdmin.Web.Pages.Post
{
    public class CreateModel : PageModel
    {
        private readonly VideoService _vService;
        private readonly JanerService _jService;
        public CreateModel(VideoService vService, JanerService jService)
        {
            _vService = vService;
            _jService = jService;
        }
        [BindProperty]
        public Video video { get; set; }

        [BindProperty]
        public IEnumerable<SelectListItem>  JanerSelectitems { get; set; }

        public void OnGet()
        {
            var janers = _jService.GetAll();
            List<SelectListItem> selectListItem = new List<SelectListItem>();
            foreach (Janer janer in janers)
            {
                selectListItem.Add(new SelectListItem
                {
                    Value = janer.JanerId.ToString(),
                    Text=janer.Name,
                }) ;
            }

            JanerSelectitems = selectListItem;

        }
        public IActionResult OnPost()
        {
            
            var Janerha = HttpContext.Request.Form["Janer[]"];
            if (!ModelState.IsValid)
                return Page();

            try
            {
                _vService.CreatVideo(video);

            }
            catch (Exception)
            {

                
                return Page();
            }

            return Page();

        }
    }
}
