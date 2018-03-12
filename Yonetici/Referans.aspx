<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici/Admin.master" AutoEventWireup="true" CodeFile="Referans.aspx.cs" Inherits="Yonetici_Referans" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 382px">
                <div id="infobox">
                    <h3>
                        Referans Düzenle</h3>
                    <table>
                        <thead>
                            <tr>
                                <th style="width: 135px">
                                    Referans Bilgileri</th>
                                <th style="width: 150px">
                                    Referans Değerleri</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Referans Adı</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Adres</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Resim</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Açıklama</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox4" runat="server" Height="99px" TextMode="MultiLine" 
                                        Width="189px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    &nbsp;</td>
                                <td style="width: 150px">
                                    &nbsp;</tr>
                            <tr>
                                <td style="width: 135px">
                                    <asp:Label ID="_lblMesaj" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                                </td>
                                <td style="width: 190px">
                                    <asp:Button ID="Button1" runat="server" Text="Düzenle" 
                                        onclick="Button1_Click" Width="63px" />
                                <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Kayit" />
                                    &nbsp;<asp:Button ID="Button3" runat="server" Text="[Kaydet]" 
                                        onclick="Button3_Click" Width="64px" />
                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </td>
            <td>
                <div id="infobox0" class="margin-left">
                    <h3>
                        Referans Listesi</h3>
                    <table>
                        <thead>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="height: 22px; width: 353px;">
                                    <asp:ListBox ID="ListBox1" runat="server" Height="220px" Width="235px">
                                    </asp:ListBox>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>

