using System;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be a positive integer.");

        // Calculate the aliquot sum
        int aliquotSum = Enumerable.Range(1, number / 2).Where(i => number % i == 0).Sum();

        // Determine classification based on aliquot sum
        if (aliquotSum == number)
            return Classification.Perfect;
        else if (aliquotSum > number)
            return Classification.Abundant;
        else
            return Classification.Deficient;
    }
}