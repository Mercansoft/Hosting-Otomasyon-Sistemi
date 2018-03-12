<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="Haber.aspx.cs" Inherits="Haber" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <div class="clear">
        <%
            Response.Write(_dtOku.Rows[0]["Baslik"].ToString() + "<br />"+_dtOku.Rows[0]["Haber"].ToString());
             %>
            
</div></p>
</asp:Content>

