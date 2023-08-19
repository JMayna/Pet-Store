using Pet_Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

var ProductLogic = new ProductLogic();

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Press 2 to view a Dogleash");
Console.WriteLine("Press 3 to view in stock products");
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

        
        ProductLogic.AddProduct(dogLeash);
        Console.WriteLine("Dog Leash has been added");
    }

    else if (userInput == "2")
    {
        Console.WriteLine("Enter the name of Dogleash you would like to get.");
        string dogLeashName = Console.ReadLine();
        DogLeash dogLeash = ProductLogic.GetDogLeashByName(dogLeashName);

        if(dogLeash == null)
        {
            Console.WriteLine("That product could not be found");
        }
        else
        {
            Console.WriteLine(String.Format("Name: {0}\nPrice : {1}\nQuantity: {2}\nDescription: {3}\nMaterial: {4}\nLength(in): {5}",
                dogLeash.Name, dogLeash.Price, dogLeash.Quantity, dogLeash.Description, dogLeash.Material, dogLeash.LengthInches));
        }
    }
    else if (userInput == "3")
    {
        Console.WriteLine("The following products are in stock: ");
        var inStock = ProductLogic.GetOnlyInStockProducts();
        foreach (var item in inStock)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Press 2 to view a Dogleash");
    Console.WriteLine("Press 3 to view in stock products");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
}