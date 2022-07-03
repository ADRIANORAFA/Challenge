using DesafioGithub.Models;
using RestEase;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesafioGithub.Services.Restease
{
   
    public interface IGithubRepositorio
    {
        [Header("user-agent", "request")]
        [Get("orgs/takenet/repos?language=c%23&sort=created_at&direction=asc&per_page=10")]
        [AllowAnyStatusCode]

        Task<List<RepositorioResponse>> GetSearchRepositorio();
    }
}
