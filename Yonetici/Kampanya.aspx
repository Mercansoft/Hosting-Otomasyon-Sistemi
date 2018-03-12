<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici/Admin.master" AutoEventWireup="true" CodeFile="Kampanya.aspx.cs" Inherits="Yonetici_Kampanya" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 382px">
                <div id="infobox">
                    <h3>
                        Kampanya Düzenle</h3>
                    <table>
                        <thead>
                            <tr>
                                <th style="width: 135px">
                                    Kampanya Bilgileri</th>
                                <th style="width: 150px">
                                    Kampanya Değerleri</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Kampanya Başlık</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    &nbsp;Resim&nbsp;</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Url</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Fiyat</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Kampanya Açıklaması</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox4" runat="server" Height="99px" TextMode="MultiLine" 
                                        Width="189px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Tarih</td>
                                <td style="width: 150px">
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </tr>
                            <tr>
                                <td style="width: 135px">
                                    <asp:Label ID="_lblMesaj" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                                </td>
                                <td style="width: 190px">
                                    <asp:Button ID="Button1" runat="server" Text="Düzenle" 
                                         Height="27px" Width="52px" onclick="Button1_Click" />
                                    &nbsp;<asp:Button ID="Button5" runat="server" Text="Kayit" 
                                         Height="27px" Width="37px" onclick="Button5_Click" />
                                    &nbsp;<asp:Button ID="Button3" runat="server" Text="[Kaydet]" 
                                        Width="53px" onclick="Button3_Click" />
                                   
                                &nbsp;</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </td>
            <td>
                <div id="infobox0" class="margin-left">
                    <h3>
                        Kampanya Listesi</h3>
                    <table>
                        <thead>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="height: 22px; width: 353px;">
                                    <asp:ListBox ID="ListBox1" runat="server" Height="220px" Width="235px">
                                    </asp:ListBox>
                                    <asp:Button ID="Button6" runat="server" Text="Sil" 
                                         Height="27px" Width="40px" onclick="Button6_Click" />
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>

