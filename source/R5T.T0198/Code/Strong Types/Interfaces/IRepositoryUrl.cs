using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0198
{
    /// <summary>
    /// Strongly-types a string as the URL of a repository.
    /// </summary>
    [StrongTypeMarker]
    public interface IRepositoryUrl : IStrongTypeMarker,
        ITyped<string>
    {
    }
}