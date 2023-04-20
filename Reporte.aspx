<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="Laboratorio8.Reporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" class="table" runat="server" Height="133px" Width="494px">
    </asp:GridView>

    <h1>Total inscritos:</h1>
    
    <h1>
    
    <asp:Label ID="LabelTotal" runat="server" Text="[ 0 ]"></asp:Label>
    </h1>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" class="btn btn-primary btn-lg" Text="Mostrar Reporte" Width="224px" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="Button2" runat="server" class="btn btn-success btn-lg" OnClick="Button2_Click" Text="Ordenar" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Button ID="ButtonTotal" runat="server"  class="btn btn-info btn-lg" Text="Boton Total" OnClick="Button3_Click" />
</asp:Content>
