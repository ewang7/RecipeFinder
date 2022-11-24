using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using RecipeFinder.Helper;
using RecipeFinder.Models;

namespace RecipeFinder
{
    public partial class RecipeDetail : System.Web.UI.Page
    {
        private Models.RecipeDetail recipeDetail1 = new Models.RecipeDetail();
        private List<Step> steps = new List<Step>();
        private List<Ingredient> ingredients = new List<Ingredient>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Models.RecipeDetail GetRecipeDetail([QueryString("id")] long id)
        {
            recipeDetail1 = GetRecipeDetailData(id);
            return recipeDetail1;
        }

        
        public List<Step> GetSteps()
        {
            steps = recipeDetail1.analyzedInstructions.Count > 0 ? recipeDetail1.analyzedInstructions[0].steps : new List<Step>();
            return steps;
        }

        public List<Ingredient> GetIngredients(int stepNum)
        {
            return (List<Ingredient>)from item in steps
                                     where item.number == stepNum
                                     select ingredients.ToList();
        }

        private Models.RecipeDetail GetRecipeDetailData(long id)
        {
            RapidAPIDataService controller = new RapidAPIDataService();
            Models.RecipeDetail recipeDetail = controller.getRecipeDetail(id);
            return recipeDetail;
        }
    }
}