using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GateMoviez.Domain;
using GateMoviez.Application;

namespace GateMoviezAdmin.Web.Pages.Post
{
    public class IndexModel : PageModel
    {
        protected readonly VideoService _videoservice;
        public IndexModel(VideoService videoservice)
        {
            _videoservice = videoservice;
        }
        public IEnumerable<Video> videos { get; set; }
        public  void OnGet()
        {
            var listofvideos = _videoservice.GetAllVideos();
            videos = listofvideos;
            
        }
        public void OnPost()
        {

        }
    }
}
