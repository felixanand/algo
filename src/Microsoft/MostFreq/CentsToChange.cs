// Convert given cents to changes of various format
using System;
public class CentsToChange
{
    const int DOLLARS = 100;
    const int QUARTERS = 25;
    const int DIMES = 10;
    const int NICKELS = 5;

    public void Run()
    {
        int inputInCents = 92;
        PrintChange(inputInCents);
    }

    private void PrintChange(int inputCents)
    {
        int cntDollar = 0;
        int cntQuarters = 0;
        int cntDimes = 0;
        int cntNickels = 0;
        int balanceCents = 0;

        if (inputCents < 0) throw new InvalidOperationException("Input is not valid");

        cntDollar = inputCents / DOLLARS;
        balanceCents = inputCents % DOLLARS;
        cntQuarters = balanceCents / QUARTERS;
        balanceCents = balanceCents % QUARTERS;
        cntDimes = balanceCents / DIMES;
        balanceCents = balanceCents % DIMES;
        cntNickels = balanceCents / NICKELS;
        balanceCents = balanceCents % NICKELS;

        Console.WriteLine("DOLLARS : " + cntDollar);
        Console.WriteLine("QUARTERS : " + cntQuarters);
        Console.WriteLine("DIMES : " + cntDimes);
        Console.WriteLine("NICKELS : " + cntNickels);
        Console.WriteLine("Balance Left : " + balanceCents);

    }
}