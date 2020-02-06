using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeAssignment.Models;
namespace RecipeAssignment.Controllers

{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddRecipe(Recipe newRecipe)
        {
            Repository.AddRecipe(newRecipe);
            return View(newRecipe);
        }

        public ViewResult RecipeList()
        {
            return View(Repository.Recipes);
        }
        
        public ViewResult ReviewRecipe()
        {
            return View();
        }
       
        
        public ViewResult ViewRecipe(int id)
        {
            
            return View(Repository.FindId(id));
        }
    }
}
