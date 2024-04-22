using System;

class Test
{

    static void Main(string[] args)
    {
        /*
        Console.Write("I am Shohan.");
        Console.WriteLine("I am 20 years old");
        Console.WriteLine("Wow! nice");
        */

        /*
        int myNum = 5;
        long myLongNum=-5984;
        float myFloatNum=.332F;
        double myDoubleNum = 5.99D;
        char myLetter = 'D';
        bool myBool = true;
        string myText = "Hello";

        Console.WriteLine(myNum);
        Console.WriteLine(myLongNum);
        Console.WriteLine(myFloatNum);
        Console.WriteLine(myDoubleNum);
        Console.WriteLine(myLetter);
        Console.WriteLine(myBool);
        Console.WriteLine(myText);
        */

          
        /*
        int num1, num2;
        double result;
        num1 = 10;
        num2 = 3;

        result = (double)num1 / num2;
        Console.WriteLine(result);
        Console.WriteLine(result.ToString("F3"));
        */
        
        /*
        string name = "Sajib";
        int age = 25;

        Console.WriteLine($"I am {name}. My age is {age}.");
        Console.WriteLine("I am {0}. My age is {1}.",name,age);
        */

        string name;
        int age;
        name = Console.ReadLine();
        Console.WriteLine(name);

        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(age);



    }


}

