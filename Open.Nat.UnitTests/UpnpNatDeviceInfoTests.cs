using System;
using System.Net;
using Xunit;

namespace Open.Nat.UnitTests
{
	public class UpnpNatDeviceInfoTests : IDisposable
	{
        public void Dispose()
        {
        }

        [Fact]
		public void x()
		{
			var info = new UpnpNatDeviceInfo(IPAddress.Loopback, new Uri("http://127.0.0.1:3221"), "/control?WANIPConnection", null);
			Assert.Equal("http://127.0.0.1:3221/control?WANIPConnection", info.ServiceControlUri.ToString());
		}
	}
}
