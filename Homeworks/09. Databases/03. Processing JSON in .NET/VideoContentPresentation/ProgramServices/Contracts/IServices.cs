using System.Collections.Generic;

using Newtonsoft.Json.Linq;
using VideoContentPresentation.Models;

namespace VideoContentPresentation.ProgramServices.Contracts
{
    public interface IServices
    {
        void DownloadRss(string url, string name);

        JObject XmlToJson(string url);

        IEnumerable<JToken> FindAllVideoTitles(JObject json);

        void PrintAllTitles(IEnumerable<JToken> titles);

        IEnumerable<Video> GetCollectionOfVideoObjects(JObject json);

        string CreateHtmlString(IEnumerable<Video> videos);

        void SaveHtmlToPc(string html, string name);
    }
}
