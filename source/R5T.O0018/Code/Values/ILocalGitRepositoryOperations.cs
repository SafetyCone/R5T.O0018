using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0180;
using R5T.T0200;
using R5T.T0200.Extensions;


namespace R5T.O0018
{
    [ValuesMarker]
    public partial interface ILocalGitRepositoryOperations : IValuesMarker,
        O0023.IGitOperations
    {
        public async Task Test()
        {
            //Instances.LocalRepositoryContextOperator.In_LocalRepositoryContext(
            //    )
        }

        public IRepositoryDirectoryPath Get_RepositoryDirectoryPath_ForPathInRepository(
            IPath path)
        {
            var output = Instances.GitOperator.GetRepositoryDirectoryPath(path.Value)
                .ToRepositoryDirectoryPath();

            return output;
        }
    }
}
