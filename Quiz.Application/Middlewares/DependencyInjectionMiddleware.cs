using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Application.Middlewares
{

    /// <summary>
    /// Classe de injeção de dependência no container DI
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class DependencyInjectionMiddleware
    {
        /// <summary>
        /// Adiciona todas as dependências do projeto no container de DI
        /// </summary>
        /// <param name="services">Container Services</param>
        public static void AddDependencyInjection( this IServiceCollection services )
        {

            #region Repositories

            #endregion

            #region Business

            #endregion

            #region Services

            #endregion
        }
    }
}
