namespace StorageApp.Domain;

public class Part
{
    public int Id { get; set; }
    public List<Article> Articles { get; set; } = new List<Article>();
}