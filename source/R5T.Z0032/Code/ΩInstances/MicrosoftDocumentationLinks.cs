using System;


namespace R5T.Z0032
{
    public class MicrosoftDocumentationLinks : IMicrosoftDocumentationLinks
    {
        #region Infrastructure

        public static IMicrosoftDocumentationLinks Instance { get; } = new MicrosoftDocumentationLinks();


        private MicrosoftDocumentationLinks()
        {
        }

        #endregion
    }
}
