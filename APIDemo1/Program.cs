using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using APIDemo1.Data;
using Microsoft.AspNetCore.OData;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<APIDemo1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("APIDemo1Context") ?? throw new InvalidOperationException("Connection string 'APIDemo1Context' not found.")));

// Add services to the container.

builder.Services.AddControllers().AddOData(options => options.Select().Filter());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// requires using Microsoft.AspNet.OData.Extensions;

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
