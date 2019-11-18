using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Models
{
    public class Recipe {

        [Key]
        public int RecipeId { get; set; }
    
        [Required(ErrorMessage = "Please enter food name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter ingredients.")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Please enter directions.")]
        public string Directions { get; set; }

        [Required(ErrorMessage = "Please set preparation time.")]
        public string PreparationTime { get; set; }

        [Required(ErrorMessage = "Please set cooking time.")]
        public string CookingTime { get; set; }

        [Required(ErrorMessage = "Please set ready in.")]
        public string ReadyIn { get; set; }

        [Required(ErrorMessage = "Please enter suggestions.")]
        public string Suggestions { get; set; }

        [Required(ErrorMessage = "Please enter number of servings.")]
        public string NumberOfServings { get; set; }

        [Required(ErrorMessage = "Please enter number of calories.")]
        public string NumberOfCalories { get; set; }

        public string Review { get; set; }

        public int Rating { get; set; }

        public string RecipeImage { get; set; }

        // ** Temporary field incase recipe came from source site ^_^
        public string Source { get; set; }

    }
}
