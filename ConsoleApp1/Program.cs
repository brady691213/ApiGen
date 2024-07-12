using CTSCore.Models;
using ModelBuilder;

var sp = new ModelSourceProvider();

var code = sp.BuildDtoForEntity(typeof(CourseTemplate));

Console.WriteLine(code);