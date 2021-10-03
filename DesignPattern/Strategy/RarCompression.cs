namespace DesignPattern.Strategy
{
    public class RarCompression : ICompression
    {
        public string FolderName { get; set; }
        public RarCompression(string name)
        {
            FolderName = name;
        }

        public string Compress()
        {
            return $"The {FolderName} Folder is compressed using Rar approach";
        }
    }
}
