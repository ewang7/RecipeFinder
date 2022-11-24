using System;
using RecipeFinder.Models;
using RecipeFinder.Helper;

namespace RecipeFinder
{
    public partial class RecipeList : System.Web.UI.Page
    {
        private string ingredients = "";
        private string cuisine = "";

        /*
        protected void Page_Load(object sender, EventArgs e)
        {
            cuisine = CuisineList.SelectedValue;
            ingredient = IngredientInput.Text;
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            recipeList.DataBind();
        }
        */

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}