
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

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
else if (number_.ToString().Length==3) 
{
   return number_;
}

else
{
     Console.WriteLine("Введено не трехзначное число");
     
}
}
}

int result(int number1)
{
int number2=number1%100/10;
return number2;
}

int digit=GetNumber("Введите трехзначное число");
int second =result(digit);

Console.WriteLine("Вторая цифра числа: "+second);
