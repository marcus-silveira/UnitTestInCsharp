using TestNinja.Fundamentals;

namespace TestNinja.UnitTest.Fundamentals;

public class ReservationTest
{
    [Fact]
    public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    {
        // Arrange
        var user = new User
        {
            IsAdmin = true
        };
        var reservation = new Reservation();

        // Act
        var sut = reservation.CanBeCancelledBy(user);

        // Assert
        Assert.True(sut);
    }

    [Fact]
    public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
    {
        // Arrange
        var user = new User
        {
            IsAdmin = false
        };

        var reservation = new Reservation
        {
            MadeBy = user
        };

        // Act
        var sut = reservation.CanBeCancelledBy(user);

        // Assert
        Assert.True(sut);
    }

    [Fact]
    public void CanBeCancelledBy_OtherUser_ReturnsFalse()
    {
        // Arrange
        var user = new User
        {
            IsAdmin = false
        };

        var reservation = new Reservation
        {
            MadeBy = new User()
        };

        // Act
        var sut = reservation.CanBeCancelledBy(user);

        // Assert
        Assert.False(sut);
    }
}