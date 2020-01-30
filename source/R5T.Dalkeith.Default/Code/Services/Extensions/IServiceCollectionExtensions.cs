using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Dalkeith.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DataDirectoryNameConvention"/> implementation for <see cref="IDataDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultDataDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<IDataDirectoryNameConvention, DataDirectoryNameConvention>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DataDirectoryNameConvention"/> implementation for <see cref="IDataDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IDataDirectoryNameConvention> AddDefaultDataDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IDataDirectoryNameConvention>(() => services.AddDefaultDataDirectoryNameConvention());
            return serviceAction;
        }
    }
}
