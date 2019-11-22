using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> MyRecipes { get; }

        void SaveRecipe(Recipe recipe);

        Recipe DeleteRecipe(int recipeId);

        void ImageRecipe(string imageName);

    }
}
