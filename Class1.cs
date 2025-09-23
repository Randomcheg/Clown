using System;

public class Class1
{
	public Class1()
	{
        {
            Console.Write("Введите натуральное число n:");
            int n = int.Parse(Console.ReadLine());
            for (int x = 201; ; x++)
            {
                if (x % n == 0)
                {
                    Console.WriteLine(x);
                    Console.ReadLine();
                }
            }
        }
    }
}
}

