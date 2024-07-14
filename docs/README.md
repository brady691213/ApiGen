# Reprise

A project to generate code for a REPR pattern ASP.NET Minimal API based on entities defined by an EF Core DbContext.

## Status

This project is still in an early discovery stage, and still very experimental. 
You can use it if you like living on the edge, or just fork it and only use some. 

Reprise should be ready for trial use in about two months, all going well.

## Tasks

- TASKT: Centralise config values and constants
- TASKT: Access modifiers. Everything is public, but we should really be using internal more.
- TASKT: More unit tests.
- TASKT: Use ClassFixture for tests
- TASKT: Logging
- TASKT: IOptions, config. etc.
- TASKT: Alternate, runtime config and DI for tests.

## Raison d'être

This project arose when someone asked me if a web API could be "scaffolded" like an [Entity Framework Core (EF)](https://github.com/dotnet/efcore) 
[DbContext](https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext?view=efcore-8.0) class 
can be scaffolded from a database in [EF database first](https://learn.microsoft.com/en-us/ef/ef6/modeling/designer/workflows/database-first) scenarios.

While there are several free and paid products available to achieve this lofty goal, my concerns over simplicity and security convinced me 
that a custom solution would be a better option. This project is the first outline of what future, fully customised solutions might ook like.

## Design 
### The REPR Pattern

I was influenced by the [REPR](https://deviq.com/design-patterns/repr-design-pattern) design pattern as used the [FastEndpoints](#fastendpoints) project. 

With the **REPR** pattern, web APIs have three simple components:
- a Request
- an Endpoint
- a Response

### FastEndpoints

An active and well-supported open source project for building ASP.NET Core web APIs suing the **REPR** design pattern. [FastEndpoints](https://github.com/FastEndpoints/FastEndpoints)

This project uses the **REPR** pattern and [Vertical Slice Architecture](https://www.jimmybogard.com/vertical-slice-architecture/) to provide an elegant and efficient  
alternative to Minimal APIs as provided by ASP.NET Core.

## Projects

### SourceBuilder 
Used to generate source code for Request and Response DTOs and Endpoint classes. **This is not a source generator**, but simply uses text templates to generate C# source code.

### Reflection

Used to derive EF entity type information from DbContext classes.

### TypesForTests

Created to provide fixed and known entity and DbContext types for use in unit tests for the other projects. 
To be continued later when I move beyond integration tests and start needing unit tests. 


