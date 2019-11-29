using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Runtime.InteropServices;

namespace Recipes.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;
        private IHostingEnvironment host;

        public EFRecipeRepository(ApplicationDbContext ctx, IHostingEnvironment host)
        {
            this.context = ctx;
            this.host = host;
        }

        public IQueryable<Recipe> MyRecipes => context.MyRecipes;

        public void SaveRecipe(Recipe recipe)
        {
            if (recipe.RecipeId == 0)
            {
                recipe.RecipeImage = recipe.RecipeImage;
                context.MyRecipes.Add(recipe);

                // ** Upload image to folder
                this.ImageRecipe(recipe.RecipeImage);
            }
            else
            {
                Recipe recipeEntry = context.MyRecipes
                    .FirstOrDefault(r => r.RecipeId == recipe.RecipeId);

                if (recipeEntry != null)
                {
                    recipeEntry.Name = recipe.Name;
                    recipeEntry.Ingredients = recipe.Ingredients;
                    recipeEntry.Directions = recipe.Directions;
                    recipeEntry.PreparationTime = recipe.PreparationTime;
                    recipeEntry.CookingTime = recipe.CookingTime;
                    recipeEntry.ReadyIn = recipe.ReadyIn;
                    recipeEntry.Suggestions = recipe.Suggestions;
                    recipeEntry.NumberOfServings = recipe.NumberOfServings;
                    recipeEntry.NumberOfCalories = recipe.NumberOfCalories;
                    recipeEntry.RecipeImage = recipe.RecipeImage;

                    // ** Upload image to folder
                    this.ImageRecipe(recipe.RecipeImage);
                }
            }

            context.SaveChanges();
        }

        public Recipe DeleteRecipe(int recipeId)
        {
            Recipe recipeEntry = context.MyRecipes
                .FirstOrDefault(r => r.RecipeId == recipeId);

            if (recipeEntry != null)
            {
                context.MyRecipes.Remove(recipeEntry);
                context.SaveChanges();
            }

            return recipeEntry;
        }

        public void ImageRecipe(string imageFileName)
        {
            var srceFile = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\Downloads\\" + imageFileName);
            if (File.Exists(srceFile))
            {
                var destFile = this.host.WebRootPath + "\\uploads\\" + imageFileName;
                File.Copy(srceFile, destFile, true);
            }
        }

        public void SaveReview(int recipeId, Recipe recipe)
        {
            if (recipeId == 0) { }
            else
            {
                Recipe recipeEntry = context.MyRecipes
                    .FirstOrDefault(r => r.RecipeId == recipeId);

                recipeEntry.Review = recipeEntry.Review + "|" + recipe.Review;
                recipeEntry.RecipeRating = recipeEntry.RecipeRating + "|" + recipe.RecipeRating;
            }

            context.SaveChanges();
        }
    }
}
