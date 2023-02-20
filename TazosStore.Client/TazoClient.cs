using TazosStore.Client.Models;

namespace TazosStore.Client;

public static class TazoClient
{
    private static readonly List<Tazo> tazos = new ()
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

    // READ
    public static Tazo[] GetTazos()
    {
        return tazos.ToArray();
    }
    
    // Create
    public static void Add(Tazo tazo)
    {
        tazo.Id = tazos.Max(t => t.Id) + 1;
        tazos.Add(tazo);
    }

    // Update
    public static Tazo GetTazo(int id)
    {
        return tazos.Find(tazo => tazo.Id == id)??
        throw new Exception("Could not find the tazo");
    }

    public static void UpdateTazo(Tazo updatedTazo)
    {
        Tazo existingTazo = GetTazo(updatedTazo.Id);
        existingTazo.Name = updatedTazo.Name;
        existingTazo.Material = updatedTazo.Material;
        existingTazo.SerialNumber = updatedTazo.SerialNumber;
        existingTazo.Theme = updatedTazo.Theme;
        existingTazo.Size = updatedTazo.Size;
        existingTazo.Price = updatedTazo.Price;
        existingTazo.ReleaseDate = updatedTazo.ReleaseDate;
    }
}