
using Aggregates.Messages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.Collections.Generic;
using WebSpeciliste.Models;
using WebSpeciliste.services;
using WebSpeciliste.services.CustomerServices;

namespace WebSpeciliste.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomer _customerService;
        public CustomerController(ICustomer customerservice)
        {
            _customerService = customerservice;
        }
        public async Task<IActionResult> Indexs()
        {
            List<OfferDto> list = new List<OfferDto>();
            //List<SpecialistDto> list = new ();
            var res = await _customerService.GetCustomerOffersAsync<ResponseDto>("hhhh");
            if (res != null)
            {
                list = JsonConvert.DeserializeObject<List<OfferDto>>(Convert.ToString(res.result));
            }

            return View(list);
        }

        public async Task<IActionResult> Index([FromQuery] string? speciality, [FromQuery] string? location, [FromQuery] string? keyword)
        {
            List<OfferDto> list = new List<OfferDto>();
            //List<SpecialistDto> list = new ();
            //ViewBag.location = location;
            var res = await _customerService.GetOfferByLocationSpecialityKeywordAsync<ResponseDto>(speciality, location, keyword);
            if (res != null)
            {
                list = JsonConvert.DeserializeObject<List<OfferDto>>(Convert.ToString(res.result));
            }
            return View(list);
        }

        public async Task<IActionResult> OfferDetails(string? id)
        {
            var res = await _customerService.GetOneOfferAsync<ResponseDto>(id);
            OfferDto offer = new OfferDto();
            if (res != null)
            {
                offer = JsonConvert.DeserializeObject<OfferDto>(Convert.ToString(res.result));
            }
            return View(offer);
        }
        


        public async Task<IActionResult> CreateOffer()
        {
            //ViewBag.Error = new List<string>();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOffer(OfferDto model)
        {

            //var errors = ModelState.Values.SelectMany(v => v.Errors);
            //ViewBag.Error = errors;
            
            if (model.diploma) model.diploma = true;
            else model.diploma = false;

            if (ModelState.IsValid)
            {
                //model.created = DateTime.Now;
                var res = await _customerService.CreateOfferAsync<ResponseDto>(model);
                ViewBag.err = model.customerId;
                if (res != null & res.success)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(model);
        }
    }
}
