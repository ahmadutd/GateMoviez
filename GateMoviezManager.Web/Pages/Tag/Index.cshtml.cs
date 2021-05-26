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
        public List<domain.Tag> Data { get; set; }
        public void OnGet()
        {
            try
            {
                Data = _unitOfWork.TagRepo.GetAll().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IActionResult OnPost()
        {
            try
            {
                if(!ModelState.IsValid)
                    return RedirectToPage("Index");

                _unitOfWork.TagRepo.Add(Tag);
                _unitOfWork.Commit();
                _unitOfWork.Dispose();

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                _unitOfWork?.Dispose();
            }



            return RedirectToPage("Index");
        }
    }
}