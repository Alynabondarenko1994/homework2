/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
*/


int GetNumber(string str)
{

    while (true)
    {
        Console.WriteLine(str);
        string? number = Console.ReadLine();

        if (int.TryParse(number, out int number_) == false)
        {
            Console.WriteLine("Введено не  число");

        }
        else 
        {
            return number_;
        }

    }
}


void tableCubs(int number)

{
   string result="1";
    int[] array = new int[number];

for (int i=1; i<number;i++)
{
    array[i]=Convert.ToInt32(Math.Pow((i+1),3));
    result=result+", "+array[i];
   
}
 Console.Write("Таблица кубов от 1 до "+number+": "+ result);
}


int resault = GetNumber("Введите  число");
tableCubs(resault);