//using GoCloudNative.Bff.Authentication.Auth0;
//using GoCloudNative.Bff.Authentication.ModuleInitializers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddSecurityBff(o =>
//{
//    o.ConfigureAuth0(builder.Configuration.GetSection("Auth0"));
//    o.LoadYarpFromConfig(builder.Configuration.GetSection("ReverseProxy"));
//});

// for open id connect 
//builder.Services.AddSecurityBff(o =>
//{
//    o.ConfigureOpenIdConnect(builder.Configuration.GetSection("OIDC"));
//    o.LoadYarpFromConfig(builder.Configuration.GetSection("ReverseProxy"));
//});
// 
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

//app.UseSecurityBff();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
