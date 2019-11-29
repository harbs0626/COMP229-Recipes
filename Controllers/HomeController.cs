using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;
using Recipes.Models.ViewModels;

namespace Recipes.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeRepository recipeRepository;
        private int PageSize = 4;
        
        public HomeController(IRecipeRepository reciRepo)
        {
            this.recipeRepository = reciRepo;
        }

        public ViewResult Index()
        {
            @ViewBag.Title = "Home";
            return View();
        }

        /*public ViewResult RecipeList()
        {
            @ViewBag.Title = "Recipe List";
            return View(new RecipeListViewModel
            {
                MyRecipes = this.recipeRepository.MyRecipes.OrderBy(p => p.RecipeId)
            });
            // ** Initial repository
            //return View(RecipeRepository.FormFields.OrderBy(p => p.RecipeId));
        }*/

        public ViewResult RecipeList(int recipePage = 1)
        {
            @ViewBag.Title = "Recipe List";
            return View(new RecipeListViewModel
            {
                MyRecipes = this.recipeRepository.MyRecipes
                    .OrderBy(p => p.RecipeId)
                    .Skip((recipePage - 1) * this.PageSize)
                    .Take(this.PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = recipePage,
                    RecipesPerPage = PageSize,
                    TotalRecipes = this.recipeRepository.MyRecipes.Count()
                }
            });
        }

        public ViewResult EditRecipe(int recipeId)
        {
            if (recipeId == 0)
            {
                @ViewBag.Title = "New Recipe";
                return View("EditRecipe", new Recipe());
            }
            else
            {
                @ViewBag.Title = "Edit Recipe";
                return View(this.recipeRepository.MyRecipes
                    .FirstOrDefault(r => r.RecipeId == recipeId));
            }
        }

        [HttpPost]
        public IActionResult EditRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                this.recipeRepository.SaveRecipe(recipe);
                TempData["returnMessage"] = $"{recipe.Name} has been saved!";
                return RedirectToAction("EditRecipe");
            }
            else
            {
                return View(recipe);
            }
        }

        [Authorize]
        public ViewResult Create()
        {
            @ViewBag.Title = "New Recipe";
            return View("EditRecipe", new Recipe());
        }

        [HttpPost]
        public IActionResult DeleteRecipe(int recipeId)
        {
            Recipe deletedRecipe = this.recipeRepository.DeleteRecipe(recipeId);

            if (deletedRecipe != null)
            {
                TempData["returnMessage"] = $"{deletedRecipe.Name} was deleted!";
            }

            return RedirectToAction("RecipeList");
        }

        /*public ViewResult AddRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                RecipeRepository.AddResponse(recipe);
                return View("Thanks", recipe);
            }
            else
            {
                @ViewBag.Title = "Add Recipe";
                return View();
            }
        }*/

        public ViewResult ViewRecipe(int id)
        {
            @ViewBag.Title = "View Recipe";
            return View(new RecipeListViewModel
            {
                MyRecipes = this.recipeRepository.MyRecipes.Where(p => p.RecipeId == id)
            });
            // ** Initial repository
            //return View(RecipeRepository.FormFields.Where(p => p.RecipeId == id));
        }

        public ViewResult ReviewRecipe(int recipeId)
        {
            @ViewBag.Title = "Review Recipe";
            return View(this.recipeRepository.MyRecipes
                .FirstOrDefault(r => r.RecipeId == recipeId));
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult ReviewRecipe(int recipeId, Recipe recipe)
        {
            this.recipeRepository.SaveReview(recipeId, recipe);
            TempData["returnMessage"] = $"{recipe.Name} was reviewed!";
            return RedirectToAction("RecipeList");
        }

    }
}