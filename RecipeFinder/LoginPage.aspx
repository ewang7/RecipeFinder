﻿<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="Site.Master" CodeBehind="LoginPage.aspx.cs" Inherits="RecipeFinder.LoginPage" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <title></title>
</head>
<body>
    <div style="margin-left: 250px;">
        <form id="form1">
        <div>
            <br />
            Username:
            <asp:TextBox ID="txtUname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter username" ControlToValidate="txtUname"></asp:RequiredFieldValidator>
            <br />
            Password:
            <asp:TextBox ID="Password1" TextMode="Password" runat="server" ></asp:TextBox>
            <br />
            <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                <br />
            <asp:Label ID="logininfo" runat="server" Text=""></asp:Label>
                </div>
        </form>
    </div>
    <br />
</body>
</asp:Content>
