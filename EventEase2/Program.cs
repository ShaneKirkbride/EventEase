using EventEase2.Shared; // Optional: if you use shared models/services
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EventEase2.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<IEventService, MockEventService>();
builder.Services.AddScoped<IRegistrationService, MockRegistrationService>();
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub(); // For Blazor Server SignalR connection
app.MapFallbackToPage("/_Host");

app.Run();
