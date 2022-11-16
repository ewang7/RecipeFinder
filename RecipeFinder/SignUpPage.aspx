<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Site.Master" CodeBehind="SignUpPage.aspx.cs" Inherits="RecipeFinder.SignUpPage" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    
        <div>
            Username:
            <input id="uname" type="text" /><br />
            Password:
            <input id="pwd" type="password" /><br />
            Confirm Password:
            <input id="cpwd" type="text" /><br />
            Email Address:
            <input id="email" type="text" /><br />
            <br />
            <asp:Button ID="signupb" runat="server" Text="Sign Up" OnClick="Button1_Click" />
            <asp:Label ID="errormessage" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
                <WizardSteps>
                    <asp:CreateUserWizardStep runat="server" />
                    <asp:CompleteWizardStep runat="server" />
                </WizardSteps>
            </asp:CreateUserWizard>
            <br />
            <br />
        </div>
   

</asp:Content>
