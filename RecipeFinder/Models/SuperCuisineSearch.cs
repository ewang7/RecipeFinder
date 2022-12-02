using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeFinder.Models
{
    public class SuperCuisineSearch
    {
        public List<Result> results { get; set; }
        public string baseUri { get; set; }
        public int offset { get; set; }
        public int number { get; set; }
        public int totalResults { get; set; }
        public int processingTimeMs { get; set; }
    }
}