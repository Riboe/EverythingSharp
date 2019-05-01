using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EverythingSharp
{
    public abstract class EverythingBase
    {
        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern int Everything_SetSearch(string lpSearchString);
        [DllImport("Everything32.dll")]
        public static extern void Everything_SetMatchPath(bool bEnable);
        [DllImport("Everything32.dll")]
        public static extern void Everything_SetMatchCase(bool bEnable);
        [DllImport("Everything32.dll")]
        public static extern void Everything_SetMatchWholeWord(bool bEnable);
        [DllImport("Everything32.dll")]
        public static extern void Everything_SetRegex(bool bEnable);
        [DllImport("Everything32.dll")]
        public static extern void Everything_SetMax(UInt32 dwMax);
        [DllImport("Everything32.dll")]
        public static extern void Everything_SetOffset(UInt32 dwOffset);

        [DllImport("Everything32.dll")]
        public static extern bool Everything_GetMatchPath();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_GetMatchCase();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_GetMatchWholeWord();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_GetRegex();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetMax();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetOffset();
        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern string Everything_GetSearch();
        [DllImport("Everything32.dll")]
        public static extern int Everything_GetLastError();

        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern bool Everything_Query(bool bWait);

        [DllImport("Everything32.dll")]
        public static extern void Everything_SortResultsByPath();

        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetNumFileResults();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetNumFolderResults();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetNumResults();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetTotFileResults();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetTotFolderResults();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetTotResults();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_IsVolumeResult(UInt32 nIndex);
        [DllImport("Everything32.dll")]
        public static extern bool Everything_IsFolderResult(UInt32 nIndex);
        [DllImport("Everything32.dll")]
        public static extern bool Everything_IsFileResult(UInt32 nIndex);
        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern void Everything_GetResultFullPathName(UInt32 nIndex, StringBuilder lpString, UInt32 nMaxCount);
        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern string Everything_GetResultPath(UInt32 nIndex);
        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern string Everything_GetResultFileName(UInt32 nIndex);

        [DllImport("Everything32.dll")]
        public static extern void Everything_Reset();
        /// <summary>
        ///  Resets the result list and search state, freeing any allocated memory by the library.
        /// </summary>
        /// <remarks>
        /// You should call Everything_CleanUp to free any memory allocated by the Everything SDK.
        /// Calling <see cref="Everything_SetSearch"/> frees the old search and allocates the new search string.
        /// Calling <see cref="Everything_Query"/> frees the old result list and allocates the new result list.
        /// </remarks>
        [DllImport("Everything32.dll")]
        public static extern void Everything_CleanUp();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetMajorVersion();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetMinorVersion();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetRevision();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetBuildNumber();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_Exit();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_IsDBLoaded();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_IsAdmin();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_IsAppData();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_RebuildDB();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_UpdateAllFolderIndexes();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_SaveDB();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_SaveRunHistory();
        [DllImport("Everything32.dll")]
        public static extern bool Everything_DeleteRunHistory();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetTargetMachine();

        // Everything 1.4
        [DllImport("Everything32.dll")]
        public static extern void Everything_SetSort(UInt32 dwSortType);
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetSort();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetResultListSort();
        [DllImport("Everything32.dll")]
        public static extern void Everything_SetRequestFlags(UInt32 dwRequestFlags);
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetRequestFlags();
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetResultListRequestFlags();
        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern string Everything_GetResultExtension(UInt32 nIndex);
        [DllImport("Everything32.dll")]
        public static extern bool Everything_GetResultSize(UInt32 nIndex, out long lpFileSize);
        [DllImport("Everything32.dll")]
        public static extern bool Everything_GetResultDateCreated(UInt32 nIndex, out long lpFileTime);
        [DllImport("Everything32.dll")]
        public static extern bool Everything_GetResultDateModified(UInt32 nIndex, out long lpFileTime);
        [DllImport("Everything32.dll")]
        public static extern bool Everything_GetResultDateAccessed(UInt32 nIndex, out long lpFileTime);
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetResultAttributes(UInt32 nIndex);
        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern string Everything_GetResultFileListFileName(UInt32 nIndex);
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetResultRunCount(UInt32 nIndex);
        [DllImport("Everything32.dll")]
        public static extern bool Everything_GetResultDateRun(UInt32 nIndex, out long lpFileTime);
        [DllImport("Everything32.dll")]
        public static extern bool Everything_GetResultDateRecentlyChanged(UInt32 nIndex, out long lpFileTime);
        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern string Everything_GetResultHighlightedFileName(UInt32 nIndex);
        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern string Everything_GetResultHighlightedPath(UInt32 nIndex);
        [DllImport("Everything32.dll", CharSet = CharSet.Unicode)]
        public static extern string Everything_GetResultHighlightedFullPathAndFileName(UInt32 nIndex);
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_GetRunCountFromFileName(string lpFileName);
        [DllImport("Everything32.dll")]
        public static extern bool Everything_SetRunCountFromFileName(string lpFileName, UInt32 dwRunCount);
        [DllImport("Everything32.dll")]
        public static extern UInt32 Everything_IncRunCountFromFileName(string lpFileName);
    }
}
