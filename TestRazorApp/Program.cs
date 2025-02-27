using TestRazorApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();


//registrera services
builder.Services.AddSingleton<ProductService>();


var app = builder.Build();



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
