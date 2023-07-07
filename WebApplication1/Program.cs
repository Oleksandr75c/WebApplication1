var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.UseWelcomePage();   // подключение WelcomePageMiddleware
app.MapGet("/", () => "Hello World!");


//app.Run(async (context) => await context.Response.WriteAsync($"HttpContext: {context.Request.HttpContext}"));

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync($"<p>Path: {context.Request.Path}</p>" +
        $"<p>QueryString: {context.Request.QueryString}</p>");
});
//app.Run(async (context) => await context.Response.WriteAsync($"QueryString: {context.Request.QueryString}"));

app.Run();
