using AiTech.WebUi.Services.AboutServices;
using AiTech.WebUi.Services.CategoryServices;
using AiTech.WebUi.Services.GeminiServices;
using AiTech.WebUi.Services.ProjectServices;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace AiTech.WebUi.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddUIServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IGeminiService, GeminiService>();
            services.AddScoped<IAboutService, AboutService>();

            services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters()
                .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
