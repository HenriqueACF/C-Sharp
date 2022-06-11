// See https://aka.ms/new-console-template for more information

using POO.ContentContext;
using POO.ContentContext.Enums;

Console.WriteLine("POO");

var course = new Course();
course.Level = EContentLevel.Iniciante;

var career = new Career();
career.Items.Add(new CareerItem());
Console.WriteLine(career.TotalCourses);