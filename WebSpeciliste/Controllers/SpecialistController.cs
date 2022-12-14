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
            
            if (ModelState.IsValid)
            {
                var res = await _SpecialistService.CreateSpecialistAsync<ResponseDto>(model);
                if (res != null && res.success)
                {
                    SpecialistDto specialist = JsonConvert.DeserializeObject<SpecialistDto>(Convert.ToString(res.result));
                    return View(specialist);
                }
            }

            return NotFound();
        }

        public async Task<IActionResult> DeleteSpecialist()
        {
            return View();
        }


    }
}
