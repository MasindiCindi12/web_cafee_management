<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="update_Item.aspx.cs" Inherits="web_cafee_management.update_Item" %>
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
             <asp:Panel ID="Panel1" CssClass="form-control" Height="420px" runat="server">
               <!--  <asp:Label ID="Label4"  runat="server" Text="" Font-Size="12" Font-Bold="True" Font-Names="Comic Sans MS" />
                -->
                 <asp:Label ID="Labe14" runat="server" Text="Update Item" Font-Names="Comic Sans MS" Font-Size="16pt" ForeColor="#000076" />
                  <br />
                
                 <br />
                 <div class="row">
                     <div class="col-sm-12 sm-offset-0">
                      <!--   <asp:Label ID="Label3" runat="server" Text="Item Name"></asp:Label><br />-->
                         <asp:TextBox ID="txtSearch" placeholder="Search Item Name" CssClass="form-control" runat="server"></asp:TextBox>
                         <asp:Button ID="btnSearch" CssClass="btn btn-primary" runat="server" Text="Search" OnClick="btnSearch_Click" />
                         
                         <br />

                          <asp:GridView ID="GridView1" Width="100%" Height="35%" AllowPaging="true" AllowSorting="true" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateSelectButton="True" PageSize="7">
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
                     <div class="row">
                          <br />
                         <div class="col-sm-4 sm-offset-3">
                            
                             <asp:Label ID="Label7" runat="server" Text="Item Name"></asp:Label><br />
                             <asp:TextBox ID="txtName" CssClass="form-control" Placeholder="Item Name" runat="server"></asp:TextBox>
                       
                             <asp:Label ID="Label6" runat="server" Text="Category"></asp:Label><br />
                             <asp:TextBox ID="txtCategory" CssClass="form-control" Placeholder="Category" runat="server"></asp:TextBox>

                            
                               </div>
                         <div class="col-sm-4 sm-offset-0">

                             <asp:Label ID="Label1" runat="server" Text="Price"></asp:Label><br />
                             <asp:TextBox ID="txtPrice" CssClass="form-control" Placeholder="Price" runat="server"></asp:TextBox>

                           
                            
                             <br />
                             <asp:Button ID="btnUpdateItem" CssClass="form-control btn btn-primary" runat="server" Text="Update Item" OnClick="btnUpdateItem_Click" />

                         </div>

                     </div>
                 
                 

                         


             </asp:Panel>
        </div>

    </div>
</asp:Content>
