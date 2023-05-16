<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage/Master.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Project.View.Quest.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />

        <asp:Label ID="label_Name" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox>

        <br />

        <asp:Label ID="label_Email" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txt_Email" runat="server" TextMode="Email"></asp:TextBox>

        <br />

        <asp:Label ID="label_Gender" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButtonList ID="rb_Gender"  runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>

        <br />
        <asp:Label ID="label_Address" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="txt_Address" runat="server" ></asp:TextBox>

        <br />

        <asp:Label ID="label_password" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txt_Password" runat="server" TextMode="Password"></asp:TextBox>
        

        <br />
        <br />

        <asp:Label ID="label_Error" runat="server" Text=""></asp:Label>
        
        <br />

        <asp:Button ID="btn_Submit" runat="server" Text="Submit" onClick="btn_Submit_Click"/>

    </div>
</asp:Content>
