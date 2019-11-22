using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public static class RecipeRepository
    {
        private static List<Recipe> recipes = 
            new List<Recipe>
            {
                //new Recipe
                //{
                //    RecipeId = 1001,
                //    Name = "Agedashi Tofu",
                //    Ingredients = "--INGREDIENTS--",
                //    Directions = "--DIRECTIONS--",
                //    PreparationTime = "15:00",
                //    CookingTime = "15:00",
                //    ReadyIn = "30:00",
                //    Suggestions = "--SUGGESTIONS--",
                //    NumberOfServings = 3,
                //    NumberOfCalories = 132,
                //    Review = "--REVIEW--",
                //    Rating = 5,
                //    Source = "--URL--",
                //    RecipeImage = "recipe1.jpg"
                //},
                //new Recipe
                //{
                //    RecipeId = 1002,
                //    Name = "Okonomiyaki",
                //    Ingredients = "--INGREDIENTS--",
                //    Directions = "--DIRECTIONS--",
                //    PreparationTime = "15:00",
                //    CookingTime = "15:00",
                //    ReadyIn = "30:00",
                //    Suggestions = "--SUGGESTIONS--",
                //    NumberOfServings = 3,
                //    NumberOfCalories = 132,
                //    Review = "--REVIEW--",
                //    Rating = 5,
                //    Source = "--URL--",
                //    RecipeImage = "recipe2.jpg"
                //},
                //new Recipe
                //{
                //    RecipeId = 1003,
                //    Name = "Oyakodon",
                //    Ingredients = "--INGREDIENTS--",
                //    Directions = "--DIRECTIONS--",
                //    PreparationTime = "15:00",
                //    CookingTime = "15:00",
                //    ReadyIn = "30:00",
                //    Suggestions = "--SUGGESTIONS--",
                //    NumberOfServings = 3,
                //    NumberOfCalories = 132,
                //    Review = "--REVIEW--",
                //    Rating = 5,
                //    Source = "--URL--",
                //    RecipeImage = "recipe3.jpg"
                //},
                //new Recipe
                //{
                //    RecipeId = 1004,
                //    Name = "Gyudon",
                //    Ingredients = "--INGREDIENTS--",
                //    Directions = "--DIRECTIONS--",
                //    PreparationTime = "15:00",
                //    CookingTime = "15:00",
                //    ReadyIn = "30:00",
                //    Suggestions = "--SUGGESTIONS--",
                //    NumberOfServings = 3,
                //    NumberOfCalories = 132,
                //    Review = "--REVIEW--",
                //    Rating = 5,
                //    Source = "--URL--",
                //    RecipeImage = "recipe4.jpg"
                //},
                //new Recipe
                //{
                //    RecipeId = 1005,
                //    Name = "Chicken Karaage",
                //    Ingredients = "--INGREDIENTS--",
                //    Directions = "--DIRECTIONS--",
                //    PreparationTime = "15:00",
                //    CookingTime = "15:00",
                //    ReadyIn = "30:00",
                //    Suggestions = "--SUGGESTIONS--",
                //    NumberOfServings = 3,
                //    NumberOfCalories = 132,
                //    Review = "--REVIEW--",
                //    Rating = 5,
                //    Source = "--URL--",
                //    RecipeImage = "recipe5.jpg"
                //},
                //new Recipe
                //{
                //    RecipeId = 1006,
                //    Name = "Teriyaki Salmon",
                //    Ingredients = "--INGREDIENTS--",
                //    Directions = "--DIRECTIONS--",
                //    PreparationTime = "15:00",
                //    CookingTime = "15:00",
                //    ReadyIn = "30:00",
                //    Suggestions = "--SUGGESTIONS--",
                //    NumberOfServings = 3,
                //    NumberOfCalories = 132,
                //    Review = "--REVIEW--",
                //    Rating = 5,
                //    Source = "--URL--",
                //    RecipeImage = "recipe6.jpg"
                //},
                //new Recipe
                //{
                //    RecipeId = 1007,
                //    Name = "Omurice",
                //    Ingredients = "--INGREDIENTS--",
                //    Directions = "--DIRECTIONS--",
                //    PreparationTime = "15:00",
                //    CookingTime = "15:00",
                //    ReadyIn = "30:00",
                //    Suggestions = "--SUGGESTIONS--",
                //    NumberOfServings = 3,
                //    NumberOfCalories = 132,
                //    Review = "--REVIEW--",
                //    Rating = 5,
                //    Source = "--URL--",
                //    RecipeImage = "recipe7.jpg"
                //},
                //new Recipe
                //{
                //    RecipeId = 1008,
                //    Name = "Tonkatsu",
                //    Ingredients = "--INGREDIENTS--",
                //    Directions = "--DIRECTIONS--",
                //    PreparationTime = "15:00",
                //    CookingTime = "15:00",
                //    ReadyIn = "30:00",
                //    Suggestions = "--SUGGESTIONS--",
                //    NumberOfServings = 3,
                //    NumberOfCalories = 132,
                //    Review = "--REVIEW--",
                //    Rating = 5,
                //    Source = "--URL--",
                //    RecipeImage = "recipe8.jpg"
                //},
                //new Recipe
                //{
                //    RecipeId = 1009,
                //    Name = "Matcha Green Tea Ice Cream",
                //    Ingredients = "--INGREDIENTS--",
                //    Directions = "--DIRECTIONS--",
                //    PreparationTime = "15:00",
                //    CookingTime = "15:00",
                //    ReadyIn = "30:00",
                //    Suggestions = "--SUGGESTIONS--",
                //    NumberOfServings = 3,
                //    NumberOfCalories = 132,
                //    Review = "--REVIEW--",
                //    Rating = 5,
                //    Source = "--URL--",
                //    RecipeImage = "recipe9.jpg"
                //}
            };

        public static IEnumerable<Recipe> Recipes
        {
            get
            {
                return recipes;
            }
        }
        public static void AddResponse(Recipe recipe)
        {
            recipes.Add(recipe);
        }

    }
}
