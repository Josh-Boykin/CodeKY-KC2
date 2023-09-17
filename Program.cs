using System;
using System.Collections.Generic;

namespace Grocery_Store;

public class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Produce>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var Produce = new Produce();

            Console.WriteLine("Name of the Produce ");
            Produce.Name = Console.ReadLine();
            Console.WriteLine("How much does it cost?");
            Produce.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Description of the Produce?");
            Produce.Description = Console.ReadLine();

            recordList.Add(Produce);

        }
        // Print out the list of records using Console.WriteLine()
        foreach (var record in recordList)
        {
            Console.WriteLine(record.ToString());
        }
       
    }
}      
