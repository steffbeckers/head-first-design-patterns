# Head First Design Patterns book

.NET source code I've created myself while reading the book.
Java source code as used in examples of the book.

## OO Design Principles

- Identify the aspects of your application that vary and separate them from what stays the same.
- Program to an interface, not an implementation.
- Favor composition over inheritance.
- Strive for loosely coupled designs between objects that interact.
- Principle of Least Knowledge: talk only to your immediate friends.
- The Hollywood Principle: Don't call us, we'll call you.
- SOLID
  - **S**ingle-Responsibility: A class should have one and only one reason to change, meaning that a class should have only one job.
  - **O**pen-Closed: Classes should be open for extension, but closed for modification.
  - **L**iskov Substitution: Every subclass or derived class should be substitutable for their base or parent class.
  - **I**nterface Segregation: A client should never be forced to implement an interface that it doesn’t use, or clients shouldn’t be forced to depend on methods they do not use.
  - **D**ependency Inversion: Depend upon abstractions. Do not depend upon concrete classes. (SOLI**D**)

## Design Patterns

### Strategy

The Strategy Pattern defines a family if algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

### Observer

The Observer Pattern defines a one-to-many dependency between objects so that when one objects changes state, all of its dependents are notified and updated automatically.

### Decorator

The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

### Factory Method

The Factory Method Pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

Relies on inheritance: object creation is delegated to subclasses, which implement the factory method to create objects.

### Abstract Factory

The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

Relies on object composition: object creation is implemented in methods exposed in the factory interface.

### Singleton

The Singleton Pattern ensures a class has only one instance, and provides a global point of access to it.

### Command

The Command Pattern encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations.

### Adapter

The Adapter Pattern converts the interface of a class into another interface the clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

### Facade

The Facade Pattern provides a unified interface to a set of interfaces in a subsystem. Facade defines a higher level interface that makes the subsystem easier to use.

### Template Method

The Template Method Pattern defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.

