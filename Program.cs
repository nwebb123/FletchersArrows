﻿Console.WriteLine("*****  Vin Fletcher's Arrows  *****\n");

// Define a new Arrow class with fields for arrowhead type, fletching type, and length.
// Allow user to pick the arrowhead, fletching type, and length and then create a new Arrow instance.
// 

Console.WriteLine("Available arrowhead types: wood(3g), obsidian(5g), or steel(10g).\n");
Console.Write("Enter an available type of arrowhead: ");
string arrowheadInput = Console.ReadLine();

Console.WriteLine("\nArrow shafts can be no less than 60cm and no more than 100cm long (.05g/per cm)\n");
Console.Write("Enter a length in cm for the shaft of the arrow: ");
int shaftLengthInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nAvailable fletching types: plastic, turkey feathers, or goose feathers.\n");
Console.Write("Enter an available type of fletching: ");
string fletchingInput = Console.ReadLine();

Console.WriteLine();
Console.WriteLine(arrowheadInput);
Console.WriteLine(shaftLengthInput);
Console.WriteLine(fletchingInput);

Console.ReadKey();
