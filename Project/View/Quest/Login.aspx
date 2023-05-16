<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project.View.Quest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <br />

        <asp:Label ID="lbl_Email" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txt_Email" runat="server"></asp:TextBox>

        <br />

        <asp:Label ID="lbl_Password" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txt_Password" runat="server" TextMode="Password"></asp:TextBox>

        <br />

        <asp:CheckBox ID="cb_Remember" runat="server" Text="Remember Me"/>
        

        <br />

        <asp:Label ID="lbl_Error" runat="server" Text=""></asp:Label>

        <br />

        <asp:Button ID="bnt_Login" runat="server" Text="Login" onClick="bnt_Login_Click"/>
    </div>


</asp:Content>
