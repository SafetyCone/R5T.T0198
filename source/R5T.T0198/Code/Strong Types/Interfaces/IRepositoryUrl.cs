using System;

using R5T.F0124;
using R5T.T0178;


namespace R5T.T0198
{
    /// <summary>
    /// Strongly-types a string as the URL of a repository.
    /// Quality-of-life name for <see cref="IGitHubRepositoryUrl"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface IRepositoryUrl : IStrongTypeMarker,
        IGitHubRepositoryUrl
    {
    }
}