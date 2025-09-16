using MiddlewareImplementation.Custom_middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>(); // register the middleware class in the DI container
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// middleware 1 
app.Use(async (HttpContext context ,RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middle ware 1 ");
    await next(context);
});

// custom middleware 2
//app.UseMiddleware<MyCustomMiddleware>();
// extension method
app.UseMyCustomMiddleware();

// middleware 3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Middle ware 3 ");
});

app.Run();



// how to create a custom middleware class
// create a folder and add a class file
// implement the IMiddleware interface and function invokeAsync 
// register the middleware class in the DI container

// the middleware are executed in the same order they are placed 
// we want to execute the lambda exp as middleware we use app.Use
// we want to execute the middleware class we use app.UseMiddleware

// use extension method in the middleware class where we return  IApplicationBuilder beacause app ,builder are of type WebApplication and WebApplication is of type IApplicationBuilder


