using System;

using R5T.R0008.Extensions;
using R5T.R0008.T000;
using R5T.T0131;
using static System.Net.WebRequestMethods;


namespace R5T.Z0032
{
    [ValuesMarker]
    public partial interface IMicrosoftDocumentationLinks : IValuesMarker
    {
        /// <summary>
        /// <see href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicecollectioncontainerbuilderextensions.buildserviceprovider"/>
        /// </summary>
        public Link BuildServiceProvider => "https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicecollectioncontainerbuilderextensions.buildserviceprovider".ToLink();
        /// <summary>
        /// <see href="https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection"/>
        /// </summary>
        public Link DependencyInjection => "https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection".ToLink();
        /// <summary>
        /// <see href="https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles#dependency-inversion"/>
        /// </summary>
        public Link DependencyInversion => "https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/architectural-principles#dependency-inversion".ToLink();
        /// <summary>
        /// <see href="https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-6.0#request-services"/>
        /// </summary>
        public Link RequestServices => "https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-6.0#request-services".ToLink();
        /// <summary>
        /// <see href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicecollection"/>
        /// </summary>
        public Link ServiceCollection => "https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.servicecollection".ToLink();
        /// <summary>
        /// <see href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.serviceprovider"/>
        /// </summary>
        public Link ServiceProvider => "https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.serviceprovider".ToLink();
        /// <summary>
        /// <see href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontextoptionsbuilder.useinternalserviceprovider"/>
        /// </summary>
        public Link UseInternalServiceProvider => "https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontextoptionsbuilder.useinternalserviceprovider".ToLink();
    }
}
