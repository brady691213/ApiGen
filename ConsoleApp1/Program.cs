using CTSCore.Models;
using ModelBuilder;

var sp = new DtoBuilder();

var code = sp.BuildDtoForEntity(typeof(CourseTemplate));

Console.WriteLine(code);