// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double Getcoord(string str)
{
    
    while (true)
    {
         Console.WriteLine(str);
        string? x = Console.ReadLine();

        if (double.TryParse(x, out double num)==false)
        {
          Console.WriteLine("Введено не  число");
           
          
        }
        else
         return num;
}
}


void distance(double x_1, double y_1, double z_1,double x_2, double y_2, double z_2)

{
    double result=Math.Sqrt(Math.Pow((x_2-x_1),2) + Math.Pow((y_2-y_1),2) + Math.Pow((z_2 - z_1),2));
    Console.WriteLine("Расстояние между точками в 3D пространстве равно:"+ Math.Round((result),3));

}


double x1=Getcoord("Введите координату x1:");
double y1=Getcoord("Введите координату y1:");
double z1=Getcoord("Введите координату z1:");
double x2=Getcoord("Введите координату x2:");
double y2=Getcoord("Введите координату y2:");
double z2=Getcoord("Введите координату z2:");
distance(x1,y1,z1,x2,y2,z2);
