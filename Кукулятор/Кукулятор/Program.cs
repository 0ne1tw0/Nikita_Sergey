Console.WriteLine("Введите число=");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите действие=");
string c = Console.ReadLine();
Console.WriteLine("Введите второе число=");
int b = Convert.ToInt32(Console.ReadLine());

switch (c)
{
    case "+":
        Console.WriteLine(a + b);
        break;
    case "-":
        Console.WriteLine(a - b);
        break;
    case "*":
        Console.WriteLine(a * b);
        break;
    case "/":
        Console.WriteLine(a / b);
        break;
}



