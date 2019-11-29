using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Recipes.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.MyRecipes.Any())
            {
                context.MyRecipes.AddRange(
                    new Recipe
                    {
                        Name = "Agedashi Tofu",
                        Ingredients = "--INGREDIENTS--",
                        Directions = "--DIRECTIONS--",
                        PreparationTime = "15:00",
                        CookingTime = "15:00",
                        ReadyIn = "30:00",
                        Suggestions = "--SUGGESTIONS--",
                        NumberOfServings = 3,
                        NumberOfCalories = 132,
                        Review = null,
                        RecipeRating = "0",
                        Source = "--URL--",
                        RecipeImage = "recipe1.jpg"
                    },
                    new Recipe
                    {
                        Name = "Okonomiyaki",
                        Ingredients = "--INGREDIENTS--",
                        Directions = "--DIRECTIONS--",
                        PreparationTime = "15:00",
                        CookingTime = "15:00",
                        ReadyIn = "30:00",
                        Suggestions = "--SUGGESTIONS--",
                        NumberOfServings = 3,
                        NumberOfCalories = 132,
                        Review = null,
                        RecipeRating = "0",
                        Source = "--URL--",
                        RecipeImage = "recipe2.jpg"
                    },
                    new Recipe
                    {
                        Name = "Oyakodon",
                        Ingredients = "--INGREDIENTS--",
                        Directions = "--DIRECTIONS--",
                        PreparationTime = "15:00",
                        CookingTime = "15:00",
                        ReadyIn = "30:00",
                        Suggestions = "--SUGGESTIONS--",
                        NumberOfServings = 3,
                        NumberOfCalories = 132,
                        Review = null,
                        RecipeRating = "0",
                        Source = "--URL--",
                        RecipeImage = "recipe3.jpg"
                    },
                    new Recipe
                    {
                        Name = "Gyudon",
                        Ingredients = "--INGREDIENTS--",
                        Directions = "--DIRECTIONS--",
                        PreparationTime = "15:00",
                        CookingTime = "15:00",
                        ReadyIn = "30:00",
                        Suggestions = "--SUGGESTIONS--",
                        NumberOfServings = 3,
                        NumberOfCalories = 132,
                        Review = null,
                        RecipeRating = "0",
                        Source = "--URL--",
                        RecipeImage = "recipe4.jpg"
                    },
                    new Recipe
                    {
                        Name = "Chicken Karaage",
                        Ingredients = "--INGREDIENTS--",
                        Directions = "--DIRECTIONS--",
                        PreparationTime = "15:00",
                        CookingTime = "15:00",
                        ReadyIn = "30:00",
                        Suggestions = "--SUGGESTIONS--",
                        NumberOfServings = 3,
                        NumberOfCalories = 132,
                        Review = null,
                        RecipeRating = "0",
                        Source = "--URL--",
                        RecipeImage = "recipe5.jpg"
                    },
                    new Recipe
                    {
                        Name = "Teriyaki Salmon",
                        Ingredients = "--INGREDIENTS--",
                        Directions = "--DIRECTIONS--",
                        PreparationTime = "15:00",
                        CookingTime = "15:00",
                        ReadyIn = "30:00",
                        Suggestions = "--SUGGESTIONS--",
                        NumberOfServings = 3,
                        NumberOfCalories = 132,
                        Review = null,
                        RecipeRating = "0",
                        Source = "--URL--",
                        RecipeImage = "recipe6.jpg"
                    },
                    new Recipe
                    {
                        Name = "Omurice",
                        Ingredients = "--INGREDIENTS--",
                        Directions = "--DIRECTIONS--",
                        PreparationTime = "15:00",
                        CookingTime = "15:00",
                        ReadyIn = "30:00",
                        Suggestions = "--SUGGESTIONS--",
                        NumberOfServings = 3,
                        NumberOfCalories = 132,
                        Review = null,
                        RecipeRating = "0",
                        Source = "--URL--",
                        RecipeImage = "recipe7.jpg"
                    },
                    new Recipe
                    {
                        Name = "Tonkatsu",
                        Ingredients = "--INGREDIENTS--",
                        Directions = "--DIRECTIONS--",
                        PreparationTime = "15:00",
                        CookingTime = "15:00",
                        ReadyIn = "30:00",
                        Suggestions = "--SUGGESTIONS--",
                        NumberOfServings = 3,
                        NumberOfCalories = 132,
                        Review = null,
                        RecipeRating = "0",
                        Source = "--URL--",
                        RecipeImage = "recipe8.jpg"
                    },
                    new Recipe
                    {
                        Name = "Matcha Green Tea Ice Cream",
                        Ingredients = "--INGREDIENTS--",
                        Directions = "--DIRECTIONS--",
                        PreparationTime = "15:00",
                        CookingTime = "15:00",
                        ReadyIn = "30:00",
                        Suggestions = "--SUGGESTIONS--",
                        NumberOfServings = 3,
                        NumberOfCalories = 132,
                        Review = null,
                        RecipeRating = "0",
                        Source = "--URL--",
                        RecipeImage = "recipe9.jpg"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
