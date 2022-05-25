// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно palindrome.


//int [] array= new int [5];
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
        else if (number_.ToString().Length == 5)
        {
            return number_;
        }

        else
        {
            Console.WriteLine("Введено не пятизначное число");

        }
    }
}


void Palindrome(int number)

{

    int[] array = new int[number];

    if (array[0] == array[4] & array[1] == array[3]) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");

}


int result = GetNumber("Введите пятизначное число");
Palindrome(result);



