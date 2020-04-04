
using System;
using System.Collections.Generic;

public class ReverseInteger
{
    public void Run()
    {
        int input = -123;
        int output = Reverse(input);        
        Console.WriteLine(output);
    }

    private int Reverse(int input)
    {
        bool isNegative = input < 0;
        input = isNegative ? input * -1 : input;

        Console.WriteLine( input % (int)(Math.Floor(Math.Log10(input))));

        // Stack<int> holder = new Stack<int>();

        // while(input < 0)
        // {
        //     input = input % (int)(Math.Floor(Math.Log10(input)));
        // }

        return 1;

    }


}