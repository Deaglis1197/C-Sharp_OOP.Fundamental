# Abstraction
Data Abstraction is the property by virtue of which only the essential details are exhibited to the user. The trivial or the non-essentials units aren’t exhibited to the user. 
Data Abstraction may also be defined as the process of identifying only the required characteristics of an object ignoring the irrelevant details. The properties and behaviors of an object differentiate it from other objects of similar type and also help in classifying/grouping the objects.

## Abstract Classes 

- An abstract class is declared with the help of abstract keyword.
- In C#, you are not allowed to create objects of the abstract class. Or in other words, you cannot use the abstract class directly with the new operator.
- Class that contains the abstract keyword with some of its methods(not all abstract method) is known as an Abstract Base Class.
- Class that contains the abstract keyword with all of its methods is known as pure Abstract Base Class.
- You are not allowed to declare the abstract methods outside the abstract class.
- You are not allowed to declare an abstract class as Sealed Class.

## Encapsulation vs Data Abstraction
- Encapsulation is data hiding(information hiding) while Abstraction is detail hiding(implementation hiding).
- While encapsulation groups together data and methods that act upon the data, data abstraction deal with exposing to -the user and hiding the details of implementation.

## Advantages of Abstraction
- It reduces the complexity of viewing things.
- Avoids code duplication and increases reusability.
- Helps to increase the security of an application or program as only important details are provided to the user.
