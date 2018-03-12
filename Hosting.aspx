<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="Hosting.aspx.cs" Inherits="Hosting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="inner_content_body">

<!-- Left Content Body Starts Here -->
<div class="left_content_body">

<!-- Heading -->
<p class="page_title">
    <asp:Label ID="_lblHostingName" runat="server">MercaN YazılıM Hosting Menüsü</asp:Label>
</p>
<!-- Heading -->
<%
    for (int i = 0; i < _dtHosting.Rows.Count; i++)
    {
        if (i==0)
        {
            Response.Write("<table style='width: 70%'><tr><td style='width: 189px'>"
    + "<center><a href='Paket.aspx?MercaNYaziliM=1'><asp:Label ID='Label" + i.ToString() + "' runat='server'  Font-Bold='True'"
                    + "Font-Size='Small' ForeColor='#EE9803'>" + _dtHosting.Rows[i]["TurAdi"].ToString() + "</asp:Label><br />"
                + "<img src='" + _dtHosting.Rows[i]["Resim"].ToString() + "'style='width: 160px; height: 160px'/></img></a></center></td>");
        }
        else if (i==1)
        {
            Response.Write("<td><center><a href='Paket.aspx?MercaNYaziliM=2'><asp:Label ID='Label" + i.ToString() + "' runat='server'  Font-Bold='True'"
                    + "Font-Size='Small' ForeColor='#EE9803'>" + _dtHosting.Rows[i]["TurAdi"].ToString() + "</asp:Label><br />"
                + "<img src='" + _dtHosting.Rows[i]["Resim"].ToString() + "'style='width: 160px; height: 160px'/></img></a></center></td></tr>");
        }
        else if (i==2)
        {
            Response.Write("<tr><td><center><a href='Paket.aspx?MercaNYaziliM=3'><asp:Label ID='Label" + i.ToString() + "' runat='server'  Font-Bold='True'"
                    + "Font-Size='Small' ForeColor='#EE9803'>" + _dtHosting.Rows[i]["TurAdi"].ToString() + "</asp:Label><br />"
                + "<img src='" + _dtHosting.Rows[i]["Resim"].ToString() + "'style='width: 160px; height: 160px'/></img></a></center></td>");
        }
        else 
        {
            Response.Write("<td><center><a href='Paket.aspx?MercaNYaziliM=4'><asp:Label ID='Label" + i.ToString() + "' runat='server'  Font-Bold='True'"
                    + "Font-Size='Small' ForeColor='#EE9803'>" + _dtHosting.Rows[i]["TurAdi"].ToString() + "</asp:Label><br />"
                + "<img src='" + _dtHosting.Rows[i]["Resim"].ToString() + "' style='width: 160px; height: 160px'/></img></a></center></td></tr></table>");
        }
    }
     %>
    &nbsp;
 <%--   <img src="images/google_map.jpg" style="width: 100px; height: 100px"/></img>--%>
<%--    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Small" 
        ForeColor='#CF9803' Text="Label"></asp:Label>--%>
    <br />
</div>
<!-- Left Content Body Ends Here -->



<!-- Right Content Body Starts Here -->
<div class="right_content_body">

<!-- More Links Starts here -->
<!-- Heading -->
<p class="page_sub_title">
    Hosting Seçenekleri</p>
<!-- Heading -->

<div class="more_links">
<ul>
    <asp:BulletedList ID="BulletedList1" runat="server" DisplayMode="HyperLink">
    </asp:BulletedList>
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

