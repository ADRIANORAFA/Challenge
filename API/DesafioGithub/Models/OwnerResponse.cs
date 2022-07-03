using Newtonsoft.Json;

namespace DesafioGithub.Models
{
    public class OwnerResponse
    {

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

    }
}
