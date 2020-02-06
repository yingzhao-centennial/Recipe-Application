
using System.Collections.Generic;


namespace RecipeAssignment.Models
{
    public class Repository
    {
        private static List<Recipe> recipes = new List<Recipe>()
        {
            new Recipe
            {
                RecipeName="Kid-friendly Cobb Salad",
                Id=1,
                Ingredient="4 cups chopped romaine lettuce\n"+
                "1/4 cups prepared Thousand Island dressing\n"+
                "4 hard boiled egges, peeled and sliced or quartered\n"+
                "1/2 lb mini red potatoes, cooked and quartered\n"+
                "4 slices bacon, cooked and crumbled\n"+
                "1 cup halved grape tomatoes\n"+
                "1 cup chopped cucumbers\n"+
                "1/2 cup corn kernels\n"+
                "1/2 cup cubed Swiss chess\n",
                Instruction="Toss lettuce with half of the dressing; " +
                "arrange on small platter. Top with rows of eggs, potatoes, " +
                "bacon, tomatoes, cucumbers, corn and cheese. " +
                "Drizzle with remaining dressing.",
                Image="/images/Kid-Friendly-Cobb-Salad.jpg"
            },
            new Recipe
            {
                RecipeName="Egg Salad Sandwiches",
                Id=2,
                Ingredient="12 hard boiled eggs, peeled\n"+
                "12 slices whole wheat bread\n"+
                "1/2 cup mayonnaise\n"+
                "2 green onions, finely chopped\n"+
                "1/4 tsp each salt and pepper\n"+
                "1/4 cup butter, softened\n",
                Instruction="Mash eggs with a fork. Add green onions, mayonnaise, salt and pepper; " +
                "mix together until well combined.Butter each bread slice. " +
                "Spread egg salad mixture on half the slices. " +
                "Cap with remaining bread slices, buttered side down. "
                ,
                Image="/images/Egg-Salad-Sandwiches.jpg"
            }
        };
        public static IEnumerable<Recipe> Recipes
        {
            get
            {
                return recipes;
            }
        }

        public static void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }
        public static Recipe FindId(int id)
        {
            return recipes.Find(r => r.Id == id);
        }
    }
}
