<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici/Admin.master" AutoEventWireup="true" CodeFile="Urunler.aspx.cs" Inherits="Yonetici_Urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 382px">
                  <div id="infobox">
                    <h3>Urun Düzenle</h3>
                    <table>
						<thead>
							<tr>
                            	<th style="width: 135px">Ürün Bilgileri</th>
                                <th style="width: 150px">Ürün Değerleri</th>
                            </tr>
						</thead>
						<tbody>
							<tr>
                            	<td style="width: 135px"><a href="#">Ürün Adı</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                            </tr>
							<tr>
                            	<td style="width: 135px"><a href="#">Küçük Resim Adres</a></td>
                            	<td style="width: 150px">
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                </td>
                            </tr>
							<tr>
                            	<td style="width: 135px"><a href="#">Büyük Resim Adres</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                </td>
                            </tr>
							<tr>
                            	<td style="width: 135px"><a href="#">Açıklama</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox4" runat="server" Height="99px" TextMode="MultiLine" 
                                        Width="204px"></asp:TextBox>
                               
                            </tr>
                            <tr>
                            	<td style="width: 135px">Resim Ekle</td>
                                <td style="width: 150px">
                                    <asp:FileUpload ID="FileUpload1" runat="server" />
                                    <asp:Button ID="Button7" runat="server" onclick="Button7_Click" Text="Yükle" />
                               
                            </tr>
                            <tr>
                            	<td style="width: 135px">
                                    <asp:Label ID="_lblMesaj" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                                </td>
                                <td style="width: 190px">
                                    <asp:Button ID="Button1" runat="server" Text="Düzenle" 
                                        onclick="Button1_Click" Width="56px" />
                                    <asp:Button ID="Button3" runat="server" Text="Kayit" onclick="Button3_Click" 
                                        Height="29px" Width="39px" />
                                    
                                    &nbsp;<asp:Button ID="Button5" runat="server" Text="[Kaydet]" Height="29px" 
                                        Width="57px" onclick="Button5_Click" />
                                    
                                </td>
                                
                            </tr>
						</tbody>
					</table>            
                  </div>
                  </td>
            <td>
                  <div id="infobox" class="margin-left">
                  <h3>Urun Listesi</h3>
                    <table>
						<thead>
						</thead>
						<tbody>
							<tr>
                            	<td style="height: 22px; width: 353px;">
                                    <asp:ListBox ID="ListBox1" runat="server" Height="220px" Width="235px">
                                    </asp:ListBox>
                                    <asp:Button ID="Button6" runat="server" Height="19px" onclick="Button6_Click" 
                                        Text="Sil" Width="37px" />
                                </td>
                            </tr>
						</tbody>
					</table>
                  </div>
                  </td>
        </tr>
    </table>
</asp:Content>

