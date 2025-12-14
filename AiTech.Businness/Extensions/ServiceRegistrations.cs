using AiTech.Businness.Services.AboutItemItemItemServices;
using AiTech.Businness.Services.AboutItemServices;
using AiTech.Businness.Services.AboutServices;
using AiTech.Businness.Services.BannerServices;
using AiTech.Businness.Services.CategoryServices;
using AiTech.Businness.Services.ChooseServices;
using AiTech.Businness.Services.ContactServices;
using AiTech.Businness.Services.FAQServices;
using AiTech.Businness.Services.FeatureServices;
using AiTech.Businness.Services.ProjectServices;
using AiTech.Businness.Services.SocialServices;
using AiTech.Businness.Services.TeamServices;
using AiTech.Businness.Services.TestimonialServices;
using Microsoft.Extensions.DependencyInjection;

namespace AiTech.Businness.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IAboutItemService, AboutItemService>();
            services.AddScoped<ISocialService, SocialService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<IChooseService, ChooseService>();
            services.AddScoped<IFaqService, FaqService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IContactService, ContactService>();
        }
    }
}
