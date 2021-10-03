using System.Collections.Generic;

namespace DesignPattern.Strategy
{
    public class CompressContext
    {
        private readonly IEnumerable<ICompression> _folders;

        public CompressContext(IEnumerable<ICompression> folders)
        {
            _folders = folders;
        }

        public string Compress()
        {
            string result = string.Empty;
            foreach (var folder in _folders)
            {
                result += folder.Compress();
            }

            return result;
        }
    }
}
