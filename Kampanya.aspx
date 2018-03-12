<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="Kampanya.aspx.cs" Inherits="Kampanya" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div id="content_body">
        <div id="home_news_box">
<!-- Headers Starts Here -->
            <div class="headers">
	            Kampanya Sipariş Formu 
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
                                <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Size="Small" 
                                        Text="Açıklama/Sorunuz : "></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" CssClass="headers" Height="74px" 
                                    TextMode="MultiLine" Width="215px"></asp:TextBox>
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 165px">
                                <asp:Label ID="_lblDurum" runat="server" Font-Bold="True" Font-Size="Small" 
                                    ForeColor="Red"></asp:Label>
                            </td>
                            <td>
                                &nbsp;</td>
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
                                        CssClass="headers" Height="27px" Width="134px" 
                                    onclick="Button2_Click"/>
                                </td>
                            <td>
                                
                                    <asp:Button ID="Button3" runat="server" Text="İptal Et" CssClass="headers" 
                                        Height="27px" Width="74px" onclick="Button3_Click" />
                                
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
                Kampanya Paketiniz
                </div>
<!-- Headers Ends Here -->

                <div class="testi_box">
                    <table style="width: 94%; height: 137px;">
                        <tr>
                            <td style="width: 118px; height: 26px;">
                                <strong>Kampanya Adı :</strong></td>
                            <td style="height: 26px">
                                <asp:Label ID="_lblAdi" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 118px; height: 23px;">
                                <strong>Fiyat :</strong></td>
                            <td style="height: 23px">
                                <asp:Label ID="_lblFiyat" runat="server"></asp:Label>
&nbsp; TL</td>
                        </tr>
                        <tr>
                            <td style="width: 118px; height: 28px;">
                                <strong>Detay :</strong></td>
                            <td style="height: 28px">
                                </td>
                        </tr>
                        <tr>
                            <td style="height: 111px;" colspan="2">
                                <asp:Label ID="_lblDetay" runat="server"></asp:Label>
                            </td>
                        </tr>
                        </table>
                </div>
            </div>
  <!-- Testimonial Ends Here -->
  
  <!-- News Letter Starts Here -->
<!-- NewsLetter Ends Here -->

<!-- Social Starts Here -->
<!-- Social Ends Here -->


        </div>
<!-- Home Social & Newsletter Part Starts here -->


<!-- Home Right Box Starts here -->
        <div id="home_right_box">

<!-- Clients Starts Here -->
<!-- Headers Starts Here -->
            <div class="headers">
	            Kampanya Seçenekleri
            </div>
<!-- Headers Ends Here -->

            <div class="clients">

<!-- Client1 -->
                <%
    for (int i = 0; i < _dtMenu.Rows.Count; i++)
    {
        Response.Write("<br><li><a href='Kampanya.aspx?MercanYaziliM=" + Convert.ToInt32(_dtMenu.Rows[i]["idKampanya"]) + "'>" + _dtMenu.Rows[i]["Baslik"].ToString() + "</li>");
    }
    
     %>
                </div>

        </div>
    </div>
    <p>
    </p>
    
</asp:Content>

