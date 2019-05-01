using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EverythingSharp.Enums;

namespace EverythingSharp.Extensions
{
    internal static class ErrorEnumExtensions
    {
        internal static string GetDescription(this Error error)
        {
            return error.GetType()
                .GetMember(error.ToString())
                .FirstOrDefault()
                ?.GetCustomAttribute<DescriptionAttribute>()?
                .Description;
        }
    }
}
