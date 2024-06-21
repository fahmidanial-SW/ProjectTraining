using Microsoft.EntityFrameworkCore;
using ProjectTraining.Application.Mapper;
using ProjectTraining.Application.Service;
using ProjectTraining.Application.Service.Interface;
using ProjectTraining.Domain.Repository.Interface;
using ProjectTraining.Infrastructure.Data.Context;
using ProjectTraining.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
        builder =>
        {
            builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
        });
});

builder.Services.AddScoped<IProjectRepository, ProjectRepository>();

builder.Services.AddScoped<ITrainingService, TrainingService>();


builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddDbContext<QUEDBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("QUEConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowLocalhost");

app.UseAuthorization();

app.MapControllers();

app.Run();
