using POO.ContentContext.Enums;

namespace POO.ContentContext;

public class Lecture
{
    public int Ordem { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel Level { get; set; }
}