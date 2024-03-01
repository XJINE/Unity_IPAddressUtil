# Untiy_IPAddressUtil

## Importing

You can use Package Manager or import it directly.

```
https://github.com/XJINE/Unity_IPAddressUtil.git?path=Assets/Packages/IPAddressUtil
```

## How to Use

```csharp

    public static readonly IPAddress LocalHostAddress     = IPAddress.Parse("127.0.0.1");
    public static readonly IPAddress LocalLoopbackAddress = LocalHostAddress;

    public static IPAddress[] LocalAddresses { get; } = GetLocalAddresses();

    public static IPAddress[] GetLocalAddresses()
    public static bool HasAddress(string    address)
    public static bool HasAddress(IPAddress address)
}
```