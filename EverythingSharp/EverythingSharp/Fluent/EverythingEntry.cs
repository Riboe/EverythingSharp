using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverythingSharp.Enums;

namespace EverythingSharp.Fluent
{
    public class EverythingEntry
    {
        public long Size { get; internal set; }
        public string FullPath { get; internal set; }
        public DateTime? DateCreated { get; internal set; }
        public DateTime? DateAccessed { get; internal set; }
        public DateTime? DateModified { get; internal set; }
        public DateTime? DateRecentlyChanged { get; internal set; }
        public DateTime? DateRun { get; internal set; }
        public uint RunCount { get; internal set; }
        public uint? Attributes { get; internal set; }
        public EntryType Type { get; internal set; }
    }
}
