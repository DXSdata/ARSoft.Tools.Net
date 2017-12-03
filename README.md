# ARSoft.Tools.Net for .NET Core / Standard 2.0
This is a fork of alexreinert/ARSoft.Tools.Net.
While the original repos is used with .NET Framework, you can use this one with .NET Core / .NET Standard.

A Nuget package is also available: https://www.nuget.org/packages/ARSoft.Tools.NetStandard.DXSdata


# Sample SPF check



```CSharp
static void Main(string[] args)
        {
            //SFP data check; test if the combination below is allowed to send emails

            var val = new SpfValidator();

            IPAddress publicHostIp = IPAddress.Parse("8.8.8.8");
            var fromDomain = new DomainName(new string[] { "example", "com" });
            var fromEmail = "test@example.com";

            var result = val.CheckHost(publicHostIp, fromDomain, fromEmail);

            Console.WriteLine("Result: " + result.Result);
            Console.ReadKey();
        }
```

# Links
- Website  http://www.dxsdata.com/2017/12/arsoft-tools-netstandard