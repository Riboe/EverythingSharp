
using System;

namespace EverythingSharp.Enums
{
    [Flags]
    public enum RequestFlags
    {
        [Obsolete]
        FileName = 0x1,
        [Obsolete]
        Path = 0x2,
        FullPathAndFileName = 0x4,
        [Obsolete]
        Extension = 0x8,
        Size = 0x10,
        DateCreated = 0x20,
        DateModified = 0x40,
        DateAccessed = 0x80,
        Attributes = 0x100,
        FileListFileName = 0x200,
        RunCount = 0x400,
        DateRun = 0x800,
        DateRecentlyChanged = 0x1000,
        HighlightedFileName = 0x2000,
        HighlightedPath = 0x4000,
        HighlightedFullPathAndFileName = 0x8000,
    }
}
