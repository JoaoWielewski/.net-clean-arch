namespace teste.Domain.Entities;

public class Book(string id, string description, string name)
{
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
}
