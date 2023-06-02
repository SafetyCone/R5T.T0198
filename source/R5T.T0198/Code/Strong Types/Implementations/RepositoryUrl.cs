using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0198
{
    /// <inheritdoc cref="IRepositoryUrl"/>
    [StrongTypeImplementationMarker]
    public class RepositoryUrl : TypedBase<string>, IStrongTypeMarker,
        IRepositoryUrl
    {
        public RepositoryUrl(string value)
            : base(value)
        {
        }
    }
}