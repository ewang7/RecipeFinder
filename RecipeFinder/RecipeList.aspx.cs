using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Threading;
using System.Web.ModelBinding;
using RecipeFinder.Models;
using RecipeFinder.Helper;
using System.Windows.Controls;

namespace RecipeFinder
{
    public partial class RecipeList : System.Web.UI.Page
    {
        private string ingredient = "";
        private string cuisine = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            cuisine = CuisineList.SelectedValue;
            ingredient = IngredientInput.Text;
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            recipeList.DataBind();
        }

        public Recipe[] GetRecipes()
        {
            return Task.Run(async () => await GetRecipeData(ingredient, cuisine)).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        private async Task<Recipe[]> GetRecipeData(string ingredient, string cuisine)
        {
            RapidAPIDataService svc = new RapidAPIDataService();
            Recipe[] recipes = await svc.getRecipes(ingredient, cuisine);
            return recipes;
        }
    }
}