using DesafioGithub.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioGithub.Services.Interfaces
{
    public interface IGithubService
    {
        Task<List<RepositorioDTO>> GetSearchRepositorio();
    }
}
