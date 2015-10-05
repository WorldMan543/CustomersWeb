﻿<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consumers.aspx.cs" Inherits="ConsumerWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView runat="server" ID="сonsumersGrid"
        ItemType="ConsumerWeb.Models.Consumer" DataKeyNames="ConsumerId"
        SelectMethod="сonsumersGrid_GetData"
        DeleteMethod="сonsumersGrid_DeleteItem"
        AutoGenerateDeleteButton="true"
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="FullName" HeaderText="Name" />
            <asp:DynamicField DataField="Email" HeaderText="Email" />
            <asp:DynamicField DataField="DateOfBirth" HeaderText="Date Of Birth" />
            <asp:DynamicField DataField="ConsumerId" HeaderText="Actions" />
        </Columns>
    </asp:GridView>
</asp:Content>