using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpecilisteServiceApi.Models;
using SpecilisteServiceApi.Models.Dtos;
using SpecilisteServiceApi.Repositories;
using System.Collections;

namespace SpecilisteServiceApi.Controllers
{
    [Route("api/specialits/")]
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
        [Route("list")]
        public async Task<ResponseDto> GetSpecialistsList()
        {
            IEnumerable<SpecialistDto> res = await _specialistRepository.GetSpecialists();
            _response.success = true;
            _response.result = res;
            return _response;
        }

        [HttpGet]
        [Route("list/{name}")]
        public async Task<object> GetByName([FromRoute] string name)
        {
            IEnumerable<SpecialistDto> res = await _specialistRepository.SearchSpecialistByName(name);
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
        [Route("{id}")]
        public async Task<ResponseDto> getSpecialistById([FromRoute] string id)
        {

            SpecialistDto res = await _specialistRepository.GetSpecialistById(id);
            _response.success = true;
            _response.result = res;
            /*
            if(res == null)
            {
                _response.success = false;
                _response.result = null;
                //_response.errorMessages.Add(new string("Record not found"));
                _response.DisplayMessage = "Record not found";
                return _response;
            }
            
            _response.success = true;
            _response.result = res;
            */
            
            return _response;           

        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ResponseDto> deleteById([FromRoute] string id)
        {
            
            return await _specialistRepository.DeleteSpecialist(id); ;

        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ResponseDto> update(SpecialistRequestDto requestDto, [FromRoute] string id)
        {

            SpecialistDto res = await _specialistRepository.UpdateSpecialist(requestDto, id);
            if(res == null)
            {
                _response.result = null;
                _response.success = false;
                _response.DisplayMessage = "recorrd Not Found";
            }
            else
            {
                _response.result = res;
                _response.success = true;
            }

            return _response;

        }

        
    }

}
