using SourceReader;

// var al = new AssemblyLoader();
// var asm = al.LoadAssembly(@"C:\Users\brady\projects\ApiGen\Library\CTSCore.dll");
//
// var sp = new DtoBuilder();
//
// var code = sp.BuildDtoForEntity(DtoRequestResponse.Request, typeof(CourseTemplate));
//
// Console.WriteLine(code);

var parser = new SourceParser();

// var props = parser.GetEntityProperties();
//
// var lines = "";
// foreach (var prop in props)
// {
//     lines += Path.GetFileName(prop.DeclaringFile).Replace(".cs", "") + ":\t\t" + prop.MatchedDec + Environment.NewLine;
// }
//
// File.WriteAllText("properties.txt", lines);

var uniq = parser.GetModelsFromAssembly();

var x = uniq.Count;


