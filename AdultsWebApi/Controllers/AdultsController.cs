using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdultsWebApi.Data;
using AdultsWebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace AdultsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {

        private IAdultService service;

        public AdultsController(IAdultService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> getAdults()
        {
            try
            {
                IList<Adult> adults = await service.GetPersons();
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }


        [HttpPost]
        public async Task<ActionResult> addAdult([FromBody] Adult person)
        {
            try
            {
                service.AddPerson(person);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> removeAdult([FromRoute]int id)
        {
            try
            {
                service.RemovePerson(id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
    }
}