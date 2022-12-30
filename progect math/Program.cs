int tmp = 0;

Console.WriteLine("enter the muber to start counting from :");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter the number to stop counting :");
int num2 = int.Parse(Console.ReadLine());



Console.WriteLine();

for (int i = num1;  i <= num2; i++)
{



    for (int c = 1; c <= i; c++)
    {


        if (i % c == 0)
        {
            tmp++;
        }


       

    }
    if (tmp == 2)
    {
        double perfect = Math.Pow(2, i) - 1;
        double perfect2 = Math.Pow(2, i - 1);
        Console.WriteLine("teh prime number is : {0}", i);

        Console.WriteLine("the perfect number from it is :" + perfect * perfect2);

        tmp = 0;

    }
    else
    {
        tmp = 0;
    }
}





   

