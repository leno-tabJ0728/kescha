//Console.WriteLine("Hello, World!");
System.Console.Write("Enter you name:");
string name=Convert.ToString(Console.ReadLine());
System.Console.WriteLine($"Hello, {name}");
System.Console.Write($"{name} tug'ulgan yilingizni kiriting:");
int yosh=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{name} sizning yoshingiz {2022-yosh} da");

System.Console.Write("Ismingizni kiriting:");
string ism=Convert.ToString(Console.ReadLine());
System.Console.WriteLine($"Salom {ism}");
System.Console.Write($"{ism} tug'ulgan yilingizni kiriting:");
int yil=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{ism} sizning yoshingiz {2022-yil} da");

System.Console.WriteLine($"{ism} {name} dan {yosh-yil} yoshga katta");