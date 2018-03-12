<%@ Page Title="" Language="C#" MasterPageFile="~/MercanPage.master" AutoEventWireup="true" CodeFile="WebTasarimForm.aspx.cs" Inherits="WebTasarimForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="inner_content_body">

<!-- Left Content Body Starts Here -->
        <div class="left_content_body">

<!-- Heading -->
<!-- Heading -->

            <table style="width: 100%">
                <tr>
                    
                    <td>
                        <table style="width: 97%">
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label1" runat="server" Text="Firma Adı :" Font-Bold="True" 
                                        Font-Size="Medium"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="headers"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Yetkili Adı :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="headers"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Telefon :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server" CssClass="headers"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Email :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" CssClass="headers"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Adres :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox5" runat="server" CssClass="headers" Height="62px" 
                                        TextMode="MultiLine" Width="233px"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Domain Adınız "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server" CssClass="headers">www.</asp:TextBox>
                                    &nbsp;
                                    <asp:ImageButton ID="ImageButton1" runat="server" 
                                        ImageUrl="~/images/close.png" onclick="ImageButton1_Click" 
                                        ToolTip="Domainınız Varsa Buraya Tıklayarak İptal Ediniz" />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Hosting Seçiniz :"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="headers" 
                                        Height="34px" Width="161px">
                                    </asp:DropDownList>
                                    &nbsp;<asp:ImageButton ID="ImageButton2" runat="server" 
                                        ImageUrl="~/images/close.png" onclick="ImageButton2_Click" 
                                        ToolTip="Hostinginiz Varsa Buraya Tıklayarak İptal Ediniz" />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Web Sitenizi hangi sıklıkla güncellemek istersiniz "></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="headers" 
                                        Height="28px" Width="161px">
                                    </asp:DropDownList>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Web Sitesi yaptırmanızdaki amaç ?"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList3" runat="server" CssClass="headers" 
                                        Height="28px" Width="161px">
                                    </asp:DropDownList>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Size nasıl ulaşmamızı istersiniz ?"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="DropDownList4" runat="server" CssClass="headers" 
                                        Height="28px" Width="161px">
                                    </asp:DropDownList>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Lütfen tasarım projeniz ile ilgili ayrıntılı açıklama giriniz "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server" CssClass="headers" Height="62px" 
                                        TextMode="MultiLine" Width="233px"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Lütfen Beğendiğiniz Web Sitelerin Adreslerini Yazınız:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox8" runat="server" CssClass="headers" Height="62px" 
                                        TextMode="MultiLine" Width="233px"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Sormak veya Söylemek İstediğiniz Başka Konu Varsa Yazınız :"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox10" runat="server" CssClass="headers" Height="62px" 
                                        TextMode="MultiLine" Width="233px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="Medium" 
                                        Text="Web Tasarım Bütçenizi Yazınız:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="TextBox9" runat="server" CssClass="headers"></asp:TextBox>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px">
                                    &nbsp;</td>
                                <td>
                                    <asp:Button ID="Button1" runat="server" Text="Gönder" CssClass="headers" 
                                        Height="30px" onclick="Button1_Click" />
                                    <asp:Button ID="Button2" runat="server" Text="İptal Et" CssClass="headers" 
                                        Height="30px" />
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 388px; height: 21px">
                                    <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                                </td>
                                <td style="height: 21px">
                                    &nbsp;</td>
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

