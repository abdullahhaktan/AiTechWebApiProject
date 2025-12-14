using AiTech.DataAccess.Repositories.AboutItemRepositories;
using AiTech.DataAccess.Repositories.AboutRepositories;
using AiTech.DataAccess.Repositories.BannerRepositories;
using AiTech.DataAccess.Repositories.CategoryRepository;
using AiTech.DataAccess.Repositories.ChooseRepositories;
using AiTech.DataAccess.Repositories.ContactRepositories;
using AiTech.DataAccess.Repositories.FAQRepositories;
using AiTech.DataAccess.Repositories.FeatureRepositories;
using AiTech.DataAccess.Repositories.ProjectReposityory.cs;
using AiTech.DataAccess.Repositories.SocialRepositories;
using AiTech.DataAccess.Repositories.TeamRepositories;
using AiTech.DataAccess.Repositories.TestimonialRepositories;
using AiTech.DataAccess.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace AiTech.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IProjectRepository,ProjectRepository>();
            services.AddScoped<IBannerRepository,BannerRepository>();
            services.AddScoped<IAboutRepository,AboutRepository>();
            services.AddScoped<IAboutItemRepository,AboutItemRepository>();
            services.AddScoped<ISocialRepository,SocialRepository>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<IChooseRepository, ChooseRepository>();
            services.AddScoped<IFaqRepository, FaqRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<ITestimonailRepository, TestimonialRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();

            services.AddScoped<IUnitOfWork , UnitOfWork>();
        }
    }
}
