# Code Builder

Functions to build code elements and project files.

## Notes

- Trying to move away from throwing exceptions, but it's extremely important to not overwrite ot delete existing code, 
so exceptions are safer than starting to use the Result pattern now. 

## Tasks - Now!

- TASKB: CreateProject creates sln dir and then CreateSolution creates dup dir inside solution dir.
- TASKT: Let solution determine project path. Iterate solution's projects to create project files.
- TASKT: For this version make ;et builders create files with provided paths.

## Tasks - Later

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
