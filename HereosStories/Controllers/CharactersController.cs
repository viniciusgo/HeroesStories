using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HereosStories.Controllers
{
    [Route("api/[controller]")]
    public class CharactersController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public Task<CharactersResponse> Characters()
        {
            var apiClient = new APIClient.APIClient();
            return apiClient.GetCharacteres();
        }
    }
}
