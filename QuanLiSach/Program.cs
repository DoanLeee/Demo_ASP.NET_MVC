using Microsoft.EntityFrameworkCore;
using QuanLiSach.Repository;

var builder = WebApplication.CreateBuilder(args);


//Connection D
builder.Services.AddDbContext<DataContext>(options =>
{
	options.UseSqlServer(builder.Configuration["ConnectionStrings:ConnectedD"]);
});
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

//Seeding data
using (var scope = app.Services.CreateScope())
{
	var services = scope.ServiceProvider;
	var context = services.GetRequiredService<DataContext>();

	
	if (!context.Products.Any())
	{
		
		SeedData.SeedingData(context);
	}
}
app.Run();
