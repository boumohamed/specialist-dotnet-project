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
    }
}
