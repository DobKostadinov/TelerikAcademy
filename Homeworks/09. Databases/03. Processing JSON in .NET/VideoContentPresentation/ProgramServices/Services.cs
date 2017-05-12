using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using VideoContentPresentation.Common;
using VideoContentPresentation.Models;
using VideoContentPresentation.ProgramServices.Contracts;

namespace VideoContentPresentation.ProgramServices
{
    public class Services : IServices
    {
        private const string RootDirInXml = "feed";
        private const string SubRootDirInXml = "entry";
        private const string TitleString = "title";

        public void DownloadRss(string url, string name)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(url, name);
            }
        }

        public JObject XmlToJson(string path)
        {
            var xml = File.ReadAllText(DataConstants.TelerikVideosStoredPathAndName);
            var xmlDoc = XDocument.Parse(xml);

            var json = JsonConvert.SerializeXNode(xmlDoc, Formatting.Indented);
            var jsonObj = JObject.Parse(json);

            return jsonObj;
        }

        public IEnumerable<JToken> FindAllVideoTitles(JObject json)
        {
            var allTitles = json[RootDirInXml][SubRootDirInXml]
                .Select(x => x[TitleString]);

            return allTitles;
        }

        public void PrintAllTitles(IEnumerable<JToken> titles)
        {
            Console.WriteLine($"All titles : \n{string.Join(Environment.NewLine, titles)}");
        }

        public IEnumerable<Video> GetCollectionOfVideoObjects(JObject json)
        {
             var collectionOfVideos = json[RootDirInXml][SubRootDirInXml]
                .Select(x => JsonConvert.DeserializeObject<Video>(x.ToString()));

            return collectionOfVideos;
        }

        public string CreateHtmlString(IEnumerable<Video> videos)
        {
            StringBuilder html = new StringBuilder();

            html.Append("<!DOCTYPE html><html><body>");

            foreach (var video in videos)
            {
                html.AppendFormat("<div style=\"float:left; width: 420px; height: 450px; padding:10px; " +
                                  "margin:5px; background-color:grey; border-radius:10px\">" +
                                  "<iframe width=\"420\" height=\"345\" " +
                                  $"src=\"http://www.youtube.com/embed/{video.Id}\"" +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                  $"<h3>{video.Title}</h3><a href=\"{video.Link.Href}\">Go to YouTube</a></div>");
            }

            html.Append("</body></html>");

            return html.ToString();
        }

        public void SaveHtmlToPc(string html, string name)
        {
            using (StreamWriter writer = new StreamWriter(name, false, Encoding.UTF8))
            {
                writer.Write(html);
            }
        }
    }
}
