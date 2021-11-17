using System.Collections.Generic;
using System.Security;
using BaltaApplicationOOP.NotificationContext;
using BaltaApplicationOOP.SharedContext;

namespace BaltaApplicationOOP.ContentContext
{
    public class CareerItem : Base
    {
        public IList <string> Notifications { get; set; }
        
        public CareerItem(int order, string title, string description, Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso Invalido"));
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}