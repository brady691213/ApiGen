# Code Scaffolding

Code responsible for generating the code artifacts required for a complete C# solution.
Builders for C# code rely on the Code Document Object Model, or [CodeDom](https://learn.microsoft.com/en-us/dotnet/framework/reflection-and-codedom/dynamic-source-code-generation-and-compilation)
mechanism, and other builders, such as for projects, solutions, and other non-code artifacts, use [Scriban](https://github.com/scriban/scriban) 
templates. 

## Bugs

- TASKB: Console main project model has no code models.

## Goals

- 18:00 - As much testing of fe generation possible.

## API Code Elements

- Delegate response value to some sort of service and mapper.

## Tasks - Now


- TASKT: Unit tests for all codedom expression/statement builders

- TASKT: Work on primitive obsession. Too many plain strings and lists of strings, too easy to swap. 
- TASKT: Use an entity type to build ep and dtos.
- TASKT: How to get types without referencing assemblies.
- TASKT: Separate Build and Generate on solutions and projects. Better testing.
- TASKT: Some blank lines in generated code. 
- TASKT: Establish features, namespace per feature
- TASKT: Use list of ep/dto/entity etc.
- TASKT: Introduce data service into api generation = no mapping/validation
- TASKT: Decide whether to make `System` a required or a default import for generating code.
- TASKT: Do I attempt dir and file creation for dry runs?
- TASKT: Group expression builders by type, e.g. properties, local variables etc.
- Use Rascal Errors more.
- Use statics where OK
- Tests for builders and generators
- Check all optional params - remove where uncertain.


- TASKT: Use `CodeSnippetTypeMember` for auto-props.
- TASKT: Start on Class Library
- TASKT: Check behavior for generic console app.  Without hello in Main
- TASKT: Use entity types for ep and dto names and types.
- Detailed and careful logging to console.
- Guard clauses all over - but these throw exceptions
- Keep using nested Result functions and types as a goal.
- Compiler suggestion at `CodeExpression[] parameters = ParameterBuilder.ModelsToExpressions(paramModels);`
- Use facade models more.
- Logging to other sinks like Windows Event Log and file.
- Look at more stateful classes for builders, cut down on noisy param lists.
- Make cli app a dotnet tool.
- Remove 'by a tool' comments using regex: `\/\/.*[\s\S]*?\/\/.*`
- Benchmarks

### Benchmarks

We aren't generating many files by any means, but if this code is to be used in a compile-time source generator 
then perf is very important. Areas to check:

- `CSharpCodeGenerator` - Probably very expensive to instantiate compile units for each file

### WebAppScaffolder

- Scaffold an ASP.NET minimal API using the `FastEndpoints` framework.
- Models and scaffolders for:
  - Endpoint
  - Request and Response DTOs
  - Validators

## Classes

### ConsoleAppBuilder

Creates a C# solution with one console app project. The solution is created with the following structure. 

```
HelloWorld
    HelloWorld.sln
    src/HelloWorld
        HelloWorld.csproj
        Program.cs
```   

This class uses [SolutionBuilder](#solutionbuilder) and [ProjectBuilder](#projectbuilder) to scaffold source artifacts.

### SolutionBuilder

Creates a C# solution with a solution (.sln) file with zero to many projects. The solution is created in a
subdirectory of the provided output directory. 

The solution is created with the following structure. An example for a Hello World console app is:

```
HelloWorld
    HelloWorld.sln
    src/HelloWorld
        HelloWorld.csproj
        Program.cs
```        
        
By default, however, `SolutionBuilder` will not create a `src` folder or any projects. This class uses a Scriban 
template to create the `.sln` file, and then `ProjectBuilder` to create projects. 

### ProjectBuilder

Creates C# project with a project file (.csproj), and a `Program' class. The project is created in a
subdirectory of the provided output directory. If not provided, the app's current directory is used.
The program class looks like this:

```csharp
namespace HelloWorld
{        
    public class Program
    {        
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello world");
        }
    }
}
```

This class uses a Scriban template to create the project (`.csproj`) file and `CodeDom` based classes to create
C# code (`.cs`) files.

## Models 

This project uses its own models for input to builders, as facades over the complexities involved in using the 
very abstract CodeDom models. 

### Template Models

These are used as input for rendering [Scriban](https://github.com/scriban/scriban) templates. Two such models and templates 

### Code Element Models

These are aimed at being readable and simple to use. 

_Models for code elements are still a work in progress._

## Next Iteration

- Make templates shareable between this and integration tests.
- Interesting issue with order of statements in a method.
- Use IHost and DI
- Replace exceptions with Result pattern.
- Use value objects and avoid primitives.
- Revise hard-coded defaults for project tfm and RepriseVersion.
- Method of determining default solution name and path if not provided.
- Delegate path resolution to a `PathResolver` class.
- Flesh out `SolutionModel` to include solution and project configs.
- Document that we use a convention for project path as `solution/src/projectName.csproj`.
- Allow selective or full overwrite for existing output solution folder.


