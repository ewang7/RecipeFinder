using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeFinder.Models
{
    public class Result
    {

        public int id { get; set; }
        public int usedIngredientCount { get; set; }
        public int missedIngredientCount { get; set; }
        public int likes { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public int calories { get; set; }
        public string protein { get; set; }
        public string fat { get; set; }
        public string carbs { get; set; }

    }
}