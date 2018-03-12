<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default2.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title><% Response.Write(_StrPageTitle.ToString()); %></title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-9">
<meta http-equiv="Content-Language" content="tr">
<meta http-equiv="Content-Type" content="text/html; charset=windows-1254">
<meta name="GENERATOR" content="Microsoft FrontPage 6.0">
<meta name="ProgId" content="FrontPage.Editor.Document">
<meta name="description" content="<% Response.Write(_StrPageDescription.ToString()); %>" />
<meta name="keywords" content="<% Response.Write(_StrPageKeywords.ToString()); %>" />
<meta name="title" content="Mercan Yazılım Software Technology's Yavuz MERCAN" />
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-9" />
<meta http-equiv="robots" content="index,follow" />
<meta http-equiv="content-language" content="tr" />
<meta name="robots" content="index, follow" />
<meta name="Revisit-After" content="7 Days" />
<meta name="author" content="Yavuz MERCAN C# Technology" />
 <link rel="stylesheet" type="text/css" href="css/style.css" /> 
 	<link rel="stylesheet" href="css/slideshow.css">
	<style>
		.slideshow { float: left; margin: 3px 5px 5px 36px;
            top: -1px;
            left: -48px;
            }
	</style>
	<script src="js/mootools-1.3.1-core.js"></script>
	<script src="js/mootools-1.3.1.1-more.js"></script>
	<script src="js/slideshow.js"></script>
	<script src="js/slideshow.fold.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
<script type="text/javascript" src="js/s3Slider.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        $('#slider1').s3Slider({
            timeOut: 4000
        });
    });
</script>
	<script>
	    window.addEvent('domready', function () {
	        var data = { '1.png': { caption: '1' }, '2.png': { caption: '2' }, '3.png': { caption: '3' }, '4.png': { caption: '4'} };
	        new Slideshow.Fold('fold', data, { height: 250, hu: 'images/', width: 630 });
	    });
	</script>
    <style type="text/css">
        .style2
        {
            width: 643px;
        }
        .style3
        {
            width: 305px;
            height: 80px;
        }
        .style4
        {
            width: 305px;
            height: 78px;
        }
        .style5
        {
            width: 243px;
            height: 79px;
        }
        </style>

  <style type="text/css" media="screen">
#slider1 {
    width: 720px; /* important to be same as image width */
    height: 300px; /* important to be same as image height */
    position: relative; /* important */
	overflow: hidden; /* important */
}

#slider1Content {
    width: 720px; /* important to be same as image width or wider */
    position: absolute;
	top: 0;
	margin-left: 0;
}
.slider1Image {
    float: left;
    position: relative;
	display: none;
}
.slider1Image span {
    position: absolute;
	font: 10px/15px Arial, Helvetica, sans-serif;
    padding: 10px 13px;
    width: 694px;
    background-color: #000;
    filter: alpha(opacity=70);
    -moz-opacity: 0.7;
	-khtml-opacity: 0.7;
    opacity: 0.7;
    color: #fff;
    display: none;
}
.clear {
	clear: both;
}
.slider1Image span strong {
    font-size: 14px;
}
.left {
	top: 0;
    left: 0;
	width: 329px !important;
	height: 25px;
}
.right {
	right: 0;
	bottom: 0;
	width: 384px !important;
	height: 29px;
}
ul { list-style-type: none;}
</style>
</head>

<body>

    <form id="form1" runat="server">

<!-- Main Body Starts Here -->
<div id="main_body">
<!-- Top Part Starts Here -->
<div id="top_part">

<!-- Top Part Image Starts Here -->
<div id="top_part_image">

<!-- Logo Part Starts Here -->
<div id="main_logo">
<a href="Default2.aspx"><img src="images/MC-5.png"  alt="Design3Edge" 
        style="height: 70px; width: 217px"  /></a> </div>

</div>

<div id="main_menu_bg">

<div id="main_menu_body">

<%
    Response.Write("<div class='menu_links'>");
    for (int i = 0; i < _dtMenu.Rows.Count; i++)
    {
        Response.Write("<a href='" + _dtMenu.Rows[i]["MenuUrl"].ToString() + "'class='menu_links'>" + _dtMenu.Rows[i]["MenuAdi"].ToString() + "</a><span class='menu_border'>&nbsp;</span>");
    }
    Response.Write("</div>");
     %>


</div>

</div>


</div>

<div id="content_body">
    <table align="center">
        <tr>
            <td class="style2">
    <div id="slider1">
        <ul id="slider1Content">
<%
    for (int i = 0; i < _dtBanner.Rows.Count; i++)
    {
        Response.Write("<li class='slider1Image'><img src='" + _dtBanner.Rows[i]["Resim"].ToString() + "' alt='5' /><span class='right'><strong>" + _dtBanner.Rows[i]["Baslik"].ToString() + "</strong><br />" + _dtBanner.Rows[i]["Aciklama"].ToString() + "</span></li>");
    }
     %>
            <div class="clear slider1Image"></div>
        </ul>
    </div>
            </td>
            <td>
               <div id="Div1">

<div id="Div2">

<div class="headers">
	Duyurular
</div>


  <div class="testi_box">
  <marquee direction=up scrolldelay=200 onMouseOver='this.stop()' 
          onMouseOut='this.start()' style="height: 190px">
<%
    for (int i = 0; i < _dtSagUst.Rows.Count; i++)
    {
        Response.Write("<p><a href='Haber.aspx?MercaNYaziliM=" + _dtSagUst.Rows[i]["idHaber"].ToString() + "'>" + _dtSagUst.Rows[i]["Baslik"].ToString() + "</a></p><span>" + _dtSagUst.Rows[i]["Haber"].ToString() + "</span>");
    }
     %></marquee>
  </div>
  </div>

</div>
            </td>
        </tr>
    </table>
    </div>

<div>
<%
    for (int i = 0; i < _dtKampanya.Rows.Count; i++)
    {
        Response.Write("<a href='Kampanya.aspx?MercanYaziliM=" + _dtKampanya.Rows[i]["idKampanya"].ToString() + "'><img alt='" + _dtKampanya.Rows[i]["Baslik"].ToString() + "' class='style4' src='" + _dtKampanya.Rows[i]["Resim"].ToString() + "' /></a>");
        if (i==2)
        {
            break; 
        }
    }
     %>
<%--    <img alt="" class="style3" src="images/kampanya1.gif" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <img alt="" class="style4" src="images/kampanya2.jpg" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <img alt="" class="style5" src="images/kampanya2.png" />--%></div>
<div id="content_body">


<div id="home_news_box">

<div class="headers">
	Tamamlanan Projelerimiz
</div>

<%
    for (int i = 0; i < _dtAltSol.Rows.Count; i++)
    {
        Response.Write("<div class='news_boxes'><div class='home_news_img'><a target='_blank' href='" + _dtAltSol.Rows[i]["Url"].ToString() + "'><img src='images/news_1.jpg'/></a>"
+ "</div><div><p class='news_head'><a class='news_head' target='_blank' href='" + _dtAltSol.Rows[i]["Url"].ToString() + "'>" + _dtAltSol.Rows[i]["ReferansAdi"].ToString() + "</a></p>"
+ "<p>" + _dtAltSol.Rows[i]["Aciklama"].ToString() + "</p>"
+ "</div></div>");
    }
     %>

</div>
<div id="home_middle_part">

<div id="testi_home">

<div class="headers">
	Hosting Hizmetleri
</div>

  <div class="testi_box">
      <a href="Paket.aspx?MercanYaziliM=1"><img src="images/windowswebhosting.png" /></a><br />
     <a href="Paket.aspx?MercanYaziliM=2"> <img src="images/linuxwebhosting.png" /></a><br />
      <img src="images/emailhosting.png" /></div>
  <br />
  <div id="testi_home">
  <div class="headers">
	Mercan Yazılım
</div>

  <div class="testi_box">
      <img src="images/ok.png" />&nbsp; 
      <asp:HyperLink ID="HyperLink1" runat="server" 
          CssClass="shows_head" NavigateUrl="WebTasarimForm.aspx">Web Tasarım Talep Formu</asp:HyperLink>
      <br /><img src="images/ok.png" />&nbsp;
      <asp:HyperLink ID="HyperLink2" runat="server" 
          CssClass="shows_head" NavigateUrl="Odeme.aspx">Ödeme Bildirim Formu</asp:HyperLink>
      <br /><img src="images/ok.png" />&nbsp;
      <asp:HyperLink ID="HyperLink3" runat="server" 
          CssClass="shows_head" NavigateUrl="Banka.aspx">Banka Hesaplarımız</asp:HyperLink>
                          <br /><img src="images/ok.png" />&nbsp;
      <asp:HyperLink ID="HyperLink5" runat="server" 
          CssClass="shows_head" NavigateUrl="SSS.aspx">Sık Sorulan Sorular</asp:HyperLink>
      <br /><img src="images/ok.png" />&nbsp;
      <asp:HyperLink ID="HyperLink4" runat="server" 
          CssClass="shows_head" NavigateUrl="iletisim.aspx">Irtibat Formu</asp:HyperLink>
</div>
  </div></div>


</div>
<!-- Home Social & Newsletter Part Starts here -->


<!-- Home Right Box Starts here -->
<div id="home_right_box">

<!-- Clients Starts Here -->
<!-- Headers Starts Here -->
<div class="headers">
	Ürünlerimiz
</div>
<!-- Headers Ends Here -->

<div class="clients">
<%
    for (int i = 0; i < _dtUrunGoster.Rows.Count; i++)
    {
        Response.Write("<a href='Urun.aspx?MercanYaziliM=" + _dtUrunGoster.Rows[i]["idUrun"].ToString() + "'>" + _dtUrunGoster.Rows[i]["UrunAdi"].ToString() + "</a><br><img src='" + _dtUrunGoster.Rows[i]["KResim"].ToString() + "'></img>");
    }
     %>
<div class="read_more">
<a href="Yazilim.aspx">Daha Fazlası..</a>
</div>




</div>
<!-- Clients Ends Here -->


</div>
<!-- Home Right Box Ends Here -->


</div>

<!-- Clear -->
<div class="clear">
</div>
<!-- Clear -->

<!-- Content Body Ends Here -->

<!--Footer Starts Here -->
<div id="footer">
<div class="left">
<div class="footer_links" ><a  href="Default2.aspx">AnaSayfa</a> &nbsp;| &nbsp;<a  href="Hizmetler.aspx">Hizmetler</a> 
	&nbsp;| &nbsp;<a  href="Urun.aspx">Ürünler</a> &nbsp;| &nbsp;<a  href="Hosting.aspx">Hosting</a> &nbsp;| &nbsp;<a  href="iletisim.aspx">İletişim</a></div></div>

<div class="right" style="padding-right:30px;"><%Response.Write(_StrPageFooter.ToString()); %></div>

</div>
<!-- Footer Ends Here -->


</div>
<!-- Main Body Ends Here -->

    </form>

 </body>
</html>