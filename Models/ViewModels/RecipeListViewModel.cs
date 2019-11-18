﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Recipes.Models;

namespace Recipes.Models.ViewModels
{
    public class RecipeListViewModel
    {
        public IEnumerable<Recipe> MyRecipes { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
