using System;
using BaltaApplicationOOP.NotificationContext;

namespace BaltaApplicationOOP.SharedContext
{
    public  abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        
        public Guid Id { get; set; }
    }
}