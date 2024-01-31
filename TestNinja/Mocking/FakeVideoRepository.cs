namespace TestNinja.Mocking;

public class FakeVideoRepository : IVideoRepository
{
    public IEnumerable<Video> GetUnprocessedVideos()
    {
        var videos = new List<Video>();
        videos.Add(new Video
        {
            Id = 12,
            Title = "Video Unit Testing",
            IsProcessed = false
        });

        return videos;
    }
}