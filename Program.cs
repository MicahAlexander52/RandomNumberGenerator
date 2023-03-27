int number;
Console.WriteLine("Random Number Generator!");
Console.WriteLine("Press any key to continue >>>>>");
Console.ReadKey();
Random random = new Random();
number = random.Next(0, 100);
Console.WriteLine("Random Number: " + number);
Console.ReadLine(); 