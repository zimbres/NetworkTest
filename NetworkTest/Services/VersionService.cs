namespace NetworkTest.Services;

public static class VersionService
{
    public static string GetVersion()
    {
        return Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }
}
