namespace Tutorial4.Models;

public class Visit
{
    public int Id { get; set; }
    public String Date { get; set; }
    public int AnimalId { get; set; }
    public String Description { get; set; }
    public Double Cost { get; set; }
    
    public Visit(int id, String date, int animalId, String description, Double cost)
    {
        Id = id;
        Date = date;
        AnimalId = animalId;
        Description = description;
        Cost = cost;
    }
}