using System;
using BaltaApplicationOOP.SharedContext;

namespace BaltaApplicationOOP.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            // Id = Guid.NewGuid();//SPOF
            Title = title;
            Url = url;
        }

        public string Title { get; set; }

        public string Url { get; set; }
    }
}