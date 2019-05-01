
namespace EverythingSharp.Enums
{
    public enum RequestFlags
    {
        FileName = 1,
        Path = 2,
        FullPathAndFileName = 4,
        Extension = 8,
        Size = 16,
        DateCreated = 32,
        DateModified = 64,
        DateAccessed = 128,
        Attributes = 256,
        FileListFileName = 512,
        RunCount = 1024,
        DateRun = 2048,
        DateRecentlyChanged = 4096,
        HighlightedFileName = 8192,
        HighlightedPath = 16384,
        HighlightedFullPathAndFileName = 32768,
    }
}
