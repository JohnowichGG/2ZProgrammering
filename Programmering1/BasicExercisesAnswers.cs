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


// 8

int number1 = 5;

Console.WriteLine(number1 + "*" + "0" + "=" + (number1 * 0));
Console.WriteLine(number1 + "*" + "1" + "=" + (number1 * 1));
Console.WriteLine(number1 + "*" + "2" + "=" + (number1 * 2));
Console.WriteLine(number1 + "*" + "3" + "=" + (number1 * 3));
Console.WriteLine(number1 + "*" + "4" + "=" + (number1 * 4));
Console.WriteLine(number1 + "*" + "5" + "=" + (number1 * 5));
Console.WriteLine(number1 + "*" + "6" + "=" + (number1 * 6));
Console.WriteLine(number1 + "*" + "7" + "=" + (number1 * 7));
Console.WriteLine(number1 + "*" + "8" + "=" + (number1 * 8));
Console.WriteLine(number1 + "*" + "9" + "=" + (number1 * 9));
Console.WriteLine(number1 + "*" + "10" + "=" + (number1 * 10));
*/

// 9

int number1, number2, number3, number4;

number1 = 10;
number2 = 15;
number3 = 20;
number4 = 30;

Console.WriteLine((number1 + number2 + number3 + number4)/4);