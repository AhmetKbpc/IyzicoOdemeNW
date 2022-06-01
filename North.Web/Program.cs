using Microsoft.EntityFrameworkCore;
using North.Business.Repositories.Abstracts;
using North.Business.Repositories.Abstracts.EntityFrameworkCore;
using North.Core.Entities;
using North.Data;

var builder = WebApplication.CreateBuilder(args);

var Con1 = builder.Configuration.GetConnectionString("Con1");

builder.Services.AddDbContext<NorthwindContext>(options =>
{
    options.UseSqlServer(Con1);
});

builder.Services.AddScoped<IRepository<Category,int>,CategoryRepo()>
// Add services to the container.
builder.Services.AddRazorPages();

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

app.Run();
