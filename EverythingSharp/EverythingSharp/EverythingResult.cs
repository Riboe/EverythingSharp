using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingSharp
{
    public class EverythingResult
    {
        public long Size { get; internal set; }
        public string FullPath { get; internal set; }
        public DateTime? DateCreated { get; internal set; }
        public DateTime? DateAccessed { get; internal set; }
        public DateTime? DateModified { get; internal set; }
    }
}
