﻿using Microsoft.AspNetCore.Mvc;
using FoodAplication.Models;

namespace FoodAplication.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetRecipeCard([FromBody] List<Recipe> recipes)
        {
            return PartialView("", recipes);
        }
    }
}
