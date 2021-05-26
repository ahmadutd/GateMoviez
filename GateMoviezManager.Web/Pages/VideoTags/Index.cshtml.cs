using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GateMoviez.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using domain = GateMoviez.Domain;

namespace GateMoviezManager.Web.Pages.VideoTags
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

       
       
        [BindProperty]
        public string TagIds { get; set; }

        [BindProperty]
        public int VideoId { get; set; }

        [BindProperty]
        public int? TagSelectedForDeleteId { get; set; }

        public List<domain.Video> Data { get; set; }
        public List<SelectListItem> TagSelectList { get; set; }
        //Fetch Data From Database
        public void OnGet()
        {
            try
            {
                Data = _unitOfWork.VideoRepo.GetAll().ToList();
                TagSelectList = _unitOfWork.TagRepo.GetAll().Select(x=>new SelectListItem
                { 
                    Text=x.Name,
                    Value=x.Id.ToString(),
                
                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Add Data To DataBase
        public IActionResult OnPost()
        {
            try
            {
                List<domain.VideoTags> VideoTags = new List<domain.VideoTags>();
                foreach (var tagId in TagIds)
                {
                    VideoTags.Add(new domain.VideoTags
                    {
                        TagId= tagId,
                        VideoId=this.VideoId
                    });
                }
                if (!VideoTags.Any())
                    return RedirectToPage("Index");

                _unitOfWork.VideoTagsRepo.AddRange(VideoTags);
                _unitOfWork.Commit();

                return RedirectToPage("Index");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _unitOfWork?.Dispose();
            }
            
        }

        public IActionResult OnPostDelete()
        {
            try
            {
                if (!String.IsNullOrEmpty(TagIds))
                {
                    int videId = VideoId;
                    List<int> tagIds=new List<int>();
                    var splitedTagIds = TagIds.Split(',');
                    foreach (var item in splitedTagIds)
                    {
                        var i=Convert.ToInt32(item);
                        tagIds.Add(i);
                    }
                    var videoTags = _unitOfWork.VideoTagsRepo.Find(x => tagIds.Contains<int>(x.TagId) && x.VideoId == videId);

                    if (videoTags != null)
                    {
                        _unitOfWork.VideoTagsRepo.DeleteRange(videoTags.ToList());
                        _unitOfWork.Commit();

                    }



                }


                return RedirectToPage("Index");



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }
    }
}