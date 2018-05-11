<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="SampleRepo.Members" %>

<%@ Import Namespace="SampleRepo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>Member page</p>

    <h2>Kullanıcılar</h2>
    <%
        List<Dictionary<string, string>> rows = DB.GetAllUsers();

        foreach (Dictionary<string, string> row in rows)
        {
    %>
    <div>
        <p><%=String.Join(",", row)%></p>
    </div>
    <%

        } %>


    <h2>kullanıcı id ile ara</h2>
    <asp:TextBox runat="server" Text="" ID="txtUserId" />
    <asp:Button Text="Tıkla" runat="server" OnClick="Unnamed_Click" />
    <p>
        <asp:Label Text="" ID="lblResult" runat="server" />
    </p>

</asp:Content>
