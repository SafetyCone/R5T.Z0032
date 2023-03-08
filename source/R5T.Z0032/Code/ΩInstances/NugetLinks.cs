using System;


namespace R5T.Z0032
{
    public class NugetLinks : INugetLinks
    {
        #region Infrastructure

        public static INugetLinks Instance { get; } = new NugetLinks();


        private NugetLinks()
        {
        }

        #endregion
    }
}
