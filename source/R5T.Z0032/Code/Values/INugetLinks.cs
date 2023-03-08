using System;

using R5T.R0008.Extensions;
using R5T.R0008.T000;
using R5T.T0131;


namespace R5T.Z0032
{
    [ValuesMarker]
    public partial interface INugetLinks : IValuesMarker
    {
        /// <summary>
        /// <see href="https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/"/>
        /// </summary>
        public Link Microsoft_Extensions_DependencyInjection => "https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/".ToLink();
    }
}
