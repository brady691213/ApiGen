# Code Scaffolding

Code responsible for generating the code artifacts required for a complete C# solution.
Builders for C# code rely on the Code Document Object Model, or [CodeDom](https://learn.microsoft.com/en-us/dotnet/framework/reflection-and-codedom/dynamic-source-code-generation-and-compilation)
mechanism, and other builders, such as for projects, solutions, and other non-code artifacts, use [Scriban](https://github.com/scriban/scriban) 
templates. 

## Bugs



## Targets

- 20:00 - Refactor finished and HellowWorld finished enough for more effort on FE API:
  - Finished enough is Result patterns tidied up and no chance of exceptions.
  - DryRun must provide full reporting on all outcomes via Serilog.

## Tasks - Now

- Replace `LoadProjectFileTemplate` with a general path based `Load` function. 
- Use Rascal Errors as much as possible.
- Guard clauses all over, anywhere a param can go wrong.
- Detailed and careful logging to console.
- Use statics where OK
- Don't use namespaces as containers, rather use a shared namespace name and generate code for classes etc.
- Merge `CodeFileModel` and `ClassModel`
- Merge `TypeBuiler` and `ClassBuilder`
- Tests for builders and generators
- Check all optional params - remove where uncertain.
- Proofread MD and XML documentation. 

- Keep using nested Result functions and types as a goal.
- Move app specific CodeDom functions into `Application` namespace then make CodeDom functions more generic.
- StatementModel and BuildCodeStatement.
- Get `Type` without needing a reference and `typeof` etc.
- Store real file paths in project and solution models and use models as types for Result.
- Compiler suggestion at `CodeExpression[] parameters = ParameterBuilder.ModelsToExpressions(paramModels);`
- Use facade models more.
- Logging to other sinks like Windows Event Log and file.
- Look at more stateful classes for builders, cut down on noisy param lists.
- Make builder method params optional and use known defaults
- Make cli app a dotnet tool.
- Element builders for properties
- Element builders for parameters
- Element builders for statements
- Generalize `BuildHelloWorldApp` into `BuildConsoleApp`
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


