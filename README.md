# Temperature Conversion Projects

This repository contains three main projects that demonstrate temperature conversion using C# and reflection. Each project is designed to showcase different aspects of .NET assembly usage, reflection, and temperature conversion.

## Table of Contents
- [Overview](#overview)
- [Projects](#projects)
  - [Task 2: TemperatureConvertorApp](#task-2-temperatureconvertorapp)
  - [Task 3: TemperatureReflection](#task-3-temperaturereflection)
  - [Task 5: ReflectorApp](#task-5-reflectorapp)
- [How to Run](#how-to-run)
- [Requirements](#requirements)
- [License](#license)

## Overview

This repository consists of three projects:
1. **TemperatureConvertorApp**: A library for temperature conversion.
2. **TemperatureReflection**: A console application that utilizes reflection to access the `TemperatureConvertorApp` library for temperature conversions.
3. **ReflectorApp**: A reflector application that provides detailed information about assemblies and the types they contain.

## Projects

### Task 2: TemperatureConvertorApp

`TemperatureConvertorApp` is a custom library that implements a temperature converter. This library contains classes that perform temperature conversions between Celsius and Fahrenheit.

#### Features:
- Provides methods to convert temperatures from Celsius to Fahrenheit and vice versa.
- Structured similarly to the example `CarLibrary` from the lesson.
- Contains the following key classes:
  - `CelsiusToFahrenheitConverter`: Converts Celsius to Fahrenheit.
  - `FahrenheitToCelsiusConverter`: Converts Fahrenheit to Celsius.
  - `TemperatureConverter`: A base class for temperature conversion logic.

### Task 3: TemperatureReflection

`TemperatureReflection` is a console application that uses reflection to access the `TemperatureConvertorApp` library. This application provides users with the ability to convert temperature values dynamically.

#### Features:
- Loads the `TemperatureConvertorApp` assembly dynamically using reflection.
- Uses reflection to instantiate converter classes and invoke conversion methods.
- Example conversions:
  - Converts 25°C to Fahrenheit.
  - Converts 77°F to Celsius.

### Task 5: ReflectorApp

`ReflectorApp` is a program that acts as a reflector, allowing users to explore the contents of an assembly. This application can provide detailed information about the types, methods, properties, and constructors present in a given assembly.

#### Features:
- Allows users to input the path to any `.dll` assembly.
- Displays information about the assembly's types, including:
  - Properties
  - Methods
  - Fields
  - Constructors
- Provides a detailed view of the structure of the assembly.

## How to Run

1. **Clone the Repository**:
   ```bash
   git clone <repository-url>
   cd TemperatureConversionProjects
   ```

2. ** Compile the Projects

- Use your IDE (e.g., Visual Studio, Rider) to open the solution file and compile all projects.
- Make sure each project compiles without errors.

3. ** Running the Applications

- **TemperatureConvertorApp**: This is a library project and does not run independently. It should be referenced by other applications.
- **TemperatureReflection**: Run this project to perform temperature conversions using reflection.
- **ReflectorApp**: Run this project to explore the contents of an assembly.

## Using the ReflectorApp

- When prompted, enter the path to the `.dll` file you want to explore (e.g., the `TemperatureConvertorApp.dll`).

## Requirements

- .NET SDK (version 6.0 or later)
- IDE (Visual Studio, Rider, or any compatible C# IDE)
