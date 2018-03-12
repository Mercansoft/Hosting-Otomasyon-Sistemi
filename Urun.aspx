<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="Urun.aspx.cs" Inherits="Urun" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <div id="inner_content_body">

<!-- Left Content Body Starts Here -->
<div class="left_content_body">

<!-- Heading -->
<p class="page_title">
    <asp:Label ID="_lblUrunName" runat="server"></asp:Label>
</p>
<!-- Heading -->

    &nbsp;<table style="width: 91%; height: 341px">
        <tr>
            <td style="width: 200px; height: 139px;">
                <br />
                
                <a href="<%Response.Write(_BResim.ToString()); %>" rel="rokbox[1152 832]" title="<% Response.Write(_lblUrunName.Text.ToString()); %>"><asp:ImageMap ID="ImageMap1" runat="server" Height="340px" 
                    Width="600px"/></a>
                </asp:ImageMap>
            </td>
        </tr>
        <tr>
            <td style="width: 200px"><br /><br />
                <asp:Label ID="_lblAciklama" runat="server" Font-Bold="True" ForeColor="White"></asp:Label>
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
Ürünler
    Menüsü</p>
<!-- Heading -->

<div class="more_links">
<ul>
<%
    for (int i = 0; i < _dtMenu.Rows.Count; i++)
    {
        Response.Write("<li><img src='images/info.jpg'><a href='Urun.aspx?MercanYaziliM=" + Convert.ToInt32(_dtMenu.Rows[i]["idUrun"]) + "'>" + _dtMenu.Rows[i]["UrunAdi"].ToString() + "</img></li>");
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
        </p>
</asp:Content>

