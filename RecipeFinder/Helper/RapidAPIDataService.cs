﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using RecipeFinder.Models;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace RecipeFinder.Helper
{
    public class RapidAPIDataService
    {
        public List<SuperIngredientSearch> getRecipeByIngredients(string ingredientInput)
        {
            RestClient client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/");
            var request = new RestRequest("recipes/findByIngredients?ingredients=" + ingredientInput + "&number=5&ignorePantry=true&ranking=1", Method.Get);
            request.AddHeader("X-RapidAPI-Key", "API_KEY");
            request.AddHeader("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            RestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                String searchResults = response.Content;
                List<SuperIngredientSearch> recipeData = JsonConvert.DeserializeObject<List<SuperIngredientSearch>>(searchResults);
                return recipeData;
            }
            else
                return null;
        }

        public SuperDietaryRestrictionSearch getDietaryRestrictionRecipe(string ingredientInput, string dietaryRestriction)
        {
            RestClient client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/");
            var request = new RestRequest("recipes/search?query=" + ingredientInput + "&diet=" + dietaryRestriction + "&number=5&ignorePantry=true&ranking=1", Method.Get);
            request.AddHeader("X-RapidAPI-Key", "a050c13f77msh25ab18508fd852ep1edf0ejsn88311a72d376");
            request.AddHeader("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            RestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                String searchResults = response.Content;
                SuperDietaryRestrictionSearch recipeData = JsonConvert.DeserializeObject<SuperDietaryRestrictionSearch>(searchResults);
                return recipeData;
            }
            else
                return null;
        }


        /*
        public async Task<Recipe[]> getRecipes(string ingredient, string cuisine)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/complexSearch?query=" + ingredient + "&cuisine=" + cuisine + "&offset=0&number=20&limitLicense=false&ranking=2"),
                Headers =
                {
                    { "X-RapidAPI-Key", "a050c13f77msh25ab18508fd852ep1edf0ejsn88311a72d376" },
                    { "X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com" },
                },
            };

            using (HttpResponseMessage response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = response.Content.ReadAsStringAsync().Result;
                ComplexSearch recipeData = JsonConvert.DeserializeObject<ComplexSearch>(body);
                return recipeData.results.ToArray();
            }
        }

        public async Task<Models.RecipeDetail> getRecipeDetail(long id)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/" + id.ToString() + "/information"),
                Headers =
                {
                    { "X-RapidAPI-Key", "a050c13f77msh25ab18508fd852ep1edf0ejsn88311a72d376" },
                    { "X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com" },
                },
            };

            using (HttpResponseMessage response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = response.Content.ReadAsStringAsync().Result;
                Models.RecipeDetail recipeData = JsonConvert.DeserializeObject<Models.RecipeDetail>(body);
                return recipeData;
            }
        }*/

        public SuperCuisineSearch getRecipeByCuisine(string ingredient, string cuisine)
        {
            RestClient client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/");
            var request = new RestRequest("recipes/complexSearch?query=" + ingredient + "&cuisine=" + cuisine + "&offset=0&number=5&limitLicense=false&ranking=2", Method.Get);
            request.AddHeader("X-RapidAPI-Key", "a050c13f77msh25ab18508fd852ep1edf0ejsn88311a72d376");
            request.AddHeader("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            RestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                String searchResults = response.Content;
                SuperCuisineSearch recipeData = JsonConvert.DeserializeObject<SuperCuisineSearch>(searchResults);
                return recipeData;
            }
            else
                return null;
        }

        public Models.RecipeDetail getRecipeDetail(long id)
        {
            RestClient client = new RestClient("https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/");
            var request = new RestRequest("recipes/" + id.ToString() + "/information", Method.Get);
            request.AddHeader("X-RapidAPI-Key", "a050c13f77msh25ab18508fd852ep1edf0ejsn88311a72d376");
            request.AddHeader("X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
            RestResponse response = client.Execute(request);
            if (response.IsSuccessful)
            {
                String searchResults = response.Content;
                Models.RecipeDetail recipeData = JsonConvert.DeserializeObject<Models.RecipeDetail>(searchResults);
                return recipeData;
            }
            else
                return null;
        }

    }
}
