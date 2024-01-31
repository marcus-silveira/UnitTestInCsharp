using TestNinja.Mocking;

namespace TestNinja.UnitTest.Mocking;

public class VideoServiceTests
{
    [Fact]
    public void ReadFileTitle_EmptyFile_ReturnErroParsing()
    {
        // Arrange
        var fileReader = new FakeFileReader();
        var repository = new FakeVideoRepository();

        var videoService = new VideoService(fileReader, repository);

        // Act
        var sut = videoService.ReadVideoTitle();

        // Assert
        // Assert.Contains("Error", sut);
    }
}