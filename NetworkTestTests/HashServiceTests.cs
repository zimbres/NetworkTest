namespace NetworkTest.Tests;

public class HashServiceTests
{
    [Fact]
    public void HashLog_ShouldReturnHashedString_WhenInputIsGiven()
    {
        string input = "Hello world";
        string expected = "1002321172baf02227f3463180810122abfc54c1d6f951bb09e72f963b6160c4";

        string actual = HashService.HashLog(input);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void HashLog_ShouldReturnDifferentHashedString_WhenInputIsDifferent()
    {
        string input1 = "Hello world";
        string input2 = "Goodbye world";
        string expected1 = "1002321172baf02227f3463180810122abfc54c1d6f951bb09e72f963b6160c4";
        string expected2 = "9179ff3a0811b1e749efa5fc5214a17a9e323279cedaa0f4fb532c636836aad9";

        string actual1 = HashService.HashLog(input1);
        string actual2 = HashService.HashLog(input2);

        Assert.Equal(expected1, actual1);
        Assert.Equal(expected2, actual2);
        Assert.NotEqual(actual1, actual2);
    }

    [Fact]
    public void HashLog_ShouldReturnEmptyString_WhenInputIsEmpty()
    {
        string input = "";
        string expected = "";

        string actual = HashService.HashLog(input);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void HashLog_ShouldReturnNull_WhenInputIsNull()
    {
        string input = null;
        string expected = null;

        string actual = HashService.HashLog(input);

        Assert.Equal(expected, actual);
    }
}
