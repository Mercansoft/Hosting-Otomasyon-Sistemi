<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici/Admin.master" AutoEventWireup="true" CodeFile="Yazilim.aspx.cs" Inherits="Yonetici_Yazilim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 382px">
                <div id="infobox">
                    <h3>
                        Yazılım Düzenle</h3>
                    <table>
                        <thead>
                            <tr>
                                <th style="width: 135px">
                                    Yazılım Bilgileri</th>
                                <th style="width: 150px">
                                    Yazılım Değerleri</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="width: 135px">
                                    Yazılım Türü</td>
                                <td style="width: 150px">
                                    <asp:DropDownList ID="DropDownList1" runat="server" Height="23px" Width="197px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Yazilim Adı</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="197px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Resim</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="197px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Download Link</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox5" runat="server" Height="22px" Width="197px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Hit</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox6" runat="server" Height="22px" Width="197px"></asp:TextBox>
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
                                        onclick="Button1_Click" Width="65px" />
                                <asp:Button ID="Button4" runat="server" Text="Kayit" onclick="Button4_Click" />
                                    &nbsp;<asp:Button ID="Button3" runat="server" Text="[Kaydet]" 
                                        onclick="Button3_Click" />
                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </td>
            <td>
                <div id="infobox0" class="margin-left">
                    <h3>
                        Yazılım Listesi</h3>
                    <table>
                        <thead>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="height: 22px; width: 353px;">
                                    <asp:ListBox ID="ListBox1" runat="server" Height="320px" Width="292px">
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

