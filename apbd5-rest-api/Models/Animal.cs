namespace Tutorial4.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Weight { get; set; }
    public string FurColor { get; set; }
    
    public Animal(int id, string name, string type, double weight, string furColor)
    {
        Id = id;
        Name = name;
        Type = type;
        Weight = weight;
        FurColor = furColor;
    }
}