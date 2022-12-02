<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CuisineSearch.aspx.cs" Inherits="RecipeFinder.CuisineSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

            <div>
            <p> (Please separate multiple ingredients by comma) </p>
        <input id="userIngredients" type="text" value="Ingredient(s)..." runat="server" />
        <select name="cuisineDropdown" id="cuisineDropdown">
            <option value="chinese">Chinese</option>
            <option value="japanese">Japanese</option>
            <option value="korean">Korean</option>
            <option value="vietnamese">Vietnamese</option>
            <option value="thai">Thai</option>
            <option value="indian">Indian</option>
        </select>
        <input id="SubmitBtn" type="submit" value="Search" runat="server" OnServerClick="SearchButton_Click"/>
    <p></p>
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
        </div>
</asp:Content>
