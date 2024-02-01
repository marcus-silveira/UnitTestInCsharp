using TestNinja.Fundamentals;

namespace TestNinja.UnitTest.Fundamentals;

public class DemeritPointsCalculatorTests
{
    [Theory]
    [InlineData(100, 7)]
    [InlineData(175, 22)]
    [InlineData(300, 47)]
    public void CalculateDemeritPoints_SpeedBetweenTheSpeedLimitAndTheMaxSpeed_ReturnsDemeritPoints(int speed,
        int demeritPoints)
    {
        // Arrange
        var demeritPointsCalculator = new DemeritPointsCalculator();

        // Act
        var sut = demeritPointsCalculator.CalculateDemeritPoints(speed);

        // Assert
        Assert.Equal(demeritPoints, sut);
    }

    [Theory]
    [InlineData(40, 0)]
    [InlineData(60, 0)]
    [InlineData(65, 0)]
    public void CalculateDemeritPoints_SpeedBelowTheLimitOrEqualToSpeedLimit_ReturnsZero(int speed,
        int demeritPoints)
    {
        // Arrange
        var demeritPointsCalculator = new DemeritPointsCalculator();

        // Act
        var sut = demeritPointsCalculator.CalculateDemeritPoints(speed);

        // Assert
        Assert.Equal(demeritPoints, sut);
    }

    [Theory]
    [InlineData(-10)]
    [InlineData(450)]
    public void CalculateDemeritPoints_SpeedLessThanZeroAndGreaterThanTheLimit_ThrowArgumentOutOfRangeException(
        int speed)
    {
        // Arrange
        var demeritPointsCalculator = new DemeritPointsCalculator();

        // Act e Assert
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            demeritPointsCalculator.CalculateDemeritPoints(speed));
    }
}