// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Enter your name");
//string name = Console.ReadLine();
//Console.WriteLine($"Hello, {name}");
//bool flag1 = true;
//bool flag2 = false;
//byte bit1 = 45;
//sbyte sbit = -34;
//int a = 345600;
//long b = 453672478;
//string text = "Hello";

//string name = "Johny";
//int age = 23;
//bool isEmployed = true;
//double weight = 73.23;
//Console.WriteLine($"Name: {name}");
//Console.WriteLine($"Age: {age}");
//Console.WriteLine($"Employee: {isEmployed}");
//Console.WriteLine($"Weight: {weight}");

//float a = 3.14f;
//float b = 3.5364F;
//decimal d = 3.4343m;
//uint c = 43u;
//long e = 324563l;
//ulong f = 243526ul;

//var hello = "Hello";
//var c = 2345;
//Console.WriteLine(hello.GetType().ToString());
//Console.WriteLine(c.GetType().ToString());

//int x = 3;
//int s = x + 34;
//s = x - 2;
//s = x * 45;
//s = x / 4;
//Console.WriteLine(10.0/4.0);
//double y = 10.0;
//double z = y % 3.0;
//Console.WriteLine(z);
//int d = 5;
//int d1 = d++;
//Console.WriteLine($"{d} - {d1}");
//int d2 = ++d;
//Console.WriteLine($"{d} - {d2}");

//int a = 4;
//int b = 2;
//int c = 5;
//int d = c - (--b) * a;
//Console.WriteLine(d);

////a^4
//int r;
//int a = Convert.ToInt32(Console.ReadLine());
//r = a * a; //a^2
//r = r * r; //a^4
//Console.WriteLine(r);

//Console.WriteLine(5 == 6);
//Console.WriteLine(5 != 6);
//Console.WriteLine(5 < 6);
//Console.WriteLine(5 > 6);
//Console.WriteLine(5 <= 5);
//Console.WriteLine(7 >= 6);

//bool x = (5 > 6) | (4 > 1); // false or true -> true
//bool y = (4 > 2) & (3 > 0); // true and true -> true
//bool z = (5 > 6) || (4 > 1); // true
//bool q = (5 > 6) && (4 > 1); // false

//bool a = false;
//bool b = !a;
//Console.WriteLine(b);

//bool r = (8 > 6) ^ (4 < 6); // true ^ true -> false

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//if (a > b)
//{
//    Console.WriteLine("First bigger");
//}
//else if (a == b) {
//    Console.WriteLine("same");
//}
//else
//{
//    Console.WriteLine("Second bigger");
//}

//Console.WriteLine("Enter x or y");
//string selection = Console.ReadLine();
//switch (selection)
//{
//    case "x":
//        Console.WriteLine("You press x");
//        break;
//    case "y":
//        Console.WriteLine("You press y");
//        break;
//    default:
//        Console.WriteLine("You press not x or y");
//        break;
//}

//int x = 3;
//int y = 4;
//Console.WriteLine("Enter + or -");
//string selection = Console.ReadLine();
//int z = selection == "+" ? (x + y) : (x - y);
//Console.WriteLine(z);

// ((a & b) | ((!a) & (!b)));
//int x = 5;
//int y = 10;
//Console.WriteLine(y > x * x | y >= 2 * x & x < y);

//bool a = true;
//bool b = false;
//Console.WriteLine((a & b) | ((!a) & (!b)));

//int year = Convert.ToInt32(Console.ReadLine());
//if (((year % 4 == 0) & (year % 100 != 0)) | (year % 400 == 0))
//{
//    Console.WriteLine("Year have 366 days");
//}
//else
//{
//    Console.WriteLine("Year have 365 days");
//}

//string type = Console.ReadLine();
//if (type == "triangle")
//{
//    int a = Convert.ToInt32(Console.ReadLine());
//    int b = Convert.ToInt32(Console.ReadLine());
//    int c = Convert.ToInt32(Console.ReadLine());
//    int p = (a + b + c) / 2;
//    Console.WriteLine(Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5));
//}
//else if (type == "rectangle")
//{
//    int a = Convert.ToInt32(Console.ReadLine());
//    int b = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(a * b);
//}
//else if (type == "circle")
//{
//    int r = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(Math.PI * Math.Pow(r, 2));
//}