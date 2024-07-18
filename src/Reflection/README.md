# The Reprise Reflection Project 

Provides functionality for extracting Entity Framework entity information from compiled DbContext classes. 

## Goal

The primary goal of the project is to provide a collection of EF entities as defined by a compiled DbContext. This
class has been scaffolded from an existing SQL database using an EF Database First approach. This list of entities
will be used to scaffold an ASP.NET Minimal API that can provide data access for all tables and views
in the SQL database. The API should expose endpoints any CRUD operations applicable to each table or view.

