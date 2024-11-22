
int[] n1Mas = { 0, 12, 333333 };
string[] operationMas = { "-", "/", "*" ,"+"};
int[] n2Mas = { -23, 777, 666 };

Console.WriteLine("Введите число=");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите действие=");
string c = Console.ReadLine();
Console.WriteLine("Введите второе число=");
int b = Convert.ToInt32(Console.ReadLine());
bool func(string c, int a, int b) 
{ 
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
   return true;
}
 func(c, a, b); 

for(int i = 0; i < n1Mas.Length; i++)
{
    func(operationMas[i], n1Mas[i], n2Mas[i]);
}