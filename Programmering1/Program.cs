﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


/*Datatyper, int, double, string, char, bool, decimal, float, long, short, byte, uint, ulong, ushort, sbyte
int = heltal  
Float = decimaltal
string = text
bool = sandt eller falskt
*/

/*
int x;
x = 5;

int y = 10, z = 15;

Console.WriteLine("x is "+x);
Console.WriteLine("y is "+y);
Console.WriteLine("z is "+z);

float d = 12.5f;

Console.WriteLine(d + x - z / y);

int a = Convert.ToInt16;

Console.WriteLine("Float to intet "+ a);


string str = "I am a string" + "and I am a string too";

Console.WriteLine(str);


bool erDetTirsdag = false;
bool erDetOnsdag = true;

Console.WriteLine("Er det tirsdag? " + erDetTirsdag);
*/
////_______________________________
/*Logics
if statement -->


int x = 5;

if (x == 4){
    Console.WriteLine("x is five");   
} else if (x == 1) {
    Console.WriteLine("x is one");
} else if (x == 2) {
    Console.WriteLine("x is two");
 } else {
    Console.WriteLine("x is not one, two or four");
}


string? input = Console.ReadLine();
Console.WriteLine("This is the input: " + input);


Console.WriteLine("What do you want to multiply 2 with?");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("2 * " + number + " = " + (2 * number));
*/

////_______________________________
// 104 Exercises (1-8)

// 1
// Console.WriteLine("Hello: " + "John Schmidt");

// 2
// Console.WriteLine(5+5);

// 3
// Console.WriteLine(5/5);

/* 4
Console.WriteLine(-1 + 4 * 6);
Console.WriteLine((35 + 5) % 7);    
Console.WriteLine(14 + -4 * 6 / 11);
Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);  


// 5 (failed)
 
int number1, number2, temp;
Console.WriteLine("Input first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number: ");
int number2 = int.Parse(Console.ReadLine());

temp = number1;
number1 = number2;
number2 = temp;


Console.WriteLine("After swapping: ");
Console.WriteLine("First number: " + number1);
Console.WriteLine("Second number: " + number2);

// 5 (succes)
using System;

class Program
{
    static void Main()
    {
        int number1, number2, temp;
        
        Console.WriteLine("Input first number: ");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Input second number: ");
        number2 = int.Parse(Console.ReadLine());

        temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine("After swapping: ");
        Console.WriteLine("First number: " + number1);
        Console.WriteLine("Second number: " + number2);

        Console.Read();
    }
}


// 6
int x = 2, y = 3, z = 6; 
Console.WriteLine(x * y * z);


// 7
int number1, number2;
        
        Console.WriteLine("Input first number: ");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Input second number: ");
        number2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine(number1 + "+" + number2 + "=" + (number1 + number2));
        Console.WriteLine(number1 + "-" + number2 + "=" + (number1 - number2));
        Console.WriteLine(number1 + "*" + number2 + "=" + (number1 * number2));
        Console.WriteLine(number1 + "/" + number2 + "=" + (number1 / number2));
        Console.WriteLine(number1 + "%" + number2 + "=" + (number1 % number2));
*/

// 8

