namespace POO.ContentContext.Enums;

public class CareerItem
{
    public CareerItem(int order, string title, string description, Course course)
    {
        if (course == null)
            throw new SystemException("The course cannot be null");
        
        Order = order;
        Title = title;
        Description = description;
        Course = course;
    }
    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course {get; set;}
}