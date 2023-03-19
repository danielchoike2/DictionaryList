namespace WorkingWithDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> FoodList = new Dictionary<string, string>();
            
            

            //Adding Food
            FoodList.Add("Pizza", "Italian");
            FoodList.Add("Spagehtti", "Italian");
            FoodList.Add("Schnitzel", "German");
            FoodList.Add("Bled Creme Cake", "Slovenia");
            FoodList.Add("Ratatouille", "French");

            Console.WriteLine("FoodList Keys");
            Dictionary<string, string>.KeyCollection keys = FoodList.Keys;
            foreach (string k in keys)
            {
                Console.WriteLine("Key: {0}", k);
            }
            Console.WriteLine();

            Console.WriteLine("FoodList Values");
            Dictionary<string, string>.ValueCollection values = FoodList.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();

            Console.WriteLine("FoodList Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in FoodList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();
            // Changing values - removing spagetti from list 
            
            FoodList.Remove("Spagehtti");

            Console.WriteLine("Dictionary list after removing Spaghetti");
            foreach (KeyValuePair<string, string> kvp in FoodList)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine();

            
           
           

          

            


        }

    }
}
