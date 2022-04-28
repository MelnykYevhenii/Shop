var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//app.MapGet("/", () => "Hello World!");
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
app.Run();