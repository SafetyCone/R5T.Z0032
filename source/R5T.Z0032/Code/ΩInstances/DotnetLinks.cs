using System;


namespace R5T.Z0032
{
    public class DotnetLinks : IDotnetLinks
    {
        #region Infrastructure

        public static IDotnetLinks Instance { get; } = new DotnetLinks();


        private DotnetLinks()
        {
        }

        #endregion
    }
}
