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
        private readonly IHttpClientFactory _httpClientFactory;

        public ProfileController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try{
                var client = _httpClientFactory.CreateClient("ProfileApiClient");
                var result = await client.GetStringAsync("");
                return Ok(result);
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProfileDTO profileDTO)
        {
            profileDTO.department = String.IsNullOrEmpty(profileDTO.department) ? "Not provided." : profileDTO.department;
            profileDTO.team = String.IsNullOrEmpty(profileDTO.team) ? "Not provided." : profileDTO.team;

            var client = _httpClientFactory.CreateClient("ProfileApiClient");
            var result = await client.PostAsJsonAsync("", profileDTO);
            return Ok(await result.Content.ReadAsStringAsync());
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
