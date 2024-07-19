﻿# Code Scaffolding

Code responsible for [scaffolding](#Scaffolding) the code artifacts required for a complete C# solution.
Builders for C# code rely on the Code Document Object Model, or [CodeDom](https://learn.microsoft.com/en-us/dotnet/framework/reflection-and-codedom/dynamic-source-code-generation-and-compilation)
mechanism, and other builders, such as for projects, solutions, and other non-code artifacts, use [Scriban](https://github.com/scriban/scriban) 
templates. 

## Tasks - Now

- TASKT: Merge `CodeFileModel` and `ClassModel`
- TASKT: Merge `TypeBuiler` and `ClassBuilder`
- TASKT: Tests for builders and scaffolders

## Tasks - Next

- TASKT: Element builders for properties
- TASKT: Element builders for parameters
- TASKT: Element builders for statements
- TASKT: Generalize `BuildHelloWorldApp` into `BuildConsoleApp`

### WebAppScaffolder

- Scaffold an ASP.NET minimal API using the `FastEndpoints` framework.
- Models and scaffolders for:
  - Endpoint
  - Request and Response DTOs
  - Validators

### Scaffolding

I use the term scaffolding because _generation_ may be mistaken to refer to source generators,
and _building_ may be mistaken for the context of compiling.

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

