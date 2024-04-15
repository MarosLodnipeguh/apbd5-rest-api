using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDb
{
    
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1, "Reksio", "Dog", 10.5, "Black"),
        new Animal(2, "Azor", "Dog", 15.5, "White"),
        new Animal(3, "Filemon", "Cat", 5.5, "Black"),
        new Animal(4, "Mruczek", "Cat", 4.5, "White")
    };
    
    public static List<Visit> Visits = new List<Visit>()
    {
        new Visit(1, "2021-03-01", 1, "Vaccination", 50.0),
        new Visit(2, "2021-03-02", 2, "Vaccination", 50.0),
        new Visit(3, "2021-03-03", 3, "Vaccination", 50.0),
        new Visit(4, "2021-03-04", 4, "Vaccination", 50.0),
    };
}