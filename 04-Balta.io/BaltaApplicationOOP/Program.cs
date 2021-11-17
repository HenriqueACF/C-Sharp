using System;
using System.Collections.Generic;
using System.Linq;
using BaltaApplicationOOP.ContentContext;

namespace BaltaApplicationOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo OOP em C#", "orientacao-objetos"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            courses.Add(courseOOP);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseOOP);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x=>x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                }
            }

        }
    }
}
