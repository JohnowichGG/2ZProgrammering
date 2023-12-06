// See https://aka.ms/new-console-template for more information
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
*/

Console.WriteLine("What do you want to multiply 2 with?");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("2 * " + number + " = " + (2 * number));