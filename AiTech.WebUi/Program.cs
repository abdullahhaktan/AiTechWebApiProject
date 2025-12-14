using AiTech.WebUi.Extensions;
using AiTech.WebUi.Services.AboutItemItemServices;
using AiTech.WebUi.Services.AboutItemServices;
using AiTech.WebUi.Services.AboutServices;
using AiTech.WebUi.Services.BannerServices;
using AiTech.WebUi.Services.ChooseServices;
using AiTech.WebUi.Services.ContactServices;
using AiTech.WebUi.Services.FaqServices;
using AiTech.WebUi.Services.FeatureServices;
using AiTech.WebUi.Services.SocialServices;
using AiTech.WebUi.Services.TeamServices;
using AiTech.WebUi.Services.TestimonialServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddUIServices();
builder.Services.AddScoped<IBannerService, BannerService>();
builder.Services.AddScoped<IAboutService, AboutService>();
builder.Services.AddScoped<IAboutItemService, AboutItemService>();
builder.Services.AddScoped<ISocialService, SocialService>();
builder.Services.AddScoped<IFeatureService, FeatureService>();
builder.Services.AddScoped<IChooseService, ChooseService>();
builder.Services.AddScoped<IFaqService, FaqService>();
builder.Services.AddScoped<ITeamService, TeamService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
  name: "areas",
  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
