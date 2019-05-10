using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingSharp.Enums
{
    enum FileInfoType : uint
    {
        FileSize = 1,
        FFolderSize = 2,
        DateCreated = 3,
        DateModified = 4,
        DateAccessed = 5,
        Attributes = 6
    }
}
