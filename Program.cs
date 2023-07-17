using Pet_Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");

//Get User Input for Console
string userInput = Console.ReadLine();

//While Loop
while (userInput.ToLower() != "exit") //While the user has not typed "exit" the program will run!
{
    if (userInput == "1")
    {
        DogLeash dogLeash = new DogLeash();

        //Product Info

        Console.WriteLine("Item name: ");
        dogLeash.Name = Console.ReadLine();

        Console.WriteLine("Price: ");
        dogLeash.Price = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantity: ");
        dogLeash.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("Description: ");
        dogLeash.Description = Console.ReadLine();
        
        //Dog Leash Info
        Console.WriteLine("Leash Length in inches: ");
        dogLeash.LengthInches = int.Parse(Console.ReadLine());

        Console.WriteLine("Material type: ");
        dogLeash.Material = (Console.ReadLine());

        

        Console.WriteLine(JsonSerializer.Serialize(dogLeash));
    }
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}