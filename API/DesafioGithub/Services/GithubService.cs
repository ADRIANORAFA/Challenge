using DesafioGithub.Models;
using DesafioGithub.Services.Interfaces;
using DesafioGithub.Services.Restease;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioGithub.Services
{
    public class GithubService : IGithubService
    {
        private readonly IGithubRepositorio _githubRepositorio;

        public GithubService(IGithubRepositorio githubRepositorio)
        {
            _githubRepositorio = githubRepositorio;       
        }
        public async Task<List<RepositorioDTO>> GetSearchRepositorio()
        {
            try
            {

                var response = await _githubRepositorio.GetSearchRepositorio();

                var list = new List<RepositorioDTO>();

                foreach (var item in response)
                {
                    if (item.Language == "C#")
                    {
                    var itemResponse = new RepositorioDTO(item);

                    list.Add(itemResponse);
                    }
                }


                return list;
            }
            catch (System.Exception)
            {

                return new List<RepositorioDTO>();
            }
        }
    }
}
