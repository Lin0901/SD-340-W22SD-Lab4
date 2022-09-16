using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SD_340_W22SD_Lab4.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SD_340_W22SD_Lab4Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SD_340_W22SD_Lab4Context") ?? throw new InvalidOperationException("Connection string 'SD_340_W22SD_Lab4Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

#region Route 

app.MapGet("/route/{number}", async (int? number, SD_340_W22SD_Lab4Context db) =>
{
    return await db.Route.Where(r => r.Number == number).ToListAsync();
});

#endregion

#region Stop 

app.MapGet("/stop/{number}", async (int? number, SD_340_W22SD_Lab4Context db) =>
{
    return await db.Stop.Where(s => s.Number == number).ToListAsync();
});

#endregion

#region StopSchedule

app.MapGet("/stopschedule", async (int? Number, int top, SD_340_W22SD_Lab4Context db) =>
{
    return await db.ScheduledStop.ToListAsync();
});

#endregion

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
