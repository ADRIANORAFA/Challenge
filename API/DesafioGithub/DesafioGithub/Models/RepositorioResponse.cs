using Newtonsoft.Json;

namespace DesafioGithub.Models
{
    public class RepositorioResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public OwnerResponse Owner { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
