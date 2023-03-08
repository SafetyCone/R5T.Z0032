using System;

using R5T.R0008.Extensions;
using R5T.R0008.T000;
using R5T.T0131;


namespace R5T.Z0032
{
    [ValuesMarker]
    public partial interface IDotnetLinks : IValuesMarker
    {
        /// <summary>
        /// <see href="https://dotnet.microsoft.com/en-us/apps/aspnet"/>
        /// </summary>
        public Link AspNet => "https://dotnet.microsoft.com/en-us/apps/aspnet".ToLink();
    }
}
