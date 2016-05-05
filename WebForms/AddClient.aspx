<%@ Page Title="Añade un cliente" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AddClient.aspx.cs" Inherits="WebForms.AddClient" %>

    
    
        <asp:Content ID="BodyContent" runat="server" contentplaceholderid="MainContent">
            <hgroup class="title">
                <h1><%:Title %></h1>
            </hgroup>
            <strong>Nombre</strong><br />
            <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
            <br />
            <strong>Teléfono</strong><br />
            <asp:TextBox ID="Teléfono" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Añadir" Text="Create" />
        </asp:Content>
   



