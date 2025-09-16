using EntityFrameworkCoreImplementation.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnections")));

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


// implementation of entity framework core 
// install nuget packages
// Microsoft.EntityFrameworkCore, sqlserver ,tools
//
// create a class in the model which will represent the table in the database
//
// create a folder data and add class ApplicationDbContext which will inherit from DbContext
// add dbset property in the ApplicationDbContext class and also add data 
//
// add connection string in the appsettings.json file
//
//register the dbcontext in the program.cs file
//
// open sql server 
//create migration and update database
//
// use the dbcontext in the controller to perform crud operation 



