using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingSharp.Enums
{
    public enum Error
    {
        Ok = 0,

        [Description("Failed to allocate memory for the search query.")]
        Memory = 1,

        [Description("IPC is not available. Make sure Everything is running.")]
        Ipc = 2,

        [Description("Failed to register the search query window class.")]
        RegisterClassEx = 3,

        [Description("Failed to create the search query window.")]
        CreateWindow = 4,

        [Description("Failed to create the search query thread.")]
        CreateThread = 5,

        [Description("Failed to register the search query window class.")]
        InvalidIndex = 6,

        [Description("Call Everything_SetReplyWindow before calling Everything_Query with bWait set to FALSE.")]
        InvalidCall = 7
    }
}
