﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using RecipeFinder.Models;

namespace RecipeFinder.Helper
{
    public class RapidAPIDataService
    {
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
        }
    }
}