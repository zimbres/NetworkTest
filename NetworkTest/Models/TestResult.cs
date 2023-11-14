namespace NetworkTest.Models;

public class TestResult
{
    public string DateTime { get; set; }
    public List<string> Gateways { get; set; } = new();
    public string Address { get; set; } = string.Empty;
    public string IP { get; set; } = string.Empty;
    public string PingTime { get; set; } = string.Empty;
    public string PingStatus { get; set; } = string.Empty;
    public string Port { get; set; } = string.Empty;
    public string PortStatus { get; set; } = string.Empty;
}
