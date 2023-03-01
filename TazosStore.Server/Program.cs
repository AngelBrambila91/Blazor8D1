using TazosStore.Server.Models;
List<Tazo> tazos = new()
    {
        new Tazo()
        {
            Id=1,
            Name= "Ricochet",
            Material = "Metal",
            SerialNumber = "01/100",
            Theme = "Mucha Lucha",
            Size = "L",
            Price = 18.19M,
            ReleaseDate = new DateTime(2005,1,8)
        },
        new Tazo()
        {
            Id=2,
            Name= "La Pulga",
            Material = "Metal",
            SerialNumber = "02/100",
            Theme = "Mucha Lucha",
            Size = "L",
            Price = 20.8M,
            ReleaseDate = new DateTime(2005,1,9)
        },
        new Tazo()
        {
            Id=3,
            Name= "Buena Niña",
            Material = "Metal",
            SerialNumber = "03/100",
            Theme = "Mucha Lucha",
            Size = "L",
            Price = 40.2M,
            ReleaseDate = new DateTime(2005,1,8)
        }
    };

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var group = app.MapGroup("/tazos");

// READ ALL
group.MapGet("/", () => tazos);
// READ ID
// GET/tazos/{id}
group.MapGet("/{id}", (int id) =>
{
    Tazo? tazo = tazos.Find(tazo => tazo.Id == id);
    if (tazo == null)
    {
        // return 404
        return Results.NotFound();
    }
    // return 200 OK
    return Results.Ok(tazo);
});

//POST/tazos
group.MapPost("/", (Tazo tazo) =>
{
    tazo.Id = tazos.Max(tazo => tazo.Id) + 1;
    tazos.Add(tazo);
    return Results.CreatedAtRoute("GetTazo", new { id = tazo.Id }, tazo);
}).WithName("GetTazo");
app.Run();
