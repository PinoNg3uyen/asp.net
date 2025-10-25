using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;

var builder = WebApplication.CreateBuilder(args);
string connectingString = builder.Configuration.GetConnectionString("MyConnectionString") ?? "";


builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(connectingString);
});


builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
   
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Define the default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
