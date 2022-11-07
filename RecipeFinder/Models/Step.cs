using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeFinder.Models
{
    public class Step
    {
        public int number { get; set; }

        public string step { get; set; }

        public List<Ingredient> ingredients { get; set; }

        public List<Equipment> equipment { get; set; }

        public Length length { get; set; }

    }
}