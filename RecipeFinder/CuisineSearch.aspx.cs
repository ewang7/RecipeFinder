using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RecipeFinder.Models;
using RecipeFinder.Helper;

namespace RecipeFinder
{
    public partial class CuisineSearch : System.Web.UI.Page
    {
        private String ingredients = "";
        private String cuisine = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            ingredients = Request.Form["userIngredients"];
            cuisine = Request.Form["cuisineDropdown"];
            SuperCuisineSearch recipes = GetRecipes(ingredients, cuisine);

            for (int i = 0; i < recipes.results.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            String recipeID = recipes.results[i].id.ToString();
                            RecipeID1.InnerHtml = "<a href='" + "/RecipeDetail.aspx?id=" + recipeID + "'>" + recipeID + "</a>";
                            RecipeTitle1.InnerHtml = recipes.results[i].title;
                            String imageURL = recipes.results[i].image;
                            RecipeImage1.InnerHtml = "<img src='" + imageURL + "'>";
                            break;
                        }
                    case 1:
                        {
                            String recipeID = recipes.results[i].id.ToString();
                            RecipeID2.InnerHtml = "<a href='" + "/RecipeDetail.aspx?id=" + recipeID + "'>" + recipeID + "</a>";
                            RecipeTitle2.InnerHtml = recipes.results[i].title;
                            String imageURL = recipes.results[i].image;
                            RecipeImage2.InnerHtml = "<img src='" + imageURL + "'>";
                            break;
                        }
                    case 2:
                        {
                            String recipeID = recipes.results[i].id.ToString();
                            RecipeID3.InnerHtml = "<a href='" + "/RecipeDetail.aspx?id=" + recipeID + "'>" + recipeID + "</a>";
                            RecipeTitle3.InnerHtml = recipes.results[i].title;
                            String imageURL = recipes.results[i].image;
                            RecipeImage3.InnerHtml = "<img src='" + imageURL + "'>";
                            break;
                        }
                    case 3:
                        {
                            String recipeID = recipes.results[i].id.ToString();
                            RecipeID4.InnerHtml = "<a href='" + "/RecipeDetail.aspx?id=" + recipeID + "'>" + recipeID + "</a>";
                            RecipeTitle4.InnerHtml = recipes.results[i].title;
                            String imageURL = recipes.results[i].image;
                            RecipeImage4.InnerHtml = "<img src='" + imageURL + "'>";
                            break;
                        }
                    case 4:
                        {
                            String recipeID = recipes.results[i].id.ToString();
                            RecipeID5.InnerHtml = "<a href='" + "/RecipeDetail.aspx?id=" + recipeID + "'>" + recipeID + "</a>";
                            RecipeTitle5.InnerHtml = recipes.results[i].title;
                            String imageURL = recipes.results[i].image;
                            RecipeImage5.InnerHtml = "<img src='" + imageURL + "'>";
                            break;
                        }
                }

            }
        }

        private SuperCuisineSearch GetRecipes(string ingredients, string cuisine)
        {
            RapidAPIDataService controller = new RapidAPIDataService();
            SuperCuisineSearch recipes = controller.getRecipeByCuisine(ingredients, cuisine);
            return recipes;
        }
    }
}