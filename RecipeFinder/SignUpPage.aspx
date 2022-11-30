<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Site.Master" CodeBehind="SignUpPage.aspx.cs" Inherits="RecipeFinder.SignUpPage" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    
        <div>
            
            Username:
                <asp:TextBox id='txtUserName' runat='server'></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please fill in Username"
                ControlToValidate="txtUserName">

            </asp:RequiredFieldValidator>
            <br />
            <br />
            Password:
            <asp:TextBox id='txtPassword' TextMode="Password" runat='server'></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please fill in Password"
                ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                ErrorMessage="Password must contain: Minimum 8 characters atleast 1 Alphabet and 1 Number" ControlToValidate="txtPassword"
                ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&amp;])[A-Za-z\d$@$!%*#?&amp;]{8,}$"></asp:RegularExpressionValidator>
            <br />
            Confirm Password:
                 <asp:TextBox id='txtConfirm' TextMode="Password" runat='server'></asp:TextBox>           
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords do not match" ControlToValidate="txtPassword" ControlToCompare="txtConfirm"></asp:CompareValidator>
            
            <br />
            Email Address:
            <asp:TextBox id='txtEmailAdd' runat='server'></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                runat="server" ErrorMessage="Please fill in Email Address" ControlToValidate="txtEmailAdd"></asp:RequiredFieldValidator>            
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailAdd" ErrorMessage="Email Address not valid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

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
            <br />
            <br />
        </div>
   

</asp:Content>
