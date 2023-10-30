namespace SHOPPING_LIST___OCT_26;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Dave's Market!");


        Dictionary<string, decimal> theMenu = new Dictionary<string, decimal>();
        {

            theMenu.Add("apple",       2.99m);
            theMenu.Add("Banana",      2.75m);
            theMenu.Add("cauliflower", 1.59m);
            theMenu.Add("dragonfruit", 2.19m);
            theMenu.Add("Elderberry",  1.79m);
            theMenu.Add("Figs",        2.09m);
            theMenu.Add("grapefruit",  1.99m);
            theMenu.Add("honeydew",    3.49m);

            foreach(KeyValuePair<string, decimal> item in theMenu)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
                
            }           





        }


        List<string> shoppingList = new List<string>();
        while(true)
        { 
            Console.WriteLine("what would you like to add to your cart.");
            String userInput = Console.ReadLine();

           if(theMenu.ContainsKey(userInput))
            {
                shoppingList.Add(userInput);
                Console.WriteLine($"Adding {userInput} to cart," );
                Console.WriteLine("would you like to add anything else[Y,N}");
                Console.WriteLine();
                string choice = Console.ReadLine().Trim().ToUpper();
                if(choice == "N")
                {
                    break;
                }

                
                
            }
           else
            {
                Console.WriteLine("that is not on the menu.");
                
            }

           

        }

        //AddGroceries(shoppingStuff);
            



    }


    static void AddGroceries(List<string>shoppingstuff)
    {
        while (true)
        {

            Console.WriteLine("What item would you like to order?");
            string itemOrdered = Console.ReadLine().Trim();
            Console.WriteLine($"Adding {itemOrdered} to your cart.");


            shoppingstuff.Add(itemOrdered);



            Console.WriteLine("Would you like to add anything else?[Y/N]");
            string userInput = Console.ReadLine().ToUpper().Trim();

            if (userInput == "N")
            {
                Console.WriteLine("Here is what is in your cart");
                foreach (string item in shoppingstuff)
                {
                    Console.WriteLine(item);
                }

                break;
            }

        }


    }
    
}

