using Microsoft.EntityFrameworkCore;
using WebAPI.GenericCRUD_D8.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ApplicationDbContext>();
string connString = builder.Configuration.GetConnectionString("connMSSQL");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connString));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


builder.Services.AddCors(options =>
{
    options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});



var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseCors("Open");
app.Run();
