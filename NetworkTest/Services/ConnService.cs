namespace NetworkTest.Services;

internal class ConnService
{
    public TestResult CheckConn(string address, string port)
    {
        Ping ping = new();
        var result = new TestResult
        {
            Address = address,
            Port = port,
            DateTime = DateTime.UtcNow.ToString("o", CultureInfo.InvariantCulture)
        };

        try
        {
            var gateways = GatewayService.GetGateways();
            result.Gateways = gateways;
        }
        catch { }

        try
        {
            double averageResponseTime = 0;
            long totalResponseTime = 0;
            var reply = ping.Send(address);
            for (int i = 0; i < 4; i++)
            {
                totalResponseTime += reply.RoundtripTime;
                Task.Delay(1000).Wait();
            }
            averageResponseTime = (double)totalResponseTime / 4;
            result.PingStatus = reply.Status.ToString();
            result.PingTime = averageResponseTime.ToString();
        }
        catch { }

        using TcpClient tcpClient = new();
        try
        {
            tcpClient.Connect(address, int.Parse(port));
            result.PortStatus = "Successful connection";
        }
        catch
        {
            result.PortStatus = "Failed to connect";
        }

        try
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(address);
            IPAddress[] addresses = hostEntry.AddressList;
            if (addresses.Length > 0) result.IP = addresses[0].ToString();
        }
        catch { }

        return result;
    }
}
