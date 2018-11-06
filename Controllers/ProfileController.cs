using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using ProfileApi.Services;
using ProfileApi.DTOs;

namespace ProfileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        string baseUrl = "http://zware-ngnewapi.azurewebsites.net/api/developersamim_at_gmail_com/profiles";
        private readonly IProfileApiClient _profileApiClient;

        public ProfileController(IProfileApiClient profileApiClient)
        {
            _profileApiClient = profileApiClient;
        }

        // GET api/values
        [HttpGet]
        public async Task<List<Profile>> Get()
        {
            return await _profileApiClient.GetAllProfile();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
