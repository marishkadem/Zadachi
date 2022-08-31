System.Console.Write("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 3 число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max){
    max = b;
}
if (c > max){
    max = c;
}
System.Console.WriteLine(max);