# Code Builder

Functions to build code elements and project files.

## Tasks - Now!

- TASKT: Let solution determine project path. Iterate solution's projects to create project files.
- TASKT: For this version make ;et builders create files with provided paths.

## Tasks - Later

- TASKT: Use value objects and avoid primitives.
- TASKT: Revise hard-coded defaults for project tfm and RepriseVersion.
- TASKT: Method of determining default solution name and path if not provided.
- TASKT: Delegate path resolution to a `PathResolver` class.
- TASKT: Flesh out `SolutionModel` to include solution and project configs.
- TASKT: Document that we use a convention for project path as `solution/src/projectName.csproj`.
- TASKT: Allow selective or full overwrite for existing output solution folder.

- TASKQ: Decide on managing projectId. Should be owned by solution so not up to project model. 
  - Maybe project model owned by solution, but projectId only used in solution file, not for standalone projects.
