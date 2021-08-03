<%@ Page Title="" Language="C#" MasterPageFile="~/Login_Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="web_cafee_management.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-12">

            <asp:Panel ID="Panel1" runat="server">
            <div class="row">
                <div class="col-sm-4"></div>
                <div class="col-sm-6">
                   <!-- <asp:Label ID="Label1" runat="server" Text="Login" Font-Names="Comic Sans MS" Font-Size="16pt" ForeColor="#000076" />
                   --> <asp:Label ID="lblSession" runat="server" Font-Names="Comic Sans MS" Font-Size="16pt" ForeColor="#000076" />
                   
                    <div class="row">
                        <div class="col-sm-0"></div>
                        <div class="col-sm-2">
                             <asp:Image ID="Image1" src="../image/login.gif" Width="250px" Height="200px" AlternateText="~/image/login" runat="server" />
                   
                        </div>
                        <div class="col-sm-5"></div>
                    </div>
                    
                    <asp:Label ID="Label2" runat="server" Text="Username" Font-Names="Comic Sans MS" /><br />
                    <asp:TextBox ID="txtEmail" placeholder="Username" CssClass="form-control" TextMode="Email" runat="server" />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Password" Font-Names="Comic Sans MS" />
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Password"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnLogin" runat="server" CssClass="form-control btn btn-primary" Text="Login" Font-Names="Comic Sans MS" Font-Size="12pt" OnClick="btnLogin_Click" />
                     <br /><asp:LinkButton ID="btnGuest" runat="server" CssClass="btn btn-information" Text="Guest" Font-Names="Comic Sans MS" Font-Size="12pt" OnClick="btnGuest_Click" />
                </div>
                <div class="col-sm-3"></div>
            </div>

                </asp:Panel>
        </div>
       
    </div>


</asp:Content>
