<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="laptops.aspx.cs" Inherits="LaptopStore.Admin.laptops" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    brand:<asp:DropDownList ID="ddlbrand" runat="server"></asp:DropDownList>
    name:<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    <asp:Button ID="btnsave" runat="server" Text="save"  OnClick="btnsave_Click"/>
</asp:Content>
