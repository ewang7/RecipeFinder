<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="RecipeFinder.UserPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div style="text-align: center;">
        <br />
        <img style="width: 200px; height: 200px; border-width: 50px; border-radius: 25px;" src=".//cookAvatarIcon.jpg"/>
        <br />
        <p>Welcome   
            <asp:Label ID="userNameLabel" runat="server" Text="username"></asp:Label>
        </p>
        <br />
        <br />
        <p>Email:   
            <asp:Label ID="emailLabel" runat="server" Text="email"></asp:Label>
        </p>
        <br />
        <p>Dietary Restriction:   
            <asp:Label ID="dietaryRestrictionLabel" runat="server" Text="dietaryRestriction"></asp:Label>
        </p>
        <br />
        <p>Favorites: Work-In-Progress</p>
        <br />
        <p>Password Change: Work-In-Prgoress</p>
    </div>
</asp:Content>
