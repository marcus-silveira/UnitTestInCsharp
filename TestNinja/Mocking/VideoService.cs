using System.Data.Entity;
using System.Text.Json;

namespace TestNinja.Mocking;

public class VideoService(IFileReader fileReader, IVideoRepository repository)
{
    public string ReadVideoTitle()
    {
        try
        {
            var str = fileReader.Read("video.txt");
            var video = JsonSerializer.Deserialize<Video>(str);

            return video == null ? "Error parsing the video" : video.Title;
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error deserializing JSON: {ex.Message}");
            return "Error parsing the video";
        }
    }

    public string GetUnProcessedVideoAsCsv()
    {
        var videosIds = new List<int>();
        var videos = repository.GetUnprocessedVideos();

        videosIds.AddRange(videos.Select(v => v.Id));

        return string.Join(",", videosIds);
    }
}

public class Video
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsProcessed { get; set; }
}

public class VideoContext : DbContext
{
    public DbSet<Video> Videos { get; set; }
}