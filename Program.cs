using Pet_Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

//HomeWork 2: Step 7
var productLogic = new ProductLogic();


Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Press 2 to view a DogLeash");
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


        //HomeWork 2: Step 8
        productLogic.AddProduct(dogLeash);
        //HomeWork 2: Step 9
        Console.WriteLine("The Product was added.");
    }

     if (userInput == "2")
    {
        Console.WriteLine("Enter the name of the Dog Leash you would like to get.");
        string dogLeashName = Console.ReadLine();
        DogLeash dogleash = productLogic.GetDogLeashByName(dogLeashName);
        if(dogleash is null)
        {
              Console.Write("That product could not be found");
        }

        else
        {
           Console.WriteLine(String.Format("Name: {0}\nPrice: {1}\nQuantity: {2}\nDescription: {3}\nMaterial: {4}\nLength(in): {5}",
                dogleash.Name, dogleash.Price, dogleash.Quantity, dogleash.Description, dogleash.Material, dogleash.LengthInches));
        }
        
    }
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Press 2 to view  a DogLeash");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}