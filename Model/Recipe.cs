using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Food_API.Model
{
    public class Recipe
    {
    

        public int Id { get; set; }

       
        public string Name { get; set; }

      
        public string Src { get; set; }

       
        public string Category { get; set; }

        public double Star { get; set; }

      
        public string Text { get; set; }

        public string Preptime { get; set; }

        public string Cookingtime { get; set; }

      
        public string Serving { get; set; }

      
        public List<string> Ingredients { get; set; }

        public List<List<string>> NutritionFacts { get; set; }

       
        public List<string> Instructions { get; set; }
    }
}
