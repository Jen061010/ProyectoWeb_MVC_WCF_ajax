<%@ Page Title="Lista de clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="WebForms.Listado" %>

    <asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <hgroup class="title">
            <h1><%:Title %></h1>
        </hgroup>
        <asp:GridView ID="Lista" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="305px" OnSelectedIndexChanged="Lista_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
           <Columns>
              <asp:HyperLinkField  SortExpression="NewsHeadline" DataTextField="NewsHeadline" NavigateUrl="..." />
              <asp:HyperLinkField SortExpression="NewsHeadline" DataTextField="NewsHeadline" NavigateUrl="..." />
           </Columns>
        </asp:GridView>


        <asp:Button ID="Añadir" runat="server" OnClick="Button1_Click" Text="Add" />
        </asp:Content>