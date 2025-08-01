using AccountManager.Frontend.Clients;
using AccountManager.Frontend.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents();

var AccountManagerApiUrl = builder.Configuration["AccountManagerApiUrl"] ??
    throw new Exception("AccountManagerApiUrl is not configured in appsettings.json");
builder.Services.AddHttpClient<AccountsClient>(client =>
{
    client.BaseAddress = new Uri(AccountManagerApiUrl);
});
builder.Services.AddHttpClient<CategoriesClient>(client =>
{
    client.BaseAddress = new Uri(AccountManagerApiUrl);
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
