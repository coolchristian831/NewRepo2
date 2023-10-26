using EsercizioWebAPI.DataSource;
using EsercizioWebAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//  DEPENDENCY INJECTION STRINGA DI CONNESSIONE SQL
builder.Services.AddDbContext<CommerceContext>(options =>
{
    string cnCommerce = builder.Configuration.GetConnectionString("cnCommerce");
    options.UseSqlServer(cnCommerce);
});


builder.Services.AddScoped<CommerceContext, CommerceContext>();
builder.Services.AddScoped<IUtenteService, UtenteService>();
builder.Services.AddScoped<IProdottoService, ProdottoService>();
builder.Services.AddScoped<ICarrelloService, CarrelloService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
