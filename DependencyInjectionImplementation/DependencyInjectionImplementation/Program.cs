using DependencyInjectionImplementation.DI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMessaging, Messaging>(); // register the interface and class in the DI container

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


// implementation of dependency injection
// define an interface 
// implement the interface in a class
// register the interface and class in the DI container
//Inject the interface in the controller constructor
// use viewbag .message to display the message 
// add @viewbag.Message in the index view of the home controller 