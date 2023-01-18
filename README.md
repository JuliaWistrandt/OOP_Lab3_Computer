# Computer #Class Composition

Composition involves using other classes to build more complex classes and there is no parent/child relationship exists in this case. 
Basically, complex objects are composed of other objects. Composition represents a has-a relationship. For example, consider the computer as an object.
Computer has-a motherboard, keyboard, speaker, etc. Composed objects also can be composed of other objects. 
For example, motherboard has-a RAM, HDD, etc. Like Inheritance, composition is a mechanism for reuse. 
In this case, you could remove some parts like HDD and RAM and install them in other computers.

OOP lab class Computer + few separated classes that eventually can produce different types of HDD and RAM.

creating a relationship between two classes that one or greater than one nested objects are a part of the related class, 
and the logical existence of class becomes impossible without the nested objects.
