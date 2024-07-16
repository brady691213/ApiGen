# Code Builder

Functions to build code elements and project files.

## Tasks

- TASKT: Revise hard-coded defaults for project tfm and RepriseVersion.
- TASKT: Method of determining default solution name and path if not provided.
- TASKT: Delegate path resolution to a `PathResolver` class.
- TASKT: Flesh out `SolutionModel` to include solution and project configs.
- TASKT: Document that we use a convention for project path as `solution/src/projectName.csproj`.

- TASKQ: Decide on managing projectId. Should be owned by solution so not up to project model. 
  - Maybe project model owned by solution, but projectId only used in solution file, not for standalone projects.
