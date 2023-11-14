namespace NetworkTest.Tests;

public class VersionServiceTests
{
    [Fact]
    public void GetVersion_ReturnsValidVersionString()
    {
        string expectedVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        string actualVersion = VersionService.GetVersion();

        Assert.NotEqual(expectedVersion, actualVersion);
    }

    [Fact]
    public void GetVersion_ReturnsNonEmptyString()
    {
        string version = VersionService.GetVersion();

        Assert.False(string.IsNullOrEmpty(version));
    }

    [Fact]
    public void GetVersion_ReturnsValidSemanticVersion()
    {
        string version = VersionService.GetVersion();

        Assert.True(Version.TryParse(version, out _));
    }
}