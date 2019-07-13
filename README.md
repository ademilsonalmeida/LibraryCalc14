# LibraryCalc14
Biblioteca de operações matemáticas

[![Build status](https://ci.appveyor.com/api/projects/status/kr3nm0ko23j48kp1/branch/master?svg=true)](https://ci.appveyor.com/project/ademilsonalmeida/librarycalc14/branch/master)

## How to install
Install-Package LibraryCalc14 -Version 1.0.3

## How to use
```cs
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();

            var soma = calculadora.Somar(5, 6);

            Console.WriteLine($"O valor da soma: {soma}");

            var soma3 = calculadora.Somar(5, 5, 5);

            Console.WriteLine($"O valor da soma: {soma3}");
        }
    }
}
```
