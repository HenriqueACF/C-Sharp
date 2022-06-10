namespace POO.ContentContext;

public abstract class Content
{
    public Content()
    {
        Id = new Guid();
    }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
}