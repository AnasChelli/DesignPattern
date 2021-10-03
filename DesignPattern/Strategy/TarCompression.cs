namespace DesignPattern.Strategy
{
    public class TarCompression : ICompression
    {
        public string FolderName { get; set; }
        public TarCompression(string name)
        {
            FolderName = name;
        }

        public string Compress()
        {
            return $"The {FolderName} Folder is compressed using Tar approach";
        }
    }
}
