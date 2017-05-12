using VideoContentPresentation.Common;
using VideoContentPresentation.ProgramServices;

namespace VideoContentPresentation
{
    public class StartUp
    {
        public static void Main()
        {
            var services = new Services();

            services.DownloadRss(DataConstants.TelerikRssUrl, DataConstants.TelerikVideosStoredPathAndName);

            var telerikRssVideosAsJson = services.XmlToJson(DataConstants.TelerikVideosStoredPathAndName);

            var allVideoTitles = services.FindAllVideoTitles(telerikRssVideosAsJson);

            services.PrintAllTitles(allVideoTitles);

            var collectionOfVideoObjs = services.GetCollectionOfVideoObjects(telerikRssVideosAsJson);

            var htmlAsString = services.CreateHtmlString(collectionOfVideoObjs);

            services.SaveHtmlToPc(htmlAsString, DataConstants.NewGeneratedHtmlPathAndName);
        }
    }
}
