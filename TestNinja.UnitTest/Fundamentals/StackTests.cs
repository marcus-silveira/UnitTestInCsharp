using Xunit;

namespace UnitTestInCsharp.UnitTest;

public class StackTests
{
    [Fact]
    public void Push_WhenCalled_AddObjInTheStack()
    {
        // Arrange
        var stack = new Stack<int>();

        // Act
        stack.Push(5);
        stack.Push(6);
        stack.Push(4);

        // Assert
        Assert.Equal(4, stack.Peek());
        Assert.Equal(3, stack.Count);
    }
    
    [Fact]
    public void Pop_WhenCalled_RemoveLastObjInTheStack()
    {
        // Arrange
        var stack = new Stack<int>();

        // Act
        stack.Push(5);
        stack.Push(63);
        stack.Push(34);
        stack.Push(44);

        // Assert
        Assert.Equal(44, stack.Pop());
        Assert.Equal(3, stack.Count);
    }
    
    [Fact]
    public void Peek_WhenCalled_ShowLastObjInTheStack()
    {
        // Arrange
        var stack = new Stack<int>();

        // Act
        stack.Push(5);
        stack.Push(63);
        stack.Push(34);
        stack.Push(44);
        stack.Pop();

        // Assert
        Assert.Equal(34, stack.Peek());
    }
}