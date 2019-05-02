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
        /// <summary>
        /// Performs a search for the specified query and sorts the results.
        /// </summary>
        /// <param name="query">The search query.</param>
        /// <param name="sort">Sort order of the results.</param>
        /// <param name="requestFlags">The fields to return.</param>
        /// <exception cref="EverythingException">Thrown if the search is unsuccessful.</exception>
        /// <returns>The results of the search.</returns>
        public IEnumerable<EverythingResult> Search(string query, Sort sort = Sort.NameAscending, RequestFlags requestFlags = RequestFlags.FullPathAndFileName)
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

            const int fileAndPathSize = 260;
            StringBuilder fileAndPathBuffer = new StringBuilder(fileAndPathSize);

            uint numResults = Everything_GetNumResults();
            for (uint index = 0; index < numResults; index++)
            {
                fileAndPathBuffer.Clear();
                Everything_GetResultFullPathName(index, fileAndPathBuffer, fileAndPathSize);

                Everything_GetResultSize(index, out long size);
                Everything_GetResultDateCreated(index, out long dateCreated);
                Everything_GetResultDateAccessed(index, out long dateAccessed);
                Everything_GetResultDateModified(index, out long dateModified);
                Everything_GetResultDateRecentlyChanged(index, out long dateRecentlyChanged);
                Everything_GetResultDateRun(index, out long dateRun);

                yield return new EverythingResult
                {
                    Size = size,
                    FullPath = fileAndPathBuffer.ToString(),
                    DateCreated = dateCreated > 0 ? DateTime.FromFileTime(dateCreated) : (DateTime?) null, 
                    DateAccessed = dateAccessed > 0 ? DateTime.FromFileTime(dateAccessed) : (DateTime?) null,
                    DateModified = dateModified > 0 ? DateTime.FromFileTime(dateModified) : (DateTime?) null,
                    DateRecentlyChanged = dateRecentlyChanged > 0 ? DateTime.FromFileTime(dateRecentlyChanged) : (DateTime?) null,
                    DateRun = dateRun > 0 ? DateTime.FromFileTime(dateRun) : (DateTime?) null,
                    RunCount = Everything_GetResultRunCount(index),
                    Attributes = Everything_GetResultAttributes(index)
                };
            }
        }

        /// <summary>
        /// Increments the run counter for the specified result and returns the new run count.
        /// </summary>
        /// <param name="result">The search result to increase the run counter for.</param>
        /// <returns>The new run count.</returns>
        public uint IncrementRunCount(EverythingResult result)
        {
            return Everything_IncRunCountFromFileName(result.FullPath);
        }

        public void Dispose()
        {
            Everything_CleanUp();
        }
    }
}
