<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 193px">
                <img width="200" src="images/Windows_Live_Messenger_Logo.png" /><br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td style="width: 528px">
    <table style="width: 466px">
        <tr>
            <td style="width: 304px">
                <asp:Label ID="Label1" runat="server" Text="Adınız :" ForeColor=White 
                    Font-Bold=True></asp:Label>
            </td>
            <td style="width: 354px">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="headers"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 304px">
                <asp:Label ID="Label2" runat="server" Text="Soyadınız :" ForeColor=White 
                    Font-Bold=True></asp:Label>
            </td>
            <td style="width: 354px">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="headers"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 304px">
                <asp:Label ID="Label3" runat="server" Text="Mail Adresiniz :" ForeColor=White 
                    Font-Bold=True></asp:Label>
            </td>
            <td style="width: 354px">
                <asp:TextBox ID="TextBox3" runat="server" CssClass="headers"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 304px">
                <asp:Label ID="Label4" runat="server" Text="Konu :" ForeColor=White 
                    Font-Bold=True></asp:Label>
            </td>
            <td style="width: 354px">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="headers"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 304px">
                <asp:Label ID="Label5" runat="server" Text="Açıklama :" ForeColor=White 
                    Font-Bold=True></asp:Label>
            &nbsp;&nbsp;&nbsp;
            </td>
            <td style="width: 354px">
                <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" Height="91px" 
                    Width="313px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 304px">
                &nbsp;</td>
            <td style="width: 354px">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Gönder" 
                    CssClass="headers" Height="26px" />
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Temizle" CssClass="headers" Height="26px" />
            </td>
        </tr>
        <tr>
            <td style="width: 304px">
                &nbsp;</td>
            <td style="width: 354px">
                <asp:Label ID="Label6" runat="server" ForeColor=Red 
                    Font-Bold=True></asp:Label>
            </td>
        </tr>
    </table>
            </td>
            <td>
<div class="right_content_body">

<!-- More Links Starts here -->
<!-- Heading -->
<p class="page_sub_title">
    Mercan YazılıM</p>
<!-- Heading -->

<div class="more_links">
<ul>
<li><a href="Paket.aspx">Ödeme Bildirim Formu</a></li>
<li><a href="Paket.aspx">İrtibat Formu</a></li>
<li><a href="Paket.aspx">Sık Sorulan Sorular</a></li>
<li><a href="Paket.aspx">Hesap Numaralarımız</a></li>
</ul>
</div>

<!-- More Links Ends Here -->

</div>
<div class="right_content_body">

<!-- More Links Starts here -->
<!-- Heading -->
<p class="page_sub_title">
    İletişim Numaraları</p>
<!-- Heading -->

<div class="more_links">
<ul>
<li><a href="Paket.aspx">0534-371-66-61</a></li>
<li><a href="Paket.aspx">-</a></li>
<li><a href="Paket.aspx">-</a></li>
<li><a href="Paket.aspx">-</a></li>
</ul>
</div>

<!-- More Links Ends Here -->

</div>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

