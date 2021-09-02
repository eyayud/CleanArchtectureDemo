using CleanArch.Applicaiton.Interfaces;
using CleanArch.Applicaiton.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastracture.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infrastructure.Ioc
{
   public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infrastructure.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
