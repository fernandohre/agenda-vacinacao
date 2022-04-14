using Microsoft.EntityFrameworkCore;
using Vacinacao.Api.Extensions.IoC;
using Vacinacao.Core.AutoMapper;
using Vacinacao.Core.Data;
using Vacinacao.Infraestrutura.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;
var configuration = builder.Configuration;
services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();


services.AddDbContext<AgendaVacinacaoContext>(opts =>
{
    var connectionString = configuration.GetConnectionString(nameof(AgendaVacinacaoContext));
    opts.UseSqlServer(connectionString);
});

services.AddDbContext<IAgendaVacinacaoContext, AgendaVacinacaoContext>(opts =>
{
    var connectionString = configuration.GetConnectionString(nameof(AgendaVacinacaoContext));
    opts.UseSqlServer(connectionString);
});
//Adicionando inje��o de depend�ncia dos nossos repositories e dos services
services.AddRepositories();
services.AddServices();
services.AddAutoMapper(typeof(DtoEntity));

var app = builder.Build();

using var serviceScope = app.Services.CreateScope();
using var context = serviceScope.ServiceProvider.GetRequiredService<AgendaVacinacaoContext>();
context?.Database.Migrate();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
