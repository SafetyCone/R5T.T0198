using System;

using R5T.T0132;


namespace R5T.T0198.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IGitHubRepositoryUrl"/>
        public IGitHubRepositoryUrl ToGitHubRepositoryUrl(string value)
        {
            var output = new GitHubRepositoryUrl(value);
            return output;
        }

        /// <inheritdoc cref="IRemoteRepositoryUrl"/>
        public IRemoteRepositoryUrl ToRemoteRepositoryUrl(string value)
        {
            var output = new RemoteRepositoryUrl(value);
            return output;
        }

        /// <inheritdoc cref="IRepositoryUrl"/>
        public IRepositoryUrl ToRepositoryUrl(string value)
        {
            var output = new RepositoryUrl(value);
            return output;
        }
    }
}
