using Newtonsoft.Json;
using VideoContentPresentation.Models.Contracts;

namespace VideoContentPresentation.Models
{
    public class Video : IVideo
    {
        [JsonProperty("yt:videoId")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public Link Link { get; set; }
    }
}
