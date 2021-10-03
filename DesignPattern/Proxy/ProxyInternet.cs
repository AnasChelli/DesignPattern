using System.Collections.Generic;

namespace DesignPattern.Proxy
{
    public class ProxyInternet : IInternet
    {
        private readonly RealInternet _realInternet;

        public ProxyInternet(RealInternet realInternet)
        {
            _realInternet = realInternet;
        }
        public string ConnectTo(string website)
        {
            if (GetForbiddenWebsite().Contains(website))
            {
                return $"Access Denied";
            }

            return _realInternet.ConnectTo(website);
        }

        private List<string> GetForbiddenWebsite()
        {
            return new List<string> { "toto.com", "tata.com" };
        }
    }
}
