<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="Odeme.aspx.cs" Inherits="Odeme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div id="inner_content_body">

<!-- Left Content Body Starts Here -->
        <div class="left_content_body">

<!-- Heading -->
<!-- Heading -->

   <table style="width: 100%">
                <tr>
                    <td style="width: 263px">
                        <asp:ImageMap ID="ImageMap1" runat="server" Height="250px" Width="250px" 
                            ImageUrl="~/images/MercanYazilimOdemeMail.png">
                        </asp:ImageMap>
                        <br />
&nbsp;<asp:Label ID="Label9" runat="server"></asp:Label>
                    </td>
                    <td>
                        <table style="width: 100%">
                            <tr>
                                <td style="width: 123px">
                                    <asp:Label ID="Label1" runat="server" Text="Ad Soyad :" Font-Bold="True" 
                                        Font-Size="Medium"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="headers"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 123px">
                                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="E-Mail :"></asp:Label>
                                    </td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="headers"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 123px">
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Telefon :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" CssClass="headers"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 123px">
                                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Banka Adı :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" CssClass="headers"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 123px">
                                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Ödenen Miktar :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server" CssClass="headers"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 123px">
                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Konu :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server" CssClass="headers"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 123px">
                                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Açıklama :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server" CssClass="headers" Height="169px" 
                                        TextMode="MultiLine" Width="242px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 123px; height: 21px">
                                    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                                </td>
                                <td style="height: 21px">
                                    <asp:Button ID="Button1" runat="server" CssClass="headers" Text="Gönder" 
                                        Height="32px" onclick="Button1_Click" />
                                    <asp:Button ID="Button2" runat="server" CssClass="headers" Text="Temizle" 
                                        Height="33px" onclick="Button2_Click" />
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

