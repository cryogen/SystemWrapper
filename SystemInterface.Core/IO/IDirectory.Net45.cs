namespace SystemInterface.Core.IO
{
    public partial interface IDirectory
    {
#if NET45
        IEnumerable<string> EnumerateFiles(string path);

        IEnumerable<string> EnumerateFiles(string path, string searchPattern);

        IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);
#endif
    }
}