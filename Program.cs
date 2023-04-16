using FletchersArrows;

//Initialize values



Console.WriteLine("*****  Fletcher NPC  *****\n");

// Define a new Arrow class with fields for arrowhead type, fletching type, and length.                     DONE
// Create a method that calculates a cost for an arrow depending on the combination of materials chosen     DONE
// Allow user to pick the arrowhead, length, and fletching type and then create a new Arrow instance.       DONE
// Display the price of the arrow and ask if they'd like an estimate on a different kind of arrow.          DONE
// 

string userInput = "";
while (userInput != "exit")
{

    // Get Arrowhead type
    Console.WriteLine("\nAvailable arrowhead types: wood(3g), obsidian(5g), or steel(10g).\n");
    Console.Write("Select a type of arrowhead for your arrow: ");
    string arrowheadInput = Console.ReadLine();

    // Get Shaft length
    Console.WriteLine("\nArrow shafts can be no less than 60cm and no more than 100cm long (.05g/per cm)\n");
    Console.Write("Enter a length in cm for the shaft of the arrow: ");
    int shaftLengthInput = Convert.ToInt32(Console.ReadLine());

    // Get Fletching type
    Console.WriteLine("\nAvailable fletching types: goose feathers(3g), turkey feathers(5g), or plastic(10g).\n");
    Console.Write("Select a type of fletching for your arrow: ");
    string fletchingInput = Console.ReadLine();

    Arrow customArrow = new(arrowheadInput, shaftLengthInput, fletchingInput);
    Console.WriteLine($"\nEstimate: {customArrow.CostPerArrow(customArrow)}g/arrow");


    Console.Write($"\nWould you like an estimate on a 'new arrow' or 'exit'? ");
    userInput = Console.ReadLine();
    
    while( userInput != "new arrow" && userInput != "exit")
    {
        Console.Write("\nSorry, do you want an estimate on a 'new arrow' or would you like to 'exit'? ");
        userInput = Console.ReadLine();
    }
    
    //Console.WriteLine($"\nHow many arrows would you like to order?");
    //int amountOfCustomArrows = Convert.ToInt32(Console.ReadLine());
}

// If userInput == exit

Console.WriteLine("\nThanks for shopping!");
Console.ReadKey();
