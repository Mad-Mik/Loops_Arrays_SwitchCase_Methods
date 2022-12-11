using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ////Циклы(Loops)

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 1, j = 1; i < 10; i++, j++)
            //{
            //    Console.WriteLine($"{i * j}");
            //}


            //foreach (char c in "Tom")
            //{
            //    Console.WriteLine(c);
            //}


            //int i = 6;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);


            //int i = -1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //while (i > 0);


            //int i = 5;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}


            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 5)
            //        break;
            //    Console.WriteLine(i);
            //}


            //for (int i = 0; i < 9; i++)
            //{
            //    if (i == 5)
            //        continue;
            //    Console.WriteLine(i);
            //}


            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i * j} \t");
            //    }
            //    Console.WriteLine();
            //}
            //-------------------------------------------------------------------------------------------------


            ////Массивы(Arrays)

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //// bolor drakan tveri qanaky
            //int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            //int result = 0;
            //foreach (int num in numbers)
            //{
            //    if (num>0)
            //    {
            //        result++;
            //    }
            //}
            //Console.WriteLine(result);


            //// bolor bacasakan tveri qanaky
            //int[] numbers = { -1, -3, -5, 8, 9, 6, 4, -15, 3, -12, -35 };
            //int result = 0;
            //foreach (int num in numbers)
            //{
            //    if (num < 0)
            //    {
            //        result++;
            //    }
            //}
            //Console.WriteLine(result);


            //// dasavoruma min-max
            //int[] nums = { -24, 23, -5, 45, -3, -40, 65 };
            //int temp;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            temp = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}


            //// *2
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = numbers[i] * 2;
            //    Console.WriteLine(numbers[i]);
            //}
            //-------------------------------------------------------------------------------------------------


            ////Конструкция switch

            //string name = "Tom";
            //switch (name)
            //{
            //    case "Bob":
            //        Console.WriteLine("Bob");
            //        break;
            //    case "Tom":
            //        Console.WriteLine("Tom");
            //        break;
            //    case "Albert":
            //        break;
            //    default:
            //        Console.WriteLine("Unknown name");
            //        break;


            //int number = 1;
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine(1);
            //        goto case 4;
            //    case 2:
            //        Console.WriteLine(2);
            //        break;
            //    case 3:
            //        Console.WriteLine("3");
            //        break;
            //    case 4:
            //        Console.WriteLine("4");
            //        break;
            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}
            //-------------------------------------------------------------------------------------------------


            ////Методы

            //void SayHello()
            //{
            //    Console.WriteLine("Hello");
            //}
            //SayHello();


            //void SayHelloRu()
            //{
            //    Console.WriteLine("Privet");
            //}
            //void SayHelloEn()
            //{
            //    Console.WriteLine("Hello");
            //}
            //void SayHelloFr()
            //{
            //    Console.WriteLine("Salut");
            //}

            //string language = "ru";
            //switch (language)
            //{
            //    case "en":
            //        SayHelloEn();
            //        break;
            //    case "ru":
            //        SayHelloRu();
            //        break;
            //    case "fr":
            //        SayHelloFr();
            //        break;
            //    default:
            //        break;
            //}
            //-------------------------------------------------------------------------------------------------


            ////Параметры методов

            //void PrintMessage(string message)
            //{
            //    Console.WriteLine(message);
            //}

            //PrintMessage("Hello work");
            //PrintMessage("Hello Bro");
            //PrintMessage("Hello C#");


            //void Sum(int x, int y)
            //{
            //    int result = x + y;
            //    Console.WriteLine($"{x} + {y} = {result}");
            //}
            //Sum(10, 15);


            //void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = { x + y }");
            //Sum(10, 15);


            //void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = { x + y }");
            //int a = 10, b = 15, c = 6;
            //Sum(a, b);
            //Sum(3, c);
            //Sum(14, 4 + c);


            //void Sum(int x, int y)
            //{
            //    Console.WriteLine($"{x} + {y} = { x + y }");
            //}

            //int a = 30;
            //int b = 15;
            //Sum(a, b);


            //void PrintPerson(string name, int age)
            //{
            //    Console.WriteLine($"Name: {name}  Age: {age}");
            //}

            //PrintPerson("Tom", 24);


            //void PrintPerson(string name, int age = 1, string company = "Undefined")
            //{
            //    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
            //}

            //PrintPerson("Tom", 37, "Microsoft");  
            //PrintPerson("Tom", 37);               
            //PrintPerson("Tom");


            //void PrintPerson(string name, int age = 1, string company = "Undefined")
            //{
            //    Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
            //}

            //PrintPerson("Tom", company: "Microsoft", age: 37);
            //PrintPerson(age: 41, name: "Bob");
            //PrintPerson(company: "Google", name: "Sam");
            //-------------------------------------------------------------------------------------------------



        }
    }
}
