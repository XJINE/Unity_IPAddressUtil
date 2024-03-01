using System.Linq;
using System.Net;

public static class IPAddressUtil
{
    public static readonly IPAddress LocalHostAddress     = IPAddress.Parse("127.0.0.1");
    public static readonly IPAddress LocalLoopbackAddress = LocalHostAddress;

    public static IPAddress[] LocalAddresses { get; } = GetLocalAddresses();

    public static IPAddress[] GetLocalAddresses()
    {
        return Dns.GetHostEntry("").AddressList;
        // return Dns.GetHostAddresses(Dns.GetHostName());
    }

    public static bool HasAddress(string address)
    {
        return LocalAddresses.Any(localAddress => localAddress.ToString() == address);
    }

    public static bool HasAddress(IPAddress address)
    {
        return LocalAddresses.Any(localAddress => Equals(localAddress, address));
    }
}