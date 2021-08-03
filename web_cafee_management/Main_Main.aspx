<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main_Main.aspx.cs" Inherits="web_cafee_management.Main_Main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-3">
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnPlaceOrder" CssClass="form-control btn btn-primary" runat="server" Text="Place Order" OnClick="btnPlaceOrder_Click" />
            <br />
            <br />
            <asp:Button ID="btnCategory" CssClass="form-control btn btn-primary" runat="server" Text="Add Category" OnClick="btnCategory_Click" />
            <br />
            <br />
            <asp:Button ID="btnAddItems" CssClass="form-control btn btn-primary" runat="server" Text="Add Items" OnClick="btnAddItems_Click" />
            <br />
            <br />
            <asp:Button ID="btnUpdate" CssClass="form-control btn btn-primary" runat="server" Text="Update Items" OnClick="btnUpdate_Click" />
            <br />
            <br />
            <asp:Button ID="btnRemove" CssClass="form-control btn btn-primary" runat="server" Text="Remove Items" OnClick="btnRemove_Click" />
     <br /><br /> <!-- <asp:LinkButton ID="LogOut" CssClass="btn btn-information" Font-Names="Comic Sans MS" Font-Size="12pt" runat="server" Text="Log Out"  />
     -->
            </div>

         <div class="col-sm-8 sm-offset-0">
             <br />
            <br />
             <asp:Panel ID="Panel1" CssClass="form-control" Height="375px" runat="server">
                 <asp:Label ID="Label1"  runat="server" Text="Product List" Font-Size="16pt" Font-Bold="True" Font-Names="Comic Sans MS" ForeColor="Blue" />
                 <br />
                 <br />
                 <div class="row">

                     <div class="col-sm-12 sm-offset-2">
                         <asp:GridView ID="GridView1" Width="100%" Height="100%" AllowPaging="true" PageSize="10" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanged="GridView1_PageIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
                             <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                             <EditRowStyle BackColor="#999999" />
                             <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                             <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                             <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                             <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                             <SortedAscendingCellStyle BackColor="#E9E7E2" />
                             <SortedAscendingHeaderStyle BackColor="#506C8C" />
                             <SortedDescendingCellStyle BackColor="#FFFDF8" />
                             <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

                             <PagerSettings FirstPageText="Next" PreviousPageText="Back" PageButtonCount="5" />
                         </asp:GridView>
                     </div>
                 </div>
             </asp:Panel>
        </div>

    </div>
</asp:Content>
