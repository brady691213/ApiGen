using CTSCore.Models;
using EntityDecompiler;

var sp = new ModelSourceProvider();

var code = sp.BuildEntityDto(typeof(CourseTemplate));

Console.WriteLine(code);