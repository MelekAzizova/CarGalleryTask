namespace CarGalleryTaskIndexer.Models;

public class Car
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int ProduceYear { get; set; }

    public override string ToString()
    {
        return $"Car names is {Name}";
    }
}
