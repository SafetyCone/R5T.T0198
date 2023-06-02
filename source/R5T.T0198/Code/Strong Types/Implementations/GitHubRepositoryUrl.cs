using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0198
{
    /// <inheritdoc cref="IGitHubRepositoryUrl"/>
    [StrongTypeImplementationMarker]
    public class GitHubRepositoryUrl : TypedBase<string>, IStrongTypeMarker,
        IGitHubRepositoryUrl
    {
        public GitHubRepositoryUrl(string value)
            : base(value)
        {
        }
    }
}