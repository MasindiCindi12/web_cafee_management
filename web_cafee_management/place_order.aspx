<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="place_order.aspx.cs" Inherits="web_cafee_management.place_order" %>
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
                <asp:Label ID="Label1" runat="server" Text="Place Order" Font-Names="Comic Sans MS" Font-Bold="True" Font-Size="16pt" ForeColor="#000076" />
                <br />
                <br />

                <div class="row">
                    <div class="col-sm-4 sm-offset-0">
                        <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label><br />
                        <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        <br />

                        <asp:TextBox ID="txtSearch" CssClass="form-control" Placeholder="Search" runat="server" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
                        <br />
                        <asp:ListBox ID="lstItems" CssClass="form-control" runat="server" OnSelectedIndexChanged="lstItems_SelectedIndexChanged"></asp:ListBox>

                    </div>

                    <div class="col-sm-8 sm-offset-0">


                        <div class="row">
                            <div class="col-sm-4 sm-offset-0">
                                <asp:Label ID="Label3" runat="server" Text="Category"></asp:Label><br />
                                <asp:TextBox ID="txtCategor" CssClass="form-control" Placeholder="Category" runat="server" OnTextChanged="txtCategor_TextChanged"></asp:TextBox>

                                <asp:Label ID="Label4" runat="server" Text="Item Name"></asp:Label><br />
                                <asp:TextBox ID="txtItemName" CssClass="form-control" Placeholder="Item Name" runat="server"></asp:TextBox>
                                <br />
                            </div>
                            <div class="col-sm-4 sm-offset-0">
                                <asp:Label ID="Label5" runat="server" Text="Item price"></asp:Label><br />
                                <asp:TextBox ID="txtItemprice" CssClass="form-control" Placeholder="Item Price" runat="server"></asp:TextBox>
                                <asp:Label ID="Label6" runat="server" Text="Quantity"></asp:Label><br />
                                <asp:TextBox ID="txtQuantity" CssClass="form-control" Placeholder="Quantity" TextMode="Number" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-sm-4 sm-offset-0">

                                <asp:Label ID="Label7" runat="server" Text="Total"></asp:Label><br />
                                <asp:TextBox ID="txtTotal" CssClass="form-control" Placeholder="Total" runat="server"></asp:TextBox>
                                <br />
                                <asp:Button ID="btnAddToCart" CssClass="form-control btn btn-primary" runat="server" Text="Add to Cart" />

                            </div>

                        </div>
                        <div class="row">
                            <div class="col-sm-12 sm-offset-0">
                               <asp:Label ID="lblHold" runat="server" Text=""></asp:Label>
                                <asp:GridView ID="GridView1" Width="100%" Height="35%" AllowPaging="true" AllowSorting="true" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True">
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
                            </div>
                        </div>
                      <br />
                        <div class="row">
                            <div class="col-sm-4 sm-offset-0">
                                <asp:Button ID="btnRemoveItem" CssClass="form-control btn btn-primary" runat="server" Text="Remove" OnClick="btnRemoveItem_Click" />
                            </div>
                            <div class="col-sm-4 sm-offset-0">

                                <asp:Label ID="lblTotal" runat="server" Text="R . 00"></asp:Label>
                            </div>

                            <div class="col-sm-4 sm-offset-0">
                                <asp:Button ID="btnPrint" CssClass="form-control btn btn-primary" runat="server" Text="Print" />
                            </div>
                        </div>

                    </div>


                    </div>

                
            </asp:Panel>
        </div>
        </div>
</asp:Content>
