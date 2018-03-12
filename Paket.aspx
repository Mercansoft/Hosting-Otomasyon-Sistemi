<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="Paket.aspx.cs" Inherits="Paket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="inner_content_body">

<!-- Left Content Body Starts Here -->
<div class="left_content_body">

<!-- Heading -->
<p class="page_title">
    <asp:Label ID="_lblHostingName" runat="server">MercaN YazılıM <% Response.Write(_PaketCinsi.ToString()); %> Menüsü</asp:Label>
</p>
<div class="tabloustbaslik">    <%ImageMap1.ImageUrl = _dtWinHosting.Rows[0]["Resim"].ToString(); %><asp:ImageMap ID="ImageMap1" runat="server">
    </asp:ImageMap><span><% Response.Write(_PaketCinsi.ToString()); %> Paketlerimiz 

    </span></div> 
<div class="tabloustgri" style="color: #FFFFFF">
<div class="tabloismi">Paket Ismi</div>
<div class="tablowebalani">Web Alan&#305;</div>
<div class="tablotrafik">Ayl&#305;k Trafik</div>
<div class="tabloeposta">E-Posta</div>
<div class="tablomysql">Veritabanı</div>

<div class="tablosubdomain">SubDomain</div>
<div class="tabloucret">Y&#305;ll&#305;k &Uuml;cret</div>
</div> 
<%    
    for (int i = 0; i < _dtWinHosting.Rows.Count; i++)
        {
            _idPaket = Convert.ToInt32(_dtWinHosting.Rows[i]["idPaket"]);
            Response.Write("<div class='tablonormalveri'>"
                + "<div class='tabloismi'>" + _dtWinHosting.Rows[i]["PaketAdi"].ToString() + "</div>"
                + "<div class='tablowebalani'>" + _dtWinHosting.Rows[i]["Alan"].ToString() + "</div>"
                + "<div class='tablotrafik'>" + _dtWinHosting.Rows[i]["Trafik"].ToString() + "</div>"
                + "<div class='tabloeposta'>" + _dtWinHosting.Rows[i]["Email"].ToString() + "</div>"
                + "<div class='tablomysql'>" + _dtWinHosting.Rows[i]["Db"].ToString() + "</div>"
                + "<div class='tablosubdomain'>" + _dtWinHosting.Rows[i]["SubDomain"].ToString() + "</div>"
                + "<div class='tabloucret'>" + _dtWinHosting.Rows[i]["YillikFiyat"].ToString() + "TL</div>"
                + "<div class='tablosatinal'><a href='Siparis.aspx?Paket=" + Convert.ToInt32(_idPaket) + "'>SATIN AL</a></div></div>"
                );
        }
         %>
 <br />
 <br />

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

<%
    for (int i = 0; i < _dtMenu.Rows.Count; i++)
    {
        Response.Write("<li><a href='Paket.aspx?MercanYaziliM=" + Convert.ToInt32(_dtMenu.Rows[i]["idHostingTur"]) + "'>" + _dtMenu.Rows[i]["TurAdi"].ToString() + "</li>");
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

