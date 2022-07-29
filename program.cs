Задача 1
{ 
int a, b;
Consolw.WriteLine('Введите два числа :');
a=5;
b=7;
if (a<b)
{
    Console.WriteLiane("{7} наибольшее число, b");
}
ConsoleRedline()
}
Задача 2
namespace C#
{
static void Main(string[] args)
        {
            string[] i = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(i[0]);
            int b = Convert.ToInt32(i[1]);
            int c = Convert.ToInt32(i[2]);
            Console.WriteLine(Math.Max(a, Math.Max(b, c)));
        }
    }
Задача 3
static void Main()
        {
                Console.WriteLine("Введите число : ");
                int a = Convert.ToInt32(Console.Read());
                if (a % 2 == 0) Console.WriteLine("Четное");
                else Console.WriteLine("Нечетное");
                Console.ReadKey();
        }
        Задача 4
        class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write number 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    }
}