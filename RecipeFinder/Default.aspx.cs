using Newtonsoft.Json;
using RecipeFinder.Helper;
using RecipeFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecipeFinder
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void IngredientSearchSubmit(object sender, EventArgs e)
        {
            String ingredientInput = Request.Form[5];
            GetRecipes(ingredientInput);
        }

        private void GetRecipes(String input)
        {
            RapidAPIDataService controller = new RapidAPIDataService();
            List<SuperIngredientSearch> recipes = controller.getRecipeByIngredients(input);
            for(int i = 0; i < recipes.Count; i++)
            {
                switch(i)
                {
                    case 0:
                        {
                            String recipeID = recipes[i].id.ToString();
                            RecipeID1.InnerHtml = "<a href='" + "/RecipeDetail.aspx?id="+ recipeID + "'>" + recipeID + "</a>";
                            RecipeTitle1.InnerHtml = recipes[i].title;
                            String imageURL = recipes[i].image;
                            RecipeImage1.InnerHtml = "<img src='" + imageURL + "'>";
                            break;
                        }
                    case 1:
                        {
                            String recipeID = recipes[i].id.ToString();
                            RecipeID2.InnerHtml = "<a href='" + "/RecipeDetail.aspx?id=" + recipeID + "'>" + recipeID + "</a>";
                            RecipeTitle2.InnerHtml = recipes[i].title;
                            String imageURL = recipes[i].image;
                            RecipeImage2.InnerHtml = "<img src='" + imageURL + "'>";
                            break;
                        }
                    case 2:
                        {
                            String recipeID = recipes[i].id.ToString();
                            RecipeID3.InnerHtml = "<a href='" + "/RecipeDetail.aspx?id=" + recipeID + "'>" + recipeID + "</a>";
                            RecipeTitle3.InnerHtml = recipes[i].title;
                            String imageURL = recipes[i].image;
                            RecipeImage3.InnerHtml = "<img src='" + imageURL + "'>";
                            break;
                        }
                    case 3:
                        {
                            String recipeID = recipes[i].id.ToString();
                            RecipeID4.InnerHtml = "<a href='" + "/RecipeDetail.aspx?id=" + recipeID + "'>" + recipeID + "</a>";
                            RecipeTitle4.InnerHtml = recipes[i].title;
                            String imageURL = recipes[i].image;
                            RecipeImage4.InnerHtml = "<img src='" + imageURL + "'>";
                            break;
                        }
                    case 4:
                        {
                            String recipeID = recipes[i].id.ToString();
                            RecipeID5.InnerHtml = "<a href='" + "/RecipeDetail.aspx?id=" + recipeID + "'>" + recipeID + "</a>";
                            RecipeTitle5.InnerHtml = recipes[i].title;
                            String imageURL = recipes[i].image;
                            RecipeImage5.InnerHtml = "<img src='" + imageURL + "'>";
                            break;
                        }
                }

            }
        }


    }
}