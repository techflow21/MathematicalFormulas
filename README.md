## About MathematicalFormulas Package
MathematicalFormulas is a Nugget package that helps .Net Developers to carry out complex mathematical calculations within their projects by simply utilizing mathematical formulas/methods such as Simple Interest, Compound Interest, Volume of Trapezium, Volume of Cuboid, Volume of a Cone etc. 

## Authors
👤 Bello Soliu

## Package Version
version 1.0.0

## Target Languages: 
C#, F# and Visual Basic

## Getting Started
To install our package using the .NET CLI, run the following code:
```sh
dotnet add package MathematicalFormulas --version 1.0.0
```

Installation using Visual Studio
- Right-click on Project dependencies
- Select Nuget Packages Manager
- Then click on Browse to search for MathematicalFormulas
- Then finally click on install.

## Prerequisites
An Basic understanding of C#, NuGet Packages and Visual Studio.

## Usage
After Installation, to use the package, simply call the name of the package and then call the class Formulas and dot to access the formula methods as shown below:

```sh
using MathematicalFormulas;
namespace TestingPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
	  double result = Formulas.SimpleInterest(3500, 2.5, 2);
          //some code here...
        }
    }
}
```
- To use some mathematical formulas within the package, for example, to calculate Simple Interest,
pass the variables values such as Principal Amount, Rate and Time with values of 2800, 2.3 and 2 respectively.
For easy identification of variables to pass, hover on the method called on visual studio to get the variable names and data type.
Check the code below:

```sh
using MathematicalFormulas;
namespace TestingPackage
{
    internal class Program
    {
        static void Main(string[] args)
        {
	   Console.WriteLine("Calculating Simple Interest");
	   
	   double result = Formulas.SimpleInterest(2800, 2.3, 2);
	   
	   Console.WriteLine($"Simple Interest Result is: {result}");
	   
        }
    }
}
```

🤝 Contributing
Contributions, issues, and more feature requests are welcome.Get in touch.

## Github Link:
- [Click here](https://github.com/techflow21/MathematicalFormulas)

## Contact:
LinkedIn - [Click here](https://linkedin.com/in/sobtech/)
