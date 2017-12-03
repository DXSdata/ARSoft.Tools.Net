using ARSoft.Tools.Net;
using ARSoft.Tools.Net.Spf;
using System;
using System.Net;

namespace ARSoft.Tools.NetStandard.SampleSPF
{
    class Program
    {
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
    }
}
