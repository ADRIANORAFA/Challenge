using Newtonsoft.Json;

namespace DesafioGithub
{
    public class GithubSettings
    {
        [JsonProperty("baseurl")]
        public string BaseUrl { get; set; }
    }
}
