Definition
Create an object without exposing the instantiation logic to the client.

Concept
In object-oriented programming, a factory is such an object that can create other objects.
A factory can be invoked in many different ways but most often, it uses a method that
can return objects with varying prototypes. Any subroutine that can help us to create
these new objects, can be considered as a factory. Most importantly, it will help you to
abstract the process of object creation from the consumers of the application.

Real-Life Example
In a South Indian restaurant, when you place an order for your favorite biryani dish,
the waiter may ask whether you like to have your Biryani with more spice or whether it
should be prepared with less spice. Based on your choice, the chef will add spices to the
core material and make the appropriate dish for you.

Computer World Example
The Simple Factory pattern is common to software applications, but before proceeding,
note the following:
• The Simple Factory pattern is not treated as a standard design pattern
in the GoF’s famous book, but the approach is common to any
application you write where you want to separate the code that varies
a lot from the part of code that does not vary. It is assumed that you
follow this approach in all the applications you write.
• The Simple Factory pattern is considered the simplest form of the
Factory Method pattern (and Abstract Factory pattern). So, you can
assume that any application that follows either the Factory Method
pattern or the Abstract Factory pattern originated from the concept of
the Simple Factory pattern’s design goals.