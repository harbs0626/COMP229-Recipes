using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalRecipes { get; set; }
        public int RecipesPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages()
        {
            return (int) Math.Ceiling((decimal) this.TotalRecipes / this.RecipesPerPage);
        }


    }
}
