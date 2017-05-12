using Newtonsoft.Json.Linq;

namespace VideoContentPresentation.ProgramServices.Contracts
{
    public interface IServices
    {
        void DownloadRss(string url, string name);

        JObject XmlToJson(string url);
    }
}
