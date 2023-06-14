using System;


namespace R5T.O0018
{
    public class LocalGitRepositoryOperations : ILocalGitRepositoryOperations
    {
        #region Infrastructure

        public static ILocalGitRepositoryOperations Instance { get; } = new LocalGitRepositoryOperations();


        private LocalGitRepositoryOperations()
        {
        }

        #endregion
    }
}
