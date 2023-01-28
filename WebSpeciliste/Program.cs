using WebSpeciliste;
using WebSpeciliste.services;
using WebSpeciliste.services.CustomerServices;
using WebSpeciliste.services.SpecialistsService;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ISpecialist, SpecialistService>();
builder.Services.AddHttpClient<ISpecialist, SpecialistService>();
SD.hostSpecialist = builder.Configuration["ServiceUrls:SpecialistAPI"];
SD.hostCustomer = builder.Configuration["ServiceUrls:CustomerAPI"];
builder.Services.AddScoped<ISpecialist, SpecialistService>();
builder.Services.AddScoped<ICustomer, Customerservice>();
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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
