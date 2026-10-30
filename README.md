# Design_Patterns

Creational, Behavioral, and Structural Design Patterns, implemented in C#.

## The three main groups of patterns

1. **Creational patterns** provide object creation mechanisms that increase the flexibility and reuse of existing code.
2. **Structural patterns** explain how to assemble objects and classes into larger structures, while keeping the structure flexible and efficient.
3. **Behavioral patterns** take care of effective communication and the assignment of responsibilities between objects.

## Implemented patterns

So far only the **Creational** group has an implementation. There are no Structural or Behavioral folders yet.

| Group | Pattern | Source | Diagram | Description |
|---|---|---|---|---|
| Creational | Factory Method | [Program.cs](Creational/C-Sharp/FactoryMethod/Program.cs) | [Diagram.puml](Creational/C-Sharp/Diagram.puml) | An abstract `Creator` declares `FactoryMethod()`; `ConcreteCreatorA`/`ConcreteCreatorB` override it to return `ConcreteProductA`/`ConcreteProductB` (both implement `IProduct`), and the client works only with `Creator`. |
| Structural | - | - | - | Not implemented yet. |
| Behavioral | - | - | - | Not implemented yet. |

The class diagram is written in [PlantUML](https://plantuml.com/); render it with the PlantUML CLI or an editor extension.

## Project layout

```
Creational/
  C-Sharp/
    Diagram.puml                    Factory Method class diagram
    FactoryMethod/
      FactoryMethod.csproj          console project (net7.0)
      Program.cs
```

## How to run

Requires the [.NET SDK](https://dotnet.microsoft.com/download) (7.0 or newer).

```bash
dotnet run --project Creational/C-Sharp/FactoryMethod
```

The project targets .NET 7, which is out of support. If only a newer runtime is installed, run it with
`DOTNET_ROLL_FORWARD=Major dotnet run --project Creational/C-Sharp/FactoryMethod`.
You can also open `FactoryMethod.csproj` in Visual Studio, Rider or VS Code.

## Contributing / suggestions

Suggestions and new pattern implementations are welcome through an issue or a pull request.
Please keep the layout `<Group>/C-Sharp/<PatternName>/` with one console project per pattern.
