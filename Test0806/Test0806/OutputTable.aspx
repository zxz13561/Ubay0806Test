﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="OutputTable.aspx.cs" Inherits="Test0806.OutputTable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label Text="text" ID="lblBase" runat="server" />
    <asp:Label Text="text" ID="lblCol" runat="server" />
    <asp:Table runat="server" ID="Table1">

    </asp:Table>
</asp:Content>