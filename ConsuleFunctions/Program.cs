using System;

namespace ConsuleFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintMyName(GetName());
            //PrintHello(); //1
            //PrintName(); //2
            //PrintNameParam("Marcos"); //3
            //PrintNumber(15); //4
            //PrintUserNum(); //5
            //PrintHiOrBye(); //6
            //PrintNumFiveTimes(int.Parse(Console.ReadLine())); //7
            //PrintAsNumLength(int.Parse(Console.ReadLine())); //8
            //PrintNameAndNum(int.Parse(Console.ReadLine()), Console.ReadLine()); //9
            //int num1 = 2;
            //int num2 = 5;
            //int num3 = 6;
            //int num4 = 8;
            //Console.WriteLine(GetAvg(num1, num2, num3, num4)); //10
            //Console.WriteLine(GetSum(num1, num2, num3, num4)); //10
            //int width = 10;
            //int height = 5;
            //GetMulty(width, height); //11
            //Switch(2.2, 20.1); //12
            //GetMulty(); //13
            //PrintResult(); //14
            //Console.WriteLine(GetPlusOne()); //15
            //Triple(); //16
            //Console.WriteLine(GetArea(4)); //17
            //print100(); //18
            //print50(); //19
            //print50By3(); //20
            //GetSumAndAvg(); //21
            GetMaxAndMin(); //22
        }


        //static void PrintMyName(string someName)
        //{
        //    Console.WriteLine(someName);
        //}
        //static string GetName()
        //{
        //    Console.WriteLine("enter a name");
        //    string nameInput = Console.ReadLine();
        //    return nameInput;
        //}


        //*_1_*
        //static void PrintHello()
        //{
        //    Console.WriteLine("Hello there");
        //}


        //*_2_*
        //static void PrintName()
        //{
        //    Console.WriteLine("Marcos");
        //}


        //*_3_*
        //static void PrintNameParam(string name)
        //{
        //    Console.WriteLine(name);
        //}


        //*_4_*
        //static void PrintNumber(int number)
        //{
        //    Console.WriteLine(number);
        //}


        //*_5_*
        //static void PrintUserNum()
        //{
        //    int userNum = int.Parse(Console.ReadLine());
        //    Console.WriteLine(userNum);
        //}


        //*_6_*
        //static void PrintHiOrBye()
        //{
        //    int userNum = int.Parse(Console.ReadLine());
        //    if (userNum > 25)
        //    {
        //        Console.WriteLine("Hi");
        //    }
        //    else
        //    {
        //        Console.WriteLine("BYE");
        //    }
        //}


        //*_7_*
        //static void PrintNumFiveTimes(int num)
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine(num);
        //    }
        //}


        //*_8_*
        //static void PrintAsNumLength(int num)
        //{
        //    for (int i = 0; i < num; i++)
        //    {
        //        Console.WriteLine(num);
        //    }
        //}


        //*_9_*
        //static void PrintNameAndNum(int num, string name)
        //{
        //    for (int i = 0; i < num; i++)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}


        //*_10_*
        //static float GetAvg(float num1, float num2, float num3, float num4)
        //{
        //    float avg = (num1 + num2 + num3 + num4) / 4;
        //    return avg;
        //}
        //static int GetSum(int num1, int num2, int num3, int num4)
        //{
        //    int sum = num1 + num2 + num3 + num4; 
        //    return sum;
        //}


        //*_11_*
        //static void GetMulty(int num1, int num2)
        //{
        //    Console.WriteLine(num1 * num2);
        //}


        //*_12_*
        //static void Switch(double num1, double num2)
        //{
        //    Console.WriteLine(num1);
        //    Console.WriteLine(num2);

        //    double temp = num1;
        //    num1 = num2;
        //    num2 = temp;

        //    Console.WriteLine(num1);
        //    Console.WriteLine(num2);
        //}


        //*_13_*
        //static void GetMulty()
        //{
        //    Console.WriteLine("enter 3 numbers");
        //    int i = 0;
        //    int mul = 1;

        //    while (i < 3)
        //    {
        //        int userNum = int.Parse(Console.ReadLine());
        //        mul *= userNum;
        //        i++;
        //    }
        //    Console.WriteLine(mul);
        //}


        //*_14_*
        //static void PrintResult()
        //{
        //    Console.WriteLine("enter 2 numbers");
        //    double first = double.Parse(Console.ReadLine());
        //    double second = double.Parse(Console.ReadLine());
        //    double result = first / second;
        //    Console.WriteLine(result);
        //}


        //*_15_*
        //static double GetPlusOne()
        //{
        //    double userNum = double.Parse(Console.ReadLine());
        //    userNum++;
        //    return userNum;
        //}


        //*_16_*
        //static void Triple()
        //{
        //    double userNum = double.Parse(Console.ReadLine());
        //    userNum *= 3;
        //    Console.WriteLine(userNum);
        //}


        //*_17_*
        //static string GetArea(double radius)
        //{
        //    double area = (radius * radius) * 3.14;
        //    double round = radius * 2 * 3.14;
        //    return $"area is: {area}, round is: {round}";
        //}


        //*_18_*
        //static void print100()
        //{
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        //*_19_*
        //static void print50()
        //{
        //    for (int i = 0; i <= 50; i+=2)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        //*_20_*
        //static void print50By3()
        //{
        //    for (int i = 1; i <= 50; i+=3)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        //*_21_*
        //static void GetSumAndAvg()
        //{
        //    int i = 0;
        //    int sum = 0;
        //    while (i < 5)
        //    {
        //        sum += int.Parse(Console.ReadLine());
        //        i++;
        //    }
        //    int avg = sum / 5;
        //    Console.WriteLine($"sum is: {sum}, avg is: {avg}");
        //}


        //*_22_*
        static void GetMaxAndMin()
        {
            Console.WriteLine("Enter 5 numbers");
            int i = 0;
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            while (i < 5)
            {
                int userNum = int.Parse(Console.ReadLine());
                maxNumber = Math.Max(maxNumber, userNum);
                minNumber = Math.Min(minNumber, userNum);
                i++;
            }
            Console.WriteLine($"maxNumber is: {maxNumber},minNumber is: {minNumber}");
        }

    }
}