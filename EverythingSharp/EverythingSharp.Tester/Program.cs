﻿using System;
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
                IEnumerable<EverythingResult> results = everything.Search("League of Legends", Sort.NameAscending, RequestFlags.Size | RequestFlags.FullPathAndFileName | RequestFlags.DateAccessed | RequestFlags.DateCreated | RequestFlags.DateModified);

                foreach (EverythingResult result in results)
                {
                    Console.WriteLine($"{result.FullPath} | {result.DateModified}");
                }
            }

            Console.ReadKey();
        }
    }
}