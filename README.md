#dotnet-design-patterns
Abstract Factory Pattern (Creational)

This repository demonstrates the Abstract Factory Pattern implemented in .NET (C#) using clean, readable, and easy-to-understand code.

The Abstract Factory Pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes.
🏗️ Structure Overview

Abstract Products
Interfaces that define common behavior for UI components.

Concrete Products
Platform-specific implementations (Windows / Mac).

Abstract Factory
Defines methods for creating related objects.

Concrete Factories
Implement object creation for a specific family.

Client Code
Uses only interfaces and remains independent of concrete classes.

The pattern usage is executed from Program.cs:
using creational.abstract_factory.ui_component_demo;


#region Abstract Factory Pattern
new AbstractFactoryUIComponentDemo().Run();
#endregion;
