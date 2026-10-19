# OData (Open Data Protocol) Playground

This project is a hands-on experiment with OData: what it is, how it works with
an ASP.NET Core API, and what clients can do with it.

OData (Open Data Protocol) adds a standard way for clients to query and work
with API resources. Rather than creating a separate endpoint for every query,
clients can request options such as filtering, sorting, and selecting fields
through URL query parameters.

## What this project demonstrates

- An ASP.NET Core 8 Web API exposing products through an OData endpoint.
- OData query options for selecting fields (`$select`), filtering (`$filter`),
  and sorting (`$orderby`).
- Entity Framework Core with SQLite for product data.
- Automatic sample product seeding when the database is empty.

## Run the project

You need the .NET 8 SDK. From the project directory, run:

```sh
dotnet run
```

The API uses the SQLite database configured in `appsettings.Development.json`.
Once the app is running, query the products at:

```text
/odata/Products
```

For example, append OData query options to explore the data:

```text
/odata/Products?$select=Name,Price
/odata/Products?$filter=Price gt 100
/odata/Products?$orderby=Price desc
```

This is a learning project, so the supported query options and API surface may
grow as I experiment with OData.