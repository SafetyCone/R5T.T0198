using System;

using R5T.F0124;
using R5T.T0178;


namespace R5T.T0198
{
    /// <summary>
    /// Strongly-types a string as the URL of a remote repository.
    /// </summary>
    [StrongTypeMarker]
    public interface IRemoteRepositoryUrl : IStrongTypeMarker,
        IUrl
    {
    }
}