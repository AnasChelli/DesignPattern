namespace DesignPattern.Strategy
{
    public interface ICompression
    {
        public string FolderName { get; set; }
        string Compress();
    }
}
