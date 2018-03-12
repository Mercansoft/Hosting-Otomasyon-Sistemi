<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici/Admin.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Yonetici_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="infowrap0">
        <div id="infobox0" class="margin-left">
            <p>
                
            </p>
        </div>
        <div id="infobox1">
        </div>
        <div id="infobox3">
            <h3>
                <a href="MesajOku.aspx?tum=Siparis">Siparişler</a></h3>
            <table>
                <thead>
                    <tr>
                        <th style="width: 127px">
                            Adı Soyadı</th>
                        <th style="width: 139px">
                            Alan Adı</th>
                        <th style="width: 116px">
                            Paket Adı</th>
                        <th style="width: 110px">
                            Mail</th>
                            <th style="width: 130px">
                                E-Tarih</th>
                            <th>
                                Onay</th>
                    </tr>
                </thead>
                <tbody>
<%
    for (int i = 0; i < _dtSiparis.Rows.Count; i++)
    {
        Response.Write("<tr><td style='width: 127px'><a href='MesajOku.aspx?id="+_dtSiparis.Rows[i]["idSiparis"].ToString()+"&Type=Siparis'>" + _dtSiparis.Rows[i]["Ad"].ToString() + " " + _dtSiparis.Rows[i]["Soyad"].ToString() + "</td><td style='width: 139px'>" + _dtSiparis.Rows[i]["Domain"].ToString() + "</a></td><td style='width: 116px'>" + _dtSiparis.Rows[i]["idPaket"].ToString() + "</td>"
            + "<td style='width: 110px'>" + _dtSiparis.Rows[i]["Email"].ToString() + "</td><td style='width: 130px'>" + _dtSiparis.Rows[i]["Tarih"].ToString() + "</td><td><a href='SiparisOnay.aspx?MercaNYaziliM=" + _dtSiparis.Rows[i]["idSiparis"].ToString() + "'>Onayla</a></td></tr>");
    }
     %>
                </tbody>
            </table>
        </div>
        <div id="infobox4" class="margin-left">
            <h3>
                <a href="MesajOku.aspx?tum=Mesaj">İrtibat Mesajları</a></h3>
            <table>
                <thead>
                    <tr>
                        <th>
                            Konu</th>
                        <th>
                            Gönderen</th>
                        <th>
                            E-Mail</th>
                            <th>
                            Tarih</th>
                    </tr>
                </thead>
                <tbody>
<%
    for (int i = 0; i < _dtMesaj.Rows.Count; i++)
    {
        Response.Write("<tr><td><a href='MesajOku.aspx?id=" + _dtMesaj.Rows[i]["idiletisim"].ToString() + "&Type=Mesaj'>" + _dtMesaj.Rows[i]["Konu"].ToString() + "</td><td>" + _dtMesaj.Rows[i]["Ad"].ToString() + " " + _dtMesaj.Rows[i]["Soyad"].ToString() + "</td><td>" + _dtMesaj.Rows[i]["Email"].ToString() + "</td><td>" + _dtMesaj.Rows[i]["Tarih"].ToString() + "</a></td></tr>");
    }
    //Response.Write(_BResim.ToString());
     %>
                </tbody>
            </table>
        </div>
        <div id="Div1" class="margin-left">
            <h3>
                <a href="MesajOku.aspx?tum=Odeme">Ödeme Bildirimleri</a></h3>
            <table>
                <thead>
                    <tr>
                        <th>
                            Konu</th>
                        <th>
                            Gönderen</th>
                        <th>
                            E-Mail</th>
                            <th>
                            Tarih</th>
                    </tr>
                </thead>
                <tbody>
<%
    for (int i = 0; i < _dtOdeme.Rows.Count; i++)
    {
        Response.Write("<tr><td><a href='MesajOku.aspx?id=" + _dtOdeme.Rows[i]["idOdeme"].ToString() + "&Type=Odeme'>" + _dtOdeme.Rows[i]["Konu"].ToString() + "</td><td>" + _dtOdeme.Rows[i]["AdSoyad"].ToString() + "</td><td>" + _dtOdeme.Rows[i]["Email"].ToString() + "</td><td>" + _dtOdeme.Rows[i]["Tarih"].ToString() + "</a></td></tr>");
    }
    //Response.Write(_BResim.ToString());
     %>
                </tbody>
            </table>
        </div>
        <div id="Div2" class="margin-left">
            <h3>
                <a href="MesajOku.aspx?tum=WebTasarim">WebTasarım Talep Bildirimleri</a></h3>
            <table>
                <thead>
                    <tr>
                        <th>
                            Firma Adı</th>
                        <th>
                            Yetkili Adı</th>
                        <th>
                            E-Mail</th>
                            <th>
                            Tarih</th>
                    </tr>
                </thead>
                <tbody>
<%
    for (int i = 0; i < _dtWebTasarim.Rows.Count; i++)
    {
        Response.Write("<tr><td><a href='MesajOku.aspx?id=" + _dtWebTasarim.Rows[i]["idWebTasarimForm"].ToString() + "&Type=WebTasarim'>" + _dtWebTasarim.Rows[i]["FirmaAdi"].ToString() + "</td><td>" + _dtWebTasarim.Rows[i]["YetkiliAdi"].ToString() + "</td><td>" + _dtWebTasarim.Rows[i]["Email"].ToString() + "</td><td>" + _dtWebTasarim.Rows[i]["Tarih"].ToString() + "</a></td></tr>");
    }
    //Response.Write(_BResim.ToString());
     %>
                </tbody>
            </table>
        </div>
        <div id="Div3" class="margin-left">
            <h3>
                <a href="MesajOku.aspx?tum=Kampanya">Kampanya Siparişleri</a></h3>
            <table>
                <thead>
                    <tr>
                        <th style="width: 186px">
                            Kampanya Adı</th>
                        <th>
                            Gönderen</th>
                        <th>
                            E-Mail</th>
                            <th>
                            Tarih</th>
                    </tr>
                </thead>
                <tbody>
<%
    for (int i = 0; i < _dtKampanya.Rows.Count; i++)
    {
        Response.Write("<tr><td><a href='MesajOku.aspx?id=" + _dtKampanya.Rows[i]["idKampanyaForm"].ToString() + "&Type=Kampanya'>" + _dtKampanya.Rows[i]["KampanyaAdi"].ToString() + "</td><td>" + _dtKampanya.Rows[i]["Ad"].ToString() + " " + _dtKampanya.Rows[i]["Soyad"].ToString() + "</td><td>" + _dtKampanya.Rows[i]["Email"].ToString() + "</td><td>" + _dtKampanya.Rows[i]["Tarih"].ToString() + "</a></td></tr>");
    }
    //Response.Write(_BResim.ToString());
     %>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>

