# The Reprise Reflection Project 

Provides functionality for extracting Entity Framework entity information from compiled DbContext classes. 

## Goal

The primary goal of the project is to provide a collection of EF entities as defined by a DbContext that has been 
scaffolded from an existing SQL database. These entities will be used for scaffolding an ASP.NET Minimal API that 
can provided data access for all tables and views in the database behind that DbContext. The API should at least 
expose one endpoint for each of the four CRUD operations relevant to each table or view.

