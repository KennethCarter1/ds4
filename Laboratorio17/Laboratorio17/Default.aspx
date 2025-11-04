<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio17._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


        <div class="row">
          <div>

              <asp:GridView ID="MyGridView" DataSourceID="MyDataSource1"
                  AllowSorting="true" AllowPaging="true"
                  DataKeyNames="ProductID"
                  AutoGenerateColumns="true"
                  AutoGenerateSelectButton="true"
                Runat="server" />
              
            <asp:SqlDataSource ID="MyDataSource1" runat="server"
                ConnectionString="Data Source=localhost; Initial Catalog=Northwind; Integrated Security=True;"
                ProviderName="System.Data.SqlClient"
                SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products"
                UpdateCommand="UPDATE Products SET [ProductName] = @ProductName, [UnitPrice] = @UnitPrice WHERE [ProductID] = @ProductId">
            </asp:SqlDataSource>



          </div>
          
        </div>

</asp:Content>
