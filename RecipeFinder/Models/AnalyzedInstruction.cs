using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeFinder.Models
{
    public class AnalyzedInstruction
    {
        public string name { get; set; }

        public List<Step> steps { get; set; }
    }
}