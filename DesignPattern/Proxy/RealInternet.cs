namespace DesignPattern.Proxy
{
    public class RealInternet : IInternet
    {
        public string ConnectTo(string website)
        {
            return $"We are tring to connect to {website}";
        }
    }
}
