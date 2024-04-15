using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class AnimalEndpoints
{
    
    // 200 - Ok
    // 201 - Created
    // 400 - Bad request
    // 401 - Unauthorized
    // 403 - Forbidden
    // 404 - Not Found
    
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        // pobieranie listy zwierzaków
        // GET /animals
        app.MapGet("/animals", () =>
        {
            var animals = MockDb.animals;
            return Results.Ok(animals);
        });

        // pobieranie zwierzaka po id
        // GET /animals/{id}
        app.MapGet("/animals/{id}", (int id) =>
        {
            var animal = MockDb.animals.FirstOrDefault(a => a.Id == id);
            return Results.Ok(animal);
        });
        
        // dodawanie nowego zwierzaka
        // PUT /animals/{id}
        app.MapPut("/animals/{id}", (Animal animal) =>
        {
            MockDb.animals.Add(animal);
            return Results.Created("", animal);
        });

        // edycja zwierzaka
        // POST /animals
        app.MapPost("/animals/{id}", (int id, Animal newAnimal) =>
        {
            var animalToUpdate = MockDb.animals.FirstOrDefault(a => a.Id == id);
            
            if (animalToUpdate == null)
            {
                return Results.NotFound(); // Return 404 if animal with the given id is not found
            }
            
            animalToUpdate.Name = newAnimal.Name;
            animalToUpdate.Type = newAnimal.Type;
            animalToUpdate.Weight = newAnimal.Weight;
            animalToUpdate.FurColor = newAnimal.FurColor;
            
            return Results.Ok(animalToUpdate);
        });
        
        // usuwanie zwierzaka
        // DELETE /animals/{id}
        app.MapDelete("/animals/{id}", (int id) =>
        {
            var animalToDelete = MockDb.animals.FirstOrDefault(a => a.Id == id);
            MockDb.animals.Remove(animalToDelete);
            return Results.Ok();
        });
        
        // dodawanie wizyty do zwierzaka
        // PUT /animals/{id}/visits
        app.MapPut("/animals/{id}/visits", (Visit visit) =>
        {
            MockDb.Visits.Add(visit);
            return Results.Created("", visit);
        });
        
        // pobieranie wizyt zwierzaka
        // GET /animals/{id}/visits
        app.MapGet("/animals/{id}/visits", (int id) =>
        {
            var visit = MockDb.Visits.FirstOrDefault(a => a.Id == id);
            return Results.Ok(visit);
        });
        
        
    }

}