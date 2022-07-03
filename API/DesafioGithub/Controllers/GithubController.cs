using DesafioGithub.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesafioGithub.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class GithubController : ControllerBase
    {
        private readonly IGithubService _githubService;

        public GithubController(IGithubService githubService)
        {
            _githubService = githubService;
    }

        [HttpGet()]
        public async Task<IActionResult> Repositorio()
        {
            var result = await _githubService.GetSearchRepositorio();
            return Ok(result);
        }

    }
}
