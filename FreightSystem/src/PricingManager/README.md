# 📦 CargoNerds Pricing Engine

## Overview
This is the core business logic component of the CargoNerds Freight System.
It calculates shipping prices based on container weight and type.

## Features
- **Object-Oriented Design:** Uses a `Container` class to encapsulate data and behavior.
- **Dynamic Pricing:** 
  - Standard containers have tiered pricing based on weight.
  - Dangerous goods are automatically rejected.
- **Command Line Interface:** Interactive loop for processing multiple containers.

## Usage
Run the application using the .NET CLI:
```bash
dotnet run
```

## Data Structure
The system uses the following `Container` class structure:
```csharp
class Container
{
    public int Weight;    // In Kilograms
    public string Type;   // "Standard" or "Dangerous"
    
    public int CalculatePrice() { ... }
}
```

## Version History
- **v2.2:** Encapsulatd logic into `Container` class (Tag 8).
- **v2.1:** Refactor of Main method.
- **v1.0:** Basic script.
