using Microsoft.EntityFrameworkCore;
using teste.Application.UseCases;
using teste.Domain.Repositories;
using teste.Domain.UseCases;
using teste.Infra.Db;
using teste.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IGetBooks, GetBooks>();
builder.Services.AddScoped<ICreateBook, CreateBook>();

builder.Services.AddDbContext<AppDbContext>(options =>
 options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Urls.Add("http://*:5000");

app.Run();

