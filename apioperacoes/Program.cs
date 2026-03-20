var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:8000");

var app = builder.Build();

app.MapGet("/", () => "Bem vindo a calculadora");
app.MapGet("/soma", () => new {mensagem= 10 + 5});
app.MapGet("/subtração", () => new {mensagem = 10 - 5});
app.MapGet("/multiplicação", () => new {mensagem = 10 * 5});
app.MapGet("/divisão", () => new {mensagem= 10 / 5 });

app.Run();