<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici/Admin.master" AutoEventWireup="true" CodeFile="Ayar.aspx.cs" Inherits="Yonetici_Ayar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 316px">
                    <table>
                        <thead>
                            <tr>
                                <th style="width: 135px">
                                    Yönetici Bilgileri</th>
                                <th style="width: 150px">
                                    </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Kullanıcı Adı</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Şifre</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
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
                                    <asp:Button ID="_btnYoneticiKaydet" runat="server" Text="[Kaydet]" 
                                        onclick="_btnYoneticiKaydet_Click"  />
                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table>
                        <thead>
                            <tr>
                                <th style="width: 135px">
                                    Yönetici Listesi</th>
                                <th style="width: 150px">
                                    </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="width: 135px">
                                    &nbsp;</td>
                                <td style="width: 150px">
                                    <asp:ListBox ID="ListBox1" runat="server" Width="173px"></asp:ListBox>
                                </tr>
                            <tr>
                                <td style="width: 135px">
                                    <asp:Label ID="_lblMesaj3" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                                </td>
                                <td style="width: 190px">
                                    <asp:Button ID="Button15" runat="server" Text="Düzenle" 
                                        onclick="Button15_Click"  />
                                    &nbsp;<asp:Button ID="_btnYoneticiKaydet0" runat="server" Text="Kayit" 
                                        onclick="_btnYoneticiKaydet0_Click"  />
                                    
                                &nbsp;<asp:Button ID="Button16" runat="server" Text="Sil" onclick="Button3_Click" />
                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            <td>
                    <table>
                        <thead>
                            <tr>
                                <th style="width: 135px">
                                    Menüler</th>
                                <th style="width: 150px">
                                    &nbsp;</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Menü Adı</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Menü Url</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    &nbsp;</td>
                                <td style="width: 150px">
                                    &nbsp;</tr>
                            <tr>
                                <td style="width: 135px">
                                    <asp:Label ID="_lblMesaj0" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                                </td>
                                <td style="width: 190px">
                                    <asp:Button ID="_btnMenuKaydet" runat="server" Text="[Kaydet]" 
                                        onclick="_btnMenuKaydet_Click" />
                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <table>
                        <thead>
                            <tr>
                                <th style="width: 135px">
                                    Menüler</th>
                                <th style="width: 150px">
                                    &nbsp;</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="width: 135px">
                                    &nbsp;</td>
                                <td style="width: 150px">
                                    <asp:ListBox ID="ListBox2" runat="server" Width="196px"></asp:ListBox>
                                </tr>
                            <tr>
                                <td style="width: 135px">
                                    <asp:Label ID="_lblMesaj4" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                                </td>
                                <td style="width: 190px">
                                    <asp:Button ID="Button18" runat="server" Text="Düzenle" 
                                        onclick="Button18_Click" Width="56px"  />
                                    &nbsp;<asp:Button ID="Button20" runat="server" Text="Kayit" 
                                        onclick="Button20_Click"  />
                                    &nbsp;<asp:Button ID="Button19" runat="server" Text="Sil" onclick="Button19_Click"/>
                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
        </tr>
        <tr>
            <td style="width: 316px">
                    <table>
                        <thead>
                            <tr>
                                <th style="width: 135px">
                                    Paket Bilgileri</th>
                                <th style="width: 150px">
                                    Paket Değerleri</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Oaket Adı</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Paket Resim</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Web Alan</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox31" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Trafik</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox32" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Database</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    SubDomain</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox34" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    E-Mail</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox35" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Paket Türü</td>
                                <td style="width: 150px">
                                    <asp:DropDownList ID="DropDownList4" runat="server" Height="22px" Width="155px">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Aylık Fiyat</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox36" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Yıllık Fiyat</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox37" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    &nbsp;</td>
                                <td style="width: 150px">
                                    &nbsp;</tr>
                            <tr>
                                <td style="width: 135px">
                                    <asp:Label ID="_lblMesaj2" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                                </td>
                                <td style="width: 190px">
                                    <asp:Button ID="Button12" runat="server" Text="Düzenle"  />
                                    <asp:Button ID="Button13" runat="server" Text="Kaydet" />
                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            <td>
                    <table>
                        <thead>
                            <tr>
                                <th style="width: 135px">
                                    Site Ayarları</th>
                                <th style="width: 150px">
                                    &nbsp;</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Page T</a>itle</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Page Footer</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    <a href="#">Email</a></td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Telefon</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Ad/Soyad</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Meta Keywords</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    Meta Description</td>
                                <td style="width: 150px">
                                    <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 135px">
                                    &nbsp;</td>
                                <td style="width: 150px">
                                    &nbsp;</tr>
                            <tr>
                                <td style="width: 135px">
                                    <asp:Label ID="_lblMesaj1" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                                </td>
                                <td style="width: 190px">
                                    <asp:Button ID="_btnAyarKaydet" runat="server" Text="Güncelle" 
                                        onclick="_btnAyarKaydet_Click" />
                                    
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
        </tr>
    </table>
</asp:Content>

