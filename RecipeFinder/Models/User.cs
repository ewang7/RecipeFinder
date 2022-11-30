using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipeFinder.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string dietary_restrictions { get; set; }
        public string email { get; set; }
    }
}