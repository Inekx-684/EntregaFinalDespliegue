var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    var html = @"<!DOCTYPE html>
<html lang=""es"">
<head>
    <meta charset=""utf-8"" />
    <title>Aplicación Web Básica</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 2rem;
        }
        .card {
            max-width: 500px;
            border: 1px solid #ddd;
            border-radius: 10px;
            padding: 1.5rem;
            box-shadow: 0 2px 4px rgba(0,0,0,0.08);
        }
        h1 {
            margin-top: 0;
        }
        button {
            padding: 0.5rem 1rem;
            border-radius: 6px;
            border: 1px solid #ccc;
            cursor: pointer;
        }
    </style>
</head>
<body>
    <div class=""card"">
        <h1>👋</h1>
        <p>Esta es una aplicación web básica funcional, ejecutándose en Visual Studio 2022.</p>
        <button onclick=""alert('¡La aplicación funciona correctamente!')"">
            Probar
        </button>
    </div>
</body>
</html>";

    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync(html);
});

app.MapGet("/saludo", () => "Hola desde /saludo");

app.Run();


