
/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

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
else 
return number_;
}
}


int number1=GetNumber("Введите число");

if (number1.ToString().Length>=3)
{
string resault=number1.ToString();
Console.WriteLine("Третья цифра числа: "+resault[2]);
}
else
  Console.WriteLine("Третьей цифры у введенного числа нет"); 