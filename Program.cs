using KSTrans.DATA.DatabaseSettings;
using KSTrans.Services;
using KSTrans.Shared.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<DatabaseSettings>(
                builder.Configuration.GetSection("ConnectionStrings"));

#region Scoped
builder.Services.AddScoped<IRepository<About>, AboutService>();
builder.Services.AddScoped<IRepository<Files>, FilesService>();
builder.Services.AddScoped<IRepository<Image>, ImageService>();
builder.Services.AddScoped<IRepository<Links>, LinksService>();
builder.Services.AddScoped<IRepository<OurServices>, OurServicesService>();
builder.Services.AddScoped<IRepository<SocialMediaAccounts>, SocialMediaAccountsService>();
builder.Services.AddScoped<IRepository<Testimonial>, TestimonialService>();
builder.Services.AddScoped<IRepository<WhyChoosingUs>, WhyChoosingUsService>();
#endregion

 

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
