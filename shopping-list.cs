// ShoppingList is a console program that keeps track of a shopping list 
// containing the name and price of each item.
class ShoppingList
{
    static void Main()
    {
        // List containing the names of the items
        List<string> names = [];

        // List containing the prices of the items
        // The same index is used in both lists
        List<int> prices = [];

        // The program continues running until the user exits
        while (true)
        {
            // Print an empty line to make the output clearer
            Console.WriteLine();

            // Print all items in the shopping list
            for (int i = 0; i < names.Count; i++)
            {
                // i + 1 makes the list start at number 1
                // even though the list index starts at 0
                Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
            }

            // Calculate the total cost
            int total = 0;

            for (int i = 0; i < prices.Count; i++)
            {
                total += prices[i];
            }

            // Print the total sum
            Console.WriteLine($"Total: {total} kr");

            // Ask the user to enter an item name or a number
            Console.WriteLine();
            Console.WriteLine("Skapa din handlingslista!");
            Console.WriteLine("Sortera din lista baserat på pris, ange (sortera)");
            Console.WriteLine("Visa dyraste varan, ange (dyrast)");
            Console.Write("Lägg till en vara eller ange ett nummer för att ta bort en vara: ");
            string? input = Console.ReadLine();

            if (input == null)
            {
                break;
            }

            input = input.Trim();

            if (input.Equals("dyrast", StringComparison.OrdinalIgnoreCase))
            {
                if (prices.Count == 0)
                {
                    Console.WriteLine("Listan är tom.");
                }
                else
                {
                    int mostExpensiveIndex = 0;

                    for (int i = 1; i < prices.Count; i++)
                    {
                        if (prices[i] > prices[mostExpensiveIndex])
                        {
                            mostExpensiveIndex = i;
                        }
                    }

                    Console.WriteLine($"Dyrast: {names[mostExpensiveIndex]} - {prices[mostExpensiveIndex]} kr");
                }

                continue;
            }

            if (input.Equals("sortera", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < prices.Count - 1; i++)
                {
                    for (int j = i + 1; j < prices.Count; j++)
                    {
                        if (prices[j] < prices[i])
                        {
                            (prices[i], prices[j]) = (prices[j], prices[i]);
                            (names[i], names[j]) = (names[j], names[i]);
                        }
                    }
                }

                Console.WriteLine("Listan har sorterats efter pris.");
                continue;
            }

            // If the user enters a number, remove the corresponding item
            if (int.TryParse(input, out int number))
            {
                // The user sees numbers starting at 1, while the list index starts at 0
                int index = number - 1;

                // Check that the number exists in the list
                if (index >= 0 && index < names.Count)
                {
                    // Remove both the name and the price at the same index
                    names.RemoveAt(index);
                    prices.RemoveAt(index);

                    Console.WriteLine("Varan har tagits bort.");
                }
                else
                {
                    // Display an error message if the number does not exist
                    Console.WriteLine("Fel: Det finns ingen vara med det numret.");
                }
            }
            else
            {
                // If the user did not enter a number,
                // treat the input as the name of a new item

                string itemName = input;

                while (true)
                {
                    // Ask for the price
                    Console.Write("Ange pris: ");
                    string? priceInput = Console.ReadLine();

                    if (priceInput == null)
                    {
                        return;
                    }

                    // Try to convert the price to an integer
                    if (int.TryParse(priceInput, out int price))
                    {
                        // If the price is a valid integer,
                        // add both the name and the price to the end of the lists
                        names.Add(itemName);
                        prices.Add(price);

                        Console.WriteLine("Varan har lagts till.");
                        break;
                    }

                    // If the price is not an integer, ask for it again
                    Console.WriteLine("Fel: Priset måste vara ett heltal.");
                }
            }
        }
    }
}