using DesignPattern.Proxy;
using NFluent;
using NUnit.Framework;

namespace DesignPatternTest.ProxyTest
{
    class InternetTest
    {
        private RealInternet _realInternet;
        private ProxyInternet _proxyInternet;

        [SetUp]
        public void SetUp()
        {
            _realInternet = new RealInternet();
            _proxyInternet = new ProxyInternet(_realInternet);
        }

        [Test]
        public void Should_not_access_to_forbidden_website()
        {
            var result = _proxyInternet.ConnectTo("toto.com");

            Check.That(result).Equals("Access Denied");
        }

        [Test]
        public void Should_access_to_real_website()
        {
            var result = _proxyInternet.ConnectTo("proxy.com");

            Check.That(result).Equals("We are tring to connect to proxy.com");
        }
    }
}
