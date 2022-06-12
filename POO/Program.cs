// See https://aka.ms/new-console-template for more information

using POO.ContentContext;
using POO.ContentContext.Enums;

//ARTICLES
var articles = new List<Article>();
articles.Add(new Article("Artigo sobre POO com C#", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Criando uma api com .NET", "dotnet"));

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}

//COURSES
var courses = new List<Course>();
var coursesCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var coursesOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var coursesDotNet = new Course("Fundamentos DotNet","fundamentos-dotnet");

courses.Add((coursesOOP));
courses.Add((coursesCsharp));
courses.Add((coursesDotNet));

//CAREER
var careers = new List<Career>();
var careerDotNet = new Career("Especialista DotNet", "especialista-dotnet");
var careerItem1 = new CareerItem(1,"Comece por aqui", "primeiros passos com c#", coursesCsharp);
var careerItem2 = new CareerItem(2,"Aprenda OOP", "primeiros passos com oop", coursesOOP);
var careerItem3 = new CareerItem(3,"DotNet", "criando uma api", coursesDotNet);

careerDotNet.Items.Add(careerItem1);
careerDotNet.Items.Add(careerItem2);
careerDotNet.Items.Add(careerItem3);
careers.Add(careerDotNet);

foreach(var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course.Title);
        Console.WriteLine(item.Course.Level);
    }
}



