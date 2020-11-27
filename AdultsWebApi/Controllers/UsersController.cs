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
    public class UsersController : ControllerBase
    {
        
        private IUserService service;

        public UsersController(IUserService userService)
        {
            service = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<User>>> getUsers()
        {
            try
            {
                //IList<User> users = await service.getUsers();
                return Ok(await service.getUsers());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
        
    }
}