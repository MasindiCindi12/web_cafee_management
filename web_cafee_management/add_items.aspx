<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="add_items.aspx.cs" Inherits="web_cafee_management.add_items" %>
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
        </div>


        <div class="col-sm-8 sm-offset-0">
            <br />
            <br />
            <asp:Panel ID="Panel1" CssClass="form-control" Height="375px" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Add Item" Font-Size="16pt" ForeColor="#000076" Font-Names="Comic Sans MS" Font-Bold="True" />
                <br />
                <br />
                <br />
                <div class="row">
                    <div class="col-sm-4 sm-offset-0">
                        <asp:Label ID="Label2" runat="server" Text="Category" />
                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server"></asp:DropDownList>
                        <asp:Label ID="Label3" runat="server" Text="Item Name" />
                        <asp:TextBox ID="txtName" CssClass="form-control" Placeholder="Item Name" runat="server"></asp:TextBox>
                        <asp:Label ID="Label4" runat="server" Text="Item Price" />
                        <asp:TextBox ID="txtprice" CssClass="form-control" Placeholder="Item Price" runat="server"></asp:TextBox>
                       <!-- <asp:Label ID="Label5" runat="server" Text="Item Size" />
                        <asp:TextBox ID="TextBox3" CssClass="form-control" Placeholder="Item Size" runat="server"></asp:TextBox>
-->
                       
                        <br />
                        <asp:Button ID="btnAddItem" CssClass="form-control btn btn-primary" runat="server" Text="Add Item" OnClick="btnAddItem_Click" />
                    </div>
                    <div class="col-sm-8 sm-offset-0">
                        <br />
                        <asp:GridView ID="GridView1" Width="100%" Height="65%" AllowPaging="true" AllowSorting="true" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging">
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
                        </asp:GridView>
                        <br />
                        <br />
                    </div>
                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
