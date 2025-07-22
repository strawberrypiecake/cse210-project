using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numList = new List<int>();
        int numInput = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(numInput != 0)
        {
            Console.Write("Enter number: ");
            string inputUser = Console.ReadLine();
            numInput = int.Parse(inputUser);

            if(numInput != 0)
            {

                numList.Add(numInput);

            } 

        }

        int totalSum = 0;

        foreach (int listItem in numList)
        {
        
            totalSum += listItem;

        }

        Console.WriteLine($"The sum is: {totalSum}");
        
        float listAverage = ((float)totalSum) / numList.Count;

        Console.WriteLine($"The average is: {listAverage}");

        int numMax = numList[0];

        foreach(int listItem in numList)
        {

            if(listItem > numMax)
            {

                numMax = listItem;

            }

        }

        Console.WriteLine($"The largest number is: {numMax}");
        
    }
}
