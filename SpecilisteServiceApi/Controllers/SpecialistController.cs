using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpecilisteServiceApi.Models;
using SpecilisteServiceApi.Models.Dtos;
using SpecilisteServiceApi.Repositories;
using System.Collections;

namespace SpecilisteServiceApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class SpecialistController : ControllerBase
    {
        private SpecialistRepository _specialistRepository;
        private ResponseDto _response;


        public SpecialistController(SpecialistRepository specialistRepository)
        {
            _specialistRepository = specialistRepository;
            _response = new ResponseDto();
        }
        [HttpGet]
        [Route("specialits")]
        public async Task<object> Get()
        {
            IEnumerable<SpecialistDto> res = await _specialistRepository.GetSpecialists();
            return res;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ResponseDto> Add(SpecialistRequestDto requestDto)
        {

                SpecialistDto res =  await _specialistRepository.CreateSpecialist(requestDto);
                _response.result = res;
                _response.success = true;
                return _response;
            

        }

        [HttpGet]
        [Route("specialists/{id}")]
        public async Task<ResponseDto> getSpecialistById([FromRoute]  string id)
        {

            SpecialistDto res = await _specialistRepository.GetSpecialistById(id);
            if(res == null)
            {
                _response.success = false;
                _response.result = null;
                //_response.errorMessages.Add(new string("Record not found"));
                _response.DisplayMessage = "Record not found";
            }
            else
            {
                _response.success = true;
                _response.result = res;
            }
            return _response;           

        }

        [HttpDelete]
        [Route("specialists/{id}")]
        public async Task<bool> deleteById([FromRoute] string id)
        {

            bool res = await _specialistRepository.DeleteSpecialist(id);
            
            return res;

        }
    }

}
