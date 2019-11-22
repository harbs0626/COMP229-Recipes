using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

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

        public void ImageRecipe(string imageName)
        {
            var imageUpload = this.host.WebRootPath + "\\uploads\\" + Guid.NewGuid().ToString() + "_" + imageName;
            System.IO.File.Create(imageUpload);
        }
    }
}
