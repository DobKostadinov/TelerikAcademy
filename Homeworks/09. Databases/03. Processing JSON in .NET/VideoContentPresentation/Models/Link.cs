using Newtonsoft.Json;
using VideoContentPresentation.Models.Contracts;

namespace VideoContentPresentation.Models
{
    public class Link : ILink
    {
        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}
