<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="Siparis.aspx.cs" Inherits="Siparis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content_body">
        <div id="home_news_box">
<!-- Headers Starts Here -->
            <div class="headers">
	Hosting Sipariş Formu 
                                /&nbsp; 
                                <asp:Label ID="_lblHostingAdi" runat="server" Font-Bold="True" 
                    Font-Size="Small"></asp:Label>
            </div>
<!-- Headers Ends Here -->

<!-- News Starts Here -->

<!-- Box1 Starts Here -->
            <div class="news_boxes">
                
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 165px">
                                <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Paketiniz :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="_lblPaketAdi" runat="server" Font-Bold="True" Font-Size="Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 165px">
                                <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Adınız : "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="headers"></asp:TextBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 165px">
                                <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Soyadınız : "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="headers"></asp:TextBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 165px">
                                <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Telefon : "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="headers"></asp:TextBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 165px">
                                <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="E-Mailiniz : "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="headers"></asp:TextBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 165px">
                                <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Domain : "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" CssClass="headers">www.</asp:TextBox>
                                <br />
                            </td>
                        </tr>
                        </table>


            </div>
<!-- Box1 Ends Here -->

<!-- Box2 Starts Here -->
<div class="news_boxes">
                
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 165px">
                                <asp:Button ID="Button2" runat="server" Text="Siparişi Tamamla" 
                                        CssClass="headers" Height="27px" Width="134px" onclick="Button2_Click" />
                                </td>
                            <td>
                                
                                    <asp:Button ID="Button3" runat="server" Text="İptal Et" CssClass="headers" 
                                        Height="27px" onclick="Button3_Click" Width="74px" />
                                
                            </td>
                        </tr>
                </table>


            </div>


<!-- Box5 Ends Here -->

<!-- News Ends Here -->
        </div>
<!-- Home News Ends Here -->


<!-- Home Social & Newsletter Part Starts here -->
        <div id="home_middle_part">
<!-- Testimonial Starts Here -->
            <div id="testi_home">
<!-- Headers Starts Here -->
                <div class="headers">
                Siparişiniz
                </div>
<!-- Headers Ends Here -->

                <div class="testi_box">
                    <table style="width: 94%; height: 249px;">
                        <tr>
                            <td style="width: 118px">
                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Paket Adı :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 118px">
                                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Web Alan :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
                            &nbsp;MB</td>
                        </tr>
                        <tr>
                            <td style="width: 118px">
                                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Trafik :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                            &nbsp;MB</td>
                        </tr>
                        <tr>
                            <td style="width: 118px">
                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="VeriTabanı :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                            &nbsp;Adet</td>
                        </tr>
                        <tr>
                            <td style="width: 118px">
                                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="SubDomain :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
                            &nbsp;Adet</td>
                        </tr>
                        <tr>
                            <td style="width: 118px">
                                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="E-Mail :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                            &nbsp;Adet</td>
                        </tr>
                        <tr>
                            <td style="width: 118px">
                                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Aylık Fiyat :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                            &nbsp; TL</td>
                        </tr>
                        <tr>
                            <td style="width: 118px">
                                <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Yıllık Fiyat :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
                            &nbsp; TL</td>
                        </tr>
                        </table>
                </div>
            </div>
  <!-- Testimonial Ends Here -->
  
  <!-- News Letter Starts Here -->
            <div id="newsletter_box">
&nbsp;</div>
<!-- NewsLetter Ends Here -->

<!-- Social Starts Here -->
            <div id="social_bookmark_box">
&nbsp;&nbsp;
            </div>
<!-- Social Ends Here -->


        </div>
<!-- Home Social & Newsletter Part Starts here -->


<!-- Home Right Box Starts here -->
        <div id="home_right_box">

<!-- Clients Starts Here -->
<!-- Headers Starts Here -->
            <div class="headers">
	Hosting Seçenekleri
            </div>
<!-- Headers Ends Here -->

            <div class="clients">

<!-- Client1 -->
                <%
    for (int i = 0; i < _dtMenu.Rows.Count; i++)
    {
        Response.Write("<br><li><a href='Paket.aspx?MercanYaziliM=" + Convert.ToInt32(_dtMenu.Rows[i]["idHostingTur"]) + "'>" + _dtMenu.Rows[i]["TurAdi"].ToString() + "</li>");
    }
    
     %>
                </div>

        </div>
    </div>
</asp:Content>

