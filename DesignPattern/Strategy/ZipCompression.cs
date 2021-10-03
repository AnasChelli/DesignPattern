namespace DesignPattern.Strategy
{
    public class ZipCompression : ICompression
    {
        public string FolderName { get; set; }
        public ZipCompression(string name)
        {
            FolderName = name;
        }

        public string Compress()
        {
            return $"The {FolderName} Folder is compressed using Zip approach";
        }
    }
}
