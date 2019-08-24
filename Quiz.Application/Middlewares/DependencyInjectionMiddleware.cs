using Microsoft.Extensions.DependencyInjection;
using Quiz.Repository;
using Quiz.Repository.Interfaces;
using Quiz.Services;
using Quiz.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Quiz.Business;
using Quiz.Business.Interfaces;


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
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
            services.AddSingleton<IScoreRepository, ScoreRepository>();
            services.AddSingleton<IQuestionRepository, QuestionRepository>();
            #endregion

            #region Business
            services.AddTransient<IScoreBusiness, ScoreBusiness>();
            services.AddTransient<IAnswerBusiness, AnswerBusiness>();
            #endregion

            #region Services
            services.AddTransient<ICustomerServices, CustomerServices>();
            services.AddTransient<IScoreServices, ScoreServices>();
            services.AddTransient<IQuestionServices, QuestionServices>();
            services.AddTransient<IAnswerServices, AnswerServices>( );
            #endregion
        }
    }
}
