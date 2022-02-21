//this will contain all of the mapping to SQL database for this project
// linking db connection str in appsettings.json to dbConText.cs 

using AbbyCRUD.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// builder.Services.AddControllers(); // if MVC is used  //Parsing options into AppDbConText
builder.Services.AddDbContext<AppDbConText> (options=>options.UseSqlServer(
   builder.Configuration.GetConnectionString("dbCon") )); // adding a connection class



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

// app.UseAuthentication(); //authentication should always comes before authorization (Dictionary)

app.UseAuthorization();

app.MapRazorPages();

app.Run();
