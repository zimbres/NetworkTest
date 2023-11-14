namespace NetworkTest.Services;

internal static class GatewayService
{
    internal static List<string> GetGateways()
    {
        List<string> gateways = new();
        try
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up && !networkInterface.Name.Contains("Tunneling"))
                {
                    GatewayIPAddressInformationCollection gatewayAddresses = networkInterface.GetIPProperties().GatewayAddresses;

                    foreach (GatewayIPAddressInformation gatewayAddress in gatewayAddresses)
                    {
                        if (gatewayAddress.Address != null)
                        {
                            gateways.Add(gatewayAddress.Address.ToString());
                        }
                    }
                }
            }
        }
        catch { }
        return gateways;
    }
}
