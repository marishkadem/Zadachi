Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b){
    System.Console.WriteLine($"Максимальным числом является  {a}"); 
    System.Console.WriteLine($"Минимальным числом является  {b}");
      
}
else{
    System.Console.WriteLine($"Максимальным числом является  {b}"); 
    System.Console.WriteLine($"Минимальным числом является  {a}");
      
}
