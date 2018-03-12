<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="Domain.aspx.cs" Inherits="Domain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    <div id="inner_content_body">

<!-- Left Content Body Starts Here -->
        <div class="left_content_body">

<!-- Heading -->
<!-- Heading -->

    <table style="width: 100%">
        <tr>
            <td style="width: 316px">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="www."></asp:Label>
                <asp:TextBox ID="txtDomain" runat="server" CssClass="headers" Height="29px" 
                    Width="177px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="headers" 
                    Height="29px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" CssClass="headers" Height="32px" 
                    onclick="Button1_Click" Text="Sorgula" />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblSonuc" runat="server" Font-Bold="True"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="txtResult" runat="server"></asp:Label>
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
MercaN YazılıM
            </p>
<!-- Heading -->

            <div class="more_links">
                <ul>
                <%
    for (int i = 0; i < _dtMenu.Rows.Count; i++)
    {
        Response.Write("<li><a href='Paket.aspx?MercanYaziliM=" + Convert.ToInt32(_dtMenu.Rows[i]["idHostingTur"]) + "'>" + _dtMenu.Rows[i]["TurAdi"].ToString() + "</li>");
    }
    
    
     %>
                    <li>|---------------------------------|</li>
                    <li><a href="Odeme.aspx">Ödeme Bildirim Formu</a></li>
                    <li><a href="SSS.aspx">Sık Sorulan Sorular</a></li>
                    <li><a href="WebTasarimForm.aspx">Web Tasarım Talep Formu</a></li>
                    <li><a href="Banka.aspx">Banka Hesaplarımız</a></li>
                    <li><a href="iletisim.aspx">Irtibat Formu</a></li>
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

