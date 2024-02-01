using TestNinja.Fundamentals;

namespace TestNinja.UnitTest.Fundamentals;

public class ErrorLoggerTests
{
    [Fact]
    public void Log_WhenCalled_SetTheLastErrorProperty()
    {
        var logger = new ErrorLogger();
        
        logger.Log("abc");
        
        Assert.Equal("abc", logger.LastError);
    }
}