<%@ Page Title="About" Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="RecipeDetail.aspx.cs" Inherits="RecipeFinder.RecipeDetail" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Recipe Details</h1>
    </div>  
    <div id="RecipeDetail" style="text-align: left">       
            <asp:ListView ID="recipeDetail"  
                ItemType="RecipeFinder.Models.RecipeDetail" 
                runat="server"
                SelectMethod="GetRecipeDetail" >
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <LayoutTemplate>
                    <table cellpadding="2" class="table" border="0" ID="tbl1" runat="server">
                        <tr runat="server" style="font-size: large; font-style: normal; text-align: left">
                            <th runat="server">ID</th>
                            <th runat="server">Title</th>
                            <th runat="server">Summary</th>
                            <th runat="server">Instructions</th>
                            <th runat="server">Image</th>
                        </tr>
                        <tr runat="server" id="itemPlaceholder" />
                        </table>
                    </LayoutTemplate>
                <ItemTemplate>
                     <table cellpadding="2" class="table" border="0" ID="tbl2" runat="server">
                        <tr runat="server">
                        <td>
                            <asp:Label ID="id" runat="server" style="font-size: large; text-align:left; font-style: normal" Text='<%# Item.id %>' />
                        </td>
                        <td>
                            <asp:Label ID="title" runat="server" style="font-size: large; text-align:left; font-style: normal" Text='<%# Item.title %>' />
                        </td>
                        <td>
                            <asp:Label ID="summary" runat="server" style="font-size: large; text-align:left; font-style: normal" Text='<%# Item.summary %>' />
                        </td>
                        <td>
                            <asp:Label ID="instructions" runat="server" style="font-size: large; text-align:left; font-style: normal" Text='<%# Item.instructions %>' />
                        </td>
                        <td>
                            <asp:Image ID="Image1" Width ="200px" runat="server" ImageUrl='<%#Item.image%>'/>
                        </td>
                        </tr> 
                     </table>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div>
            <h2>Instruction Details</h2>
        </div>  
        <div id="InstructionDetail" style="text-align: left">       
            <asp:ListView ID="listView3"  
                ItemType="RecipeFinder.Models.Step" 
                runat="server"
                SelectMethod="GetSteps" >
                <LayoutTemplate>
                    <table cellpadding="2" class="table" border="0" ID="tbl3" runat="server">
                        <tr runat="server" style="font-size: large; font-style: normal; text-align: left">
                            <th runat="server">Step</th>
                            <th runat="server">Description</th>
                            <%--<th runat="server">Ingredients</th>--%>
                        </tr>
                        <tr runat="server" id="itemPlaceholder" />
                        </table>
                    </LayoutTemplate>
                <ItemTemplate>
                     <table cellpadding="2" class="table" border="0" ID="tbl4" runat="server">
                        <tr runat="server">
                            <td>
                                <asp:Label ID="number" runat="server" style="font-size: large; text-align:left; font-style: normal" Text='<%# Item.number %>' />
                            </td>
                            <td>
                                <asp:Label ID="step" runat="server" style="font-size: large; text-align:left; font-style: normal" Text='<%# Item.step %>' />
                            </td>
                            <%--<td>
                                <asp:Label ID="Ingredients" runat="server" style="font-size: large; font-style: normal" Text='<%# Item.ingredients[0].name %>' />
                            </td>
                           <td>
                                <asp:Label ID="Label1" runat="server" style="font-size: large; font-style: normal" Text='<%# Item.ingredients[1].name %>' />
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" style="font-size: large; font-style: normal" Text='<%# Item.ingredients[2].name %>' />
                            </td>--%>
                        </tr> 
                     </table>
                </ItemTemplate>
            </asp:ListView>
        </div>
</asp:Content>