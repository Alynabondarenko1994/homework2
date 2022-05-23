/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
 
int GetNumber(string str)
{
    
while(true)
{
    Console.WriteLine(str);
    string? number=Console.ReadLine();
   
if (int.TryParse(number, out int number_)==false)
{
  Console.WriteLine("Введено не  число");
    
}
else if(number_>7^number_<=0)
{
   Console.WriteLine("Введите цифру от 1 до 7"); 
}
else
return number_;
}
}

int weekday=GetNumber("Введите цифру дня недели");

 if(weekday==6 ^ weekday==7)
{
    Console.WriteLine ("Введенный день недели является выходным");
}
else 
 Console.WriteLine ("Введенный день недели не является выходным");






   
