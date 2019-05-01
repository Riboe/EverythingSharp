using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EverythingSharp.Enums;
using EverythingSharp.Exceptions;
using EverythingSharp.Extensions;

namespace EverythingSharp
{
    public class Everything : EverythingBase, IDisposable
    {
        public IEnumerable<EverythingResult> Search(string query)
        {
            return Search(query, Sort.NameAscending);
        }

        public IEnumerable<EverythingResult> Search(string query, Sort sort)
        {
            return Search(query, Sort.NameAscending, RequestFlags.FullPathAndFileName);
        }

        public IEnumerable<EverythingResult> Search(string query, Sort sort, RequestFlags requestFlags)
        {
            Everything_SetSearch(query);
            Everything_SetSort((uint) sort);
            Everything_SetRequestFlags((uint) requestFlags);

            bool success = Everything_Query(true);
            if (!success)
            {
                Error errorCode = (Error) Everything_GetLastError();
                throw new EverythingException(errorCode, errorCode.GetDescription());
            }

            const int bufferSize = 260;
            StringBuilder buffer = new StringBuilder(bufferSize);
            uint numResults = Everything_GetNumResults();

            for (uint index = 0; index < numResults; index++)
            {
                buffer.Clear();

                Everything_GetResultSize(index, out long size);
                Everything_GetResultFullPathName(index, buffer, bufferSize);

                yield return new EverythingResult
                {
                    Size = size,
                    FileName = buffer.ToString()
                };
            }
        }

        public void Dispose()
        {
            Everything_CleanUp();
        }
    }
}
