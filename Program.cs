var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles(); 

app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "index.html" } 
});
app.UseStaticFiles();

app.Run();
