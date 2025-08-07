# Second C# Assignment

## ✅ Task 1
## 📌 Description
### This program is part of DCIT 318 Assignment 2 and demonstrates Inheritance and Method Overriding in C#.

A **base class** called Animal is created with a method MakeSound().

**Two child classes**, Dog and Cat, inherit from Animal and override the MakeSound() method.

In the Main() method, we create objects of each class and call their sound methods.

## 🧠 Concepts Used

**Class:** A blueprint for creating objects (e.g. Animal, Dog, Cat)

**Object:** A real "thing" created from a class

**Inheritance:** One class (child) inherits properties and methods from another (parent)

**Method Overriding:** The child class replaces the parent’s method with its own version


## ✅ Task 2: Abstraction using Abstract Classes
## 📌 Description
### This program demonstrates Abstraction using abstract classes and methods in C#.

An **abstract class** Shape is created with a method GetArea().

Two classes, Circle and Rectangle, **inherit** from Shape and provide their own versions of **GetArea()** to calculate area based on shape type.

In the Main() method, we create objects for Circle and Rectangle and display their areas.

## 🧠 Concepts Used
**Abstract Class:**	A class that cannot be used on its own, only inherited

**Abstract Method:** A method with no body; child classes must complete it

**Inheritance:** Child classes (Circle, Rectangle) use the abstract parent class Shape

**Polymorphism:** The same method GetArea() behaves differently in each shape


## ✅ Task 3: Interfaces in C#
## 📌 Description
### This program demonstrates how Interfaces work in C# by creating a common behavior (Move()) for different types of transport.

An interface *IMovable* is created* with a method *Move().*

*Two classes* Car and Bicycle implement the interface and provide their own messages.

The *Main()* method creates and uses both objects.

## 🧠 Concepts Used

**Interface:** A contract that defines what methods a class must implement

**Implementation:** Classes agree to follow the interface and provide their own version of the method

**Polymorphism:** Different classes behave differently when calling the same method