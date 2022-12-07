<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DietaryRestrictionSearch.aspx.cs" Inherits="RecipeFinder.DietSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <center> 
        <input id="userIngredients" type="text" value="Ingredient(s)..." runat="server" />
    <label>Dietary Restriction: </label>
        <select name="dietaryRestriction" id="dietaryRestriction">
            <option value="pescetarian">Pescetarian</option>
            <option value="lacto vegetarian">Lacto Vegetarian</option>
            <option value="ovo vegetarian">Ovo Vegetarian</option>
            <option value="vegan">Vegan</option>
            <option value="vegetarian">Vegetarian</option>
        </select>
    <br />
        <input id="SubmitBtn" type="submit" value="Search" runat="server" OnServerClick="SearchButton_Click"/>
    <p></p>
        <p> (Please separate multiple ingredients by comma) </p>
    </center>
    <br />
        <div id="Recipes" title="Recipes" style="text-align: center">
            <table class="table" border="0" ID="tbl1" runat="server">
                <tr runat="server" style="font-size: large; font-style: normal; text-align: center;">
                    <th runat="server">ID</th>
                    <th runat="server">Title</th>
                    <th runat="server">Image</th>
                </tr>
                <tr runat="server">
                    <td>
                        <b style="font-size: medium; font-style: normal">
                            <span id="RecipeID1" runat=server />
                        </b>
                    </td>
                    <td>
                        <span id="RecipeTitle1" runat=server />
                    </td>
                    <td>
                        <span id="RecipeImage1" runat=server />
                    </td>
                </tr>
                <tr runat="server">
                    <td>
                        <b style="font-size: medium; font-style: normal">
                            <span id="RecipeID2" runat=server />
                        </b>
                    </td>
                    <td>
                        <span id="RecipeTitle2" runat=server />
                    </td>
                    <td>
                        <span id="RecipeImage2" runat=server />
                    </td>
                </tr>
                <tr runat="server">
                    <td>
                        <b style="font-size: medium; font-style: normal">
                            <span id="RecipeID3" runat=server />
                        </b>
                    </td>
                    <td>
                        <span id="RecipeTitle3" runat=server />
                    </td>
                    <td>
                        <span id="RecipeImage3" runat=server />
                    </td>
                </tr>
                <tr runat="server">
                    <td>
                        <b style="font-size: medium; font-style: normal">
                            <span id="RecipeID4" runat=server />
                        </b>
                    </td>
                    <td>
                        <span id="RecipeTitle4" runat=server />
                    </td>
                    <td>
                        <span id="RecipeImage4" runat=server />
                    </td>
                </tr>
                <tr runat="server">
                    <td>
                        <b style="font-size: medium; font-style: normal">
                            <span id="RecipeID5" runat=server />
                        </b>
                    </td>
                    <td>
                        <span id="RecipeTitle5" runat=server />
                    </td>
                    <td>
                        <span id="RecipeImage5" runat=server />
                    </td>
                </tr>
        </table>
        </div>
    <p>
    </p>
</asp:Content>
