<%@ Page Title="Contact" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="RecipeList.aspx.cs" Inherits="RecipeFinder.RecipeList" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Recipes</h1>
    </div>
    <div>
         <asp:Label ID="lblDish" style="font-size: large; font-style: normal" Text="Ingredient(s):" runat="server"/>
         <asp:TextBox ID="IngredientInput" Text="pasta" runat="server"/>
         <asp:Label ID="lblCuisine" style="font-size: large; font-style: normal" Text="Cuisine" runat="server"/>
         <asp:DropDownList id="CuisineList"
                    AutoPostBack="False"
                    runat="server">
                  <asp:ListItem Selected="True" Value="italian"> Italian </asp:ListItem>
                  <asp:ListItem Value="chinese"> Chinese </asp:ListItem>
                  <asp:ListItem Value="japanese"> Japanese </asp:ListItem>
                  <asp:ListItem Value="french"> French </asp:ListItem>
                  <asp:ListItem Value="mexican"> Mexican </asp:ListItem>
               </asp:DropDownList>
        <asp:Button ID="SearchButton" style="font-size: large; font-style: normal" Text="Search" OnClick="SearchButton_Click" runat="server" />
    </div>
    <br />
    <br />
    <div id="Recipes" title="Recipes" style="text-align: center">       
            <asp:ListView ID="recipeList"  
                ItemType="RecipeFinder.Models.Recipe" 
                runat="server"
                SelectMethod="GetRecipes" >
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No Recipes were Found.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <LayoutTemplate>
                    <table class="table" border="0" ID="tbl1" runat="server">
                        <tr runat="server" style="font-size: large; font-style: normal; text-align: center">
                            <th runat="server">ID</th>
                            <th runat="server">Title</th>
                            <th runat="server">Image</th>
                        </tr>
                        <tr runat="server" id="itemPlaceholder" />
                        </table>
                        <%--<asp:DataPager ID="DataPager1" runat="server">
                            <Fields>
                                <asp:NumericPagerField />
                            </Fields>
                             </asp:DataPager>--%>
                    </LayoutTemplate>
                <ItemTemplate>
                  <table cellpadding="2"  class="table" border="0" ID="tbl2" runat="server">
                    <tr runat="server">
                        <td>
                            <b style="font-size: large; font-style: normal">
                                <a href="/RecipeDetail.aspx?id=<%#: Item.id %>"><%#: Item.id %></a>
                            </b>
                        </td>
                        <td>
                            <asp:Label ID="title" runat="server" style="font-size: large; font-style: normal" Text='<%# Item.title %>' />
                        </td>
                        <td>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Item.image%>'/>
                        </td>
                     </tr>     
                   </table>
                </ItemTemplate>
            </asp:ListView>
        </div>
</asp:Content>