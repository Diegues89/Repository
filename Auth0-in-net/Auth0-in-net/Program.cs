using Auth0.AspNetCore.Authentication;
IConfiguration? configuration = null; //so it can be used on other configuration functions bellow
var builder = WebApplication.CreateBuilder(args);
//create the WebApplication on the current folder

//Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuth0WebAppAuthentication(options =>
{
    options.Domain = "login-dev.login-dev-gruposancorseguros.auth0app.com";
    options.ClientId = "2cmGVZJnxS0B6Ey9rcwSXX0xog2BmkPa";
    //options.ClientSecret = "LiiqbBTwK5jB12zg2ZKIqclbBIZRBLsWrQODS9eTVV9hfNNwvqVeLYUdyh–zLL2";
});




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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
   
app.Run();
