using GameStore.api.Data;
using GameStore.api.Dtos;
using GameStore.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation();

var connString = builder.Configuration.GetConnectionString("GameStore");

builder.Services.AddSqlite<GameStoreContext>(connString);
var app = builder.Build();

app.MapGamesEndpoint();

app.Run();
