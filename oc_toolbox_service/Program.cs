using Microsoft.AspNetCore.Mvc.ModelBinding;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<oc_toolbox_service.Services.ProductSetService>();
builder.Services.AddTransient<oc_toolbox_service.Services.DocListService>();
builder.Services.AddTransient<oc_toolbox_service.Services.VideoListService>();
builder.Services.AddTransient<oc_toolbox_service.Services.LabelSdsListService>();
builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    options.JsonSerializerOptions.WriteIndented = true;
});
string? toolboxDb = builder.Configuration.GetConnectionString("OCToolboxReader");
ServiceBase.OCToolboxDbConnectionString = toolboxDb;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();
