<div align="center">
    <h1>Mashiro</h1>
    <h4>A lightweight SQL query builder for .NET with a fluent interface</h4>
    <img src="docs/logo.png" />
</div>

## Building

Make sure you have the [.NET Core SDK](https://dotnet.microsoft.com/download) installed first and then run:

```bash
dotnet build
```

## Usage

```c#
    var query = new PostgreSQLQuery();
    var sqlString = query.Select()
                         .From("customer")
                         .Where("age", 20, ComparisonOperator.GreaterThan)
                         .Build();
    Console.WriteLine(sqlString); // SELECT * FROM customer WHERE age > 21
```
