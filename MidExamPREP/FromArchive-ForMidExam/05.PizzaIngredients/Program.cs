namespace _05.PizzaIngredients
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split();
            int ingrLength = int.Parse(Console.ReadLine());
            int ingredientCounter = 0;

            List<string> addedIngredients = new List<string>();

            foreach (string ingredient in ingredients)
            {
                if (ingredient.Length == ingrLength)
                {
                    addedIngredients.Add(ingredient);
                    ingredientCounter++;
                    Console.WriteLine($"Adding {ingredient}.");
                }
                if (ingredientCounter == 10)
                {
                    break;
                }
            }
            Console.WriteLine($"You made pizza with total of {ingredientCounter} ingredients.");
            Console.Write("The ingredients are: ");
            Console.Write(string.Join(", ", addedIngredients));
            Console.WriteLine(".");



        }
    }
}