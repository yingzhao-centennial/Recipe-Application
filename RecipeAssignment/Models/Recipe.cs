using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAssignment.Models
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public int Id { get; set; }
        public string Ingredient { get; set; }
        public string Instruction { get; set; }        
        public string Comments { get; set; }   
        public string Image { get; set; }
    }
}
