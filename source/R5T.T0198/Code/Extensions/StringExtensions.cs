using System;


namespace R5T.T0198.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToGitHubRepositoryUrl(string)"/>
        public static IGitHubRepositoryUrl ToGitHubRepositoryUrl(this string value)
        {
            return Instances.StringOperator_Extensions.ToGitHubRepositoryUrl(value);
        }

        /// <inheritdoc cref="IStringOperator.ToRemoteRepositoryUrl(string)"/>
        public static IRemoteRepositoryUrl ToRemoteRepositoryUrl(this string value)
        {
            return Instances.StringOperator_Extensions.ToRemoteRepositoryUrl(value);
        }

        /// <inheritdoc cref="IStringOperator.ToRepositoryUrl(string)"/>
        public static IRepositoryUrl ToRepositoryUrl(this string value)
        {
            return Instances.StringOperator_Extensions.ToRepositoryUrl(value);
        }
    }
}
