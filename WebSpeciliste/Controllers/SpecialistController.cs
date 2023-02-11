using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebSpeciliste.Models;
using WebSpeciliste.services.SpecialistsService;
using System.Collections.Generic;

namespace WebSpeciliste.Controllers
{
    public class SpecialistController : Controller
    {
        private readonly ISpecialist _SpecialistService;

        public SpecialistController(ISpecialist specialist)
        {
               _SpecialistService = specialist;
        }

        public async Task<IActionResult> Index()
        {
            List<SpecialistDto> list = new List<SpecialistDto>();
            //List<SpecialistDto> list = new ();
            var res  = await  _SpecialistService.GetAllSpecialistsAsync<ResponseDto>();
            if(res != null)
            {
                list = JsonConvert.DeserializeObject<List<SpecialistDto>>(Convert.ToString(res.result));
            }
            
             return View(list);
        }

        public async Task<IActionResult> SpecialistsCrud()
        {
            List<SpecialistDto> list = new List<SpecialistDto>();
            //List<SpecialistDto> list = new ();
            var res = await _SpecialistService.GetAllSpecialistsAsync<ResponseDto>();
            if (res != null)
            {
                list = JsonConvert.DeserializeObject<List<SpecialistDto>>(Convert.ToString(res.result));
            }

            return View(list);
        }

        public async Task<IActionResult> AddSpecialist()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSpecialist(SpecialistDto model)
        {

            if(ModelState.IsValid)
            {
                model.joined = DateTime.Now;
                //model.Email = "bzr@gmail.com";
                var res = await _SpecialistService.CreateSpecialistAsync<ResponseDto>(model);
                if (res != null && res.success)
                {
                    return RedirectToAction(nameof(SpecialistsCrud));
                }
            }
            
            return View(model);
        }


        public async Task<IActionResult> UpdateSpecialist(string specialistId)
        {
            List<SpecialistDto> list = new();
            var res = await _SpecialistService.GetOneSpecialistByIdAsync<ResponseDto>(specialistId);
            //ViewData["ok"] = res.errorMessages;
            if (res != null && res.success)
            {

                SpecialistDto specialist = JsonConvert.DeserializeObject<SpecialistDto>(Convert.ToString(res.result));
                return View(specialist);
            }
            return NotFound();

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateSpecialist(SpecialistDto model)
        {  
                var res = await _SpecialistService.UpdateSpecialistAsync<ResponseDto>(model.id,model);
                if (res != null && res.success)
                {
                    return RedirectToAction(nameof(SpecialistsCrud));
                }
            
            return View(model);
        }

        public async Task<IActionResult> DeleteSpecialist(string specialistId)
        {
            List<SpecialistDto> list = new();
            var res = await _SpecialistService.GetOneSpecialistByIdAsync<ResponseDto>(specialistId);
            if (res != null && res.success)
            {

                SpecialistDto specialist = JsonConvert.DeserializeObject<SpecialistDto>(Convert.ToString(res.result));
                return View(specialist);
            }
            return NotFound();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSpecialist(SpecialistDto model)
        {
            var res = await _SpecialistService.DeleteSpecialistAsync<ResponseDto>(model.id);
            if (res.success)
            {
                return RedirectToAction(nameof(SpecialistsCrud));
            }
            return View(model);
        }


    }
}
