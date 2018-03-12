<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="Referans.aspx.cs" Inherits="Referans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div id="inner_content_body">

<!-- Left Content Body Starts Here -->
<div class="left_content_body">

<!-- Heading -->
<p class="page_title">
    <asp:Label ID="_lblHizmetName" runat="server"></asp:Label>
</p>
<!-- Heading -->

    &nbsp;<table style="width: 100%">
        <tr>
            <td style="width: 263px">
                <asp:ImageMap ID="ImageMap1" runat="server" Height="250px" Width="250px">
                </asp:ImageMap>
            </td>
            <td>
                <table style="width: 100%">
                    <tr>
                        <td>
                <asp:Label ID="_lblAciklama" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink ID="HyperLink1" runat="server">[HyperLink1]</asp:HyperLink>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <br />
</div>
<!-- Left Content Body Ends Here -->



<!-- Right Content Body Starts Here -->
<div class="right_content_body">

<!-- More Links Starts here -->
<!-- Heading -->
<p class="page_sub_title">
Referanslar
</p>
<!-- Heading -->

<div class="more_links">
<ul>
<%
    for (int i = 0; i < _dtMenu.Rows.Count; i++)
    {
        Response.Write("<li><a href='Referans.aspx?MercanYaziliM=" + Convert.ToInt32(_dtMenu.Rows[i]["idReferans"]) + "'>" + _dtMenu.Rows[i]["ReferansAdi"].ToString() + "</li>");
    }
    
    
     %>




<%--    <asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="HyperLink">
    </asp:BulletedList>--%>
</ul>
</div>

<!-- More Links Ends Here -->

</div>
<!-- Right Content Body Ends here -->

<!-- Clear -->
<div class="clear">
</div>
<!-- Clear -->

</div>
        </asp:Content>

