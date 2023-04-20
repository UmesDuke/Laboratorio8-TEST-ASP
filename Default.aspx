<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio8._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>INSCRIPCIÓN CIUDADANO</h1>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="242px">
            </asp:DropDownList>
        </p>
        <p class="lead">&nbsp;</p>
        <p class="lead">Seleccionar partido:</p>
        <p class="lead">
            <asp:TextBox ID="TextBoxPartido" runat="server" Width="241px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonRegistrar" runat="server" CssClass="btn btn-primary btn-lg" OnClick="ButtonRegistrar_Click" Text="Registrar" />
        </p>
    </div>

</asp:Content>
