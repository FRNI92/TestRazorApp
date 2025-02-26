using TestRazorApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();


//registrera services
builder.Services.AddSingleton<ProductService>();


var app = builder.Build();

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Urls.Add($"http://0.0.0.0:{port}");


if (!app.Environment.IsDevelopment())//migth comment out during development
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
