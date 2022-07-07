# Assignment 1 & 2

# Assignment 1:

## **Understanding Data Types**

### What type would you choose for the following “numbers”?

- A person’s telephone number ----  String
- A person’s height ----- ushort
- A person’s age ------- int
- A person’s gender (Male, Female, Prefer Not To Answer)  ------ String
- A person’s salary –  Decimal
- A book’s ISBN --- String
- A book’s price  ---- Decimal
- A book’s shipping weight ---- Float
- A country’s population  ---- ulong
- The number of stars in the universe ----  ulong
- The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) –— int

### What are the difference between value type and reference type variables? What is boxing and unboxing?

- **A Value Type** holds the data within its own memory allocation.
- **A Reference Type** contains a pointer to another memory location that holds the real data. Reference Type variables are stored in the heap while Value Type variables are stored in the stack.
- **Boxing** is the process of converting a value type to the type object or to any interface type implemented by this value type.
- **Unboxing** extracts the value type from the object.

[https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)

### What is meant by the terms managed resource and unmanaged resource in .NET?

Managed resources basically mean anything managed by the CLR (example: any of your managed objects). 

Unmanaged resources typically mean native resources that are created and lifetime managed outside the CLR (example GDI handles or say sockets)

### What’s the purpose of Garbage Collector in .NET?

The garbage collector manages the allocation and release of memory for an application, this means that you don't have to write code to perform memory management tasks. 

Automatic memory management can eliminate common problems, such as forgetting to free an object and causing a memory leak or attempting to access memory for an object that's already been freed.

## Controlling Flow and Converting Types

### What happens when you divide an int variable by 0?

Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.

### What happens when you divide a double variable by 0?

∞ infinity

### What happens when you overflow an int variable, that is, set it to a value beyond its range?

Throw an out of range exception

### What is the difference between x = y++; and x = ++y;?

x = y++;   —>  x=y, y= y+1

x = ++y;  —>  y=y+1, x=y.

### What is the difference between break, continue, and return when used inside a loop statement?

**Break** is immediate termination of loop
**Continue** terminate the current iteration and resumes the control to the next iteration of the loop.
**Return** means stop the loop and return the value

### What are the three parts of a for statement and which of them are required?

There are initialization, condition, iteration.

### What is the difference between the = and == operators?

 = : **assign a value to a variable**

== : **check whether 2 expressions give the same value**

### Does the following statement compile? for ( ; true; ) ;

Yes

### What does the underscore _ represent in a switch expression?

The underscore _ character replaces the default keyword to signify that it should match anything if reached.

### What interface must an object implement to be enumerated over by using the foreach statement?

System.Collections.IEnumerable or System.Collections.Generic.IEnumerable<T>

# Assignment2

## 02 Arrays and Strings

### When to use String vs. StringBuilder in C# ?

Strings are immutable and can only be defined once, but StringBuilder allows for mutable strings, so if a string changes, then StringBuilder is recommended.

### What is the base class for all arrays in C#?

Array class

### How do you sort an array in C#?

Array.Sort(array)

### What property of an array object can be used to get the total number of elements in an array?

array.Length

### Can you store multiple data types in System.Array?

No, each array can have one data type.

### What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

The Clone() method returns a new array(object) containing all the elements in the original array. 

The CopyTo() method copies the elements into another array