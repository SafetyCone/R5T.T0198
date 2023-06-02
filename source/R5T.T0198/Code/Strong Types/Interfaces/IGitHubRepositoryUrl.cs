using System;

using R5T.T0178;


namespace R5T.T0198
{
    /// <summary>
    /// Strongly-types a string as the URL of a GitHub repository.
    /// </summary>
    [StrongTypeMarker]
    public interface IGitHubRepositoryUrl : IStrongTypeMarker,
        IRemoteRepositoryUrl
    {
    }
}