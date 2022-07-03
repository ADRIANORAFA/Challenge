using Newtonsoft.Json;

namespace DesafioGithub.Models
{
    public class RepositorioDTO
    {

        public RepositorioDTO(RepositorioResponse repo)
        {
            Name = repo.Name;
            Description = repo.Description;
            ReposUrl = repo.HtmlUrl;
            AvatarUrl = repo.Owner.AvatarUrl;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string AvatarUrl { get; set; }

        public string ReposUrl { get; set; }



    }
}
