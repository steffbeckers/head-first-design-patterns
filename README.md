# Head First Design Patterns book

.NET source code I've created myself while reading the book.
Java source code as used in examples of the book.

## Design Principles

- Identify the aspects of your application that vary and separate them from what stays the same.
- Program to an interface, not an implementation.
- Favor composition over inheritance.
- Strive for loosely coupled designs between objects that interact.
- Open-closed: Classes should be open for extension, but closed for modification. (S**O**LID)
- Dependency Inversion: Depend upon abstractions. Do not depend upon concrete classes. (SOLI**D**)

## Design Patterns

### Strategy

The Strategy Pattern defines a family if algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

### Observer

The Observer Pattern defines a one-to-many dependency between objects so that when one objects changes state, all of its dependents are notified and updated automatically.

### Decorator

The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

### Factory Method

The Factory Method Pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

