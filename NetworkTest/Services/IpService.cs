namespace NetworkTest.Services;

public static class IpService
{
    public static bool IsValidIPv4(this string ipAddress)
    {
        string ipv4Pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

        if (Regex.IsMatch(ipAddress, ipv4Pattern))
        {
            return true;
        }
        return false;
    }
}
