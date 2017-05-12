namespace VideoContentPresentation.Models.Contracts
{
    public interface IVideo
    {
        string Id { get; set; }

        string Title { get; set; }

        Link Link { get; set; }
    }
}
