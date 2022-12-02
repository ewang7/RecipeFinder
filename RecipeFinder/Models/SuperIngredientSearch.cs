﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeFinder.Models
{
    public class SuperIngredientSearch
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public int usedIngredientCount { get; set; }
        public int missedIngredientCount { get; set; }
        public List<MissedIngredient> missedIngredients { get; set; }
        public List<UsedIngredient> usedIngredients { get; set; }
        public List<object> unusedIngredients { get; set; }
        public int likes { get; set; }
    }
}