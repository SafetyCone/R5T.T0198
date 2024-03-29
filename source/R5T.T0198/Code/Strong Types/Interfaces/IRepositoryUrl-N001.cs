using System;

using R5T.T0178;
using R5T.T0224;


namespace R5T.T0198.N001
{
    /// <summary>
    /// Strongly-types a string as the URL of a repository.
    /// </summary>
    [StrongTypeMarker]
    public interface IRepositoryUrl : IStrongTypeMarker,
        IUrl
    {
    }
}