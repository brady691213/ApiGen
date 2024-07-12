using CTSCore.Models;
using ModelBuilder;

var sp = new ModelSourceProvider();

var code = sp.BuildEntityDto(typeof(CourseTemplate));

Console.WriteLine(code);