# The Code Builder Project

Functions to build code elements and project files.

## Builders 

These classes are responsible for generating artifacts for source code required to automatically build a C# solution.
Builders for C# code rely on the Code Document Object Model (CodeDom) mechanism, and other builders, such as for
projects, solutions, and other non-code artifacts, use [Scriban](https://github.com/scriban/scriban) templates. 
- [More on the CodeDom](https://learn.microsoft.com/en-us/dotnet/framework/reflection-and-codedom/dynamic-source-code-generation-and-compilation)

### Non-Code Builders

These generate text content for artifacts such as project files, and use Scriban templates to generate output

### Code Builders

These generate text content for C# classes, structures, and records. 

## Models 

This project uses its own models for input to builders, as facades over the complexities involved in using the 
very abstract CodeDom models. 

### Template Models

These are used as input for rendering [Scriban](https://github.com/scriban/scriban) templates. 

### Code Element Models

These are aimed at being readable and simple to use. 

_Models for code elements are still a work in progress._

## Future Plans

- Trying to move away from throwing exceptions, but it's extremely important to not overwrite ot delete existing code, 
so exceptions are safer than starting to use the Result pattern now. 

### Tasks - Now!

- TASKB: CreateProject creates sln dir and then CreateSolution creates dup dir inside solution dir.
- TASKT: Let solution determine project path. Iterate solution's projects to create project files.
- TASKT: For this version make ;et builders create files with provided paths.

### Tasks - Later

- TASKT: Make template location a realtive path but shareable between this and integration tests.
- TASKT: Interesting issue with order of statements in a method.
- TASKT: Fathom how to get MS ILogger from Serilog.
- TASKT: Replace exceptions with Result pattern.
- TASKT: Use value objects and avoid primitives.
- TASKT: Revise hard-coded defaults for project tfm and RepriseVersion.
- TASKT: Method of determining default solution name and path if not provided.
- TASKT: Delegate path resolution to a `PathResolver` class.
- TASKT: Flesh out `SolutionModel` to include solution and project configs.
- TASKT: Document that we use a convention for project path as `solution/src/projectName.csproj`.
- TASKT: Allow selective or full overwrite for existing output solution folder.

- TASKQ: Decide on managing projectId. Should be owned by solution so not up to project model. 
  - Maybe project model owned by solution, but projectId only used in solution file, not for standalone projects.
