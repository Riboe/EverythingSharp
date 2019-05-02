using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverythingSharp.Enums;

namespace EverythingSharp.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Everything everything = new Everything())
            {
                IEnumerable<EverythingResult> results = everything.Search("League of Legends", 10, 0, Sort.RunCountDescending, RequestFlags.Size | RequestFlags.FullPathAndFileName | RequestFlags.DateAccessed |
                                                                                                                   RequestFlags.DateCreated | RequestFlags.DateModified | RequestFlags.RunCount |
                                                                                                                   RequestFlags.DateRecentlyChanged | RequestFlags.DateRun | RequestFlags.Attributes);

                foreach (EverythingResult result in results)
                {
                    Console.WriteLine(result.FullPath);
                }
            }

            Console.ReadKey();
        }
    }
}
