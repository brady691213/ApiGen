using CTSCore.Models;
using Reflection;
using SourceBuilder;

var al = new AssemblyLoader();
var asm = al.LoadAssembly(@"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll");

var sp = new DtoBuilder();

var code = sp.BuildDtoForEntity(typeof(CourseTemplate));

Console.WriteLine(code);