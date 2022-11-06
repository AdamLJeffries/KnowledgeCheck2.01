using System;

internal static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberofRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Cat>();
        for (int i = 0; i < numberofRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()

            var myClass = new Cat();
            recordList.Add(myClass);


            Console.WriteLine("Enter the value for number of legs ");
            myClass.Legs = Console.ReadLine();

            Console.WriteLine("Enter the value for number of tails.");
            myClass.Tail = Console.ReadLine();

            Console.WriteLine("Enter the value for the number of heads");
            myClass.Head = Console.ReadLine();


            Console.WriteLine($"Your Cat has  " + myClass.Head + "   head!");
            Console.WriteLine($"Your Cat has  " + myClass.Legs + "   legs!");
            Console.WriteLine($"Your Cat has  " + myClass.Tail + "   tail!");
            Console.WriteLine("An exposed belly is an invitation to pet. 50% chance you are welcomed to experience");
            Console.WriteLine("the feeling of dancing with baby angels in the fluffy clouds of heaven!");
            Console.WriteLine("Equal chance you are not permitted and met with a storm of razor sharp claws and teeth");
            Console.WriteLine("in the fur-ocious depths of cat hell.");
            
            Console.WriteLine("Proceed carefully my friends!");
        }

    }    // Print out the list of records using Console.WriteLine()
    
    public class Animal
    {
        public string Tail { get; set; }
        public string Head { get; set; }    
        public string Legs { get; set; }

        public int legs = 4;
        public int head = 1;
        public int tail = 1;



    }
    public class Cat
    {
        public string Tail { get; set; }
        public string Head { get; set; }
        public string Legs { get; set; }

        public int legs = 4;
        public int head = 1;
        public int tail = 1;


    }

}