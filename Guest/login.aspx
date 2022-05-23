<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LaptopStore.Guest.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Username:<asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
    password:<asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
    <asp:Button ID="btnlogin" runat="server" Text="login" OnClick="btnlogin_Click" />
</asp:Content>
