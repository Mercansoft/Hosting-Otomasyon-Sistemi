<%@ Page Title="" Language="C#" MasterPageFile="~/Yonetici/Admin.master" AutoEventWireup="true" CodeFile="Siparis.aspx.cs" Inherits="Yonetici_Siparis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="box">
        <h3>
            Siparişler</h3>
        <table width="100%">
            <thead>
                <tr>
                    <th width="40px">
                        <a href="#">ID<img src="img/icons/arrow_down_mini.gif" 
                            width="16" height="16" align="absmiddle" /></a></th>
                    <th style="width: 70px">
                        <a href="#">Ad/Soyad</a></th>
                    <th style="width: 60px">
                        <a href="#">Paket</a></th>
                    <th width="100px">
                        <a href="#">Domain</a></th>
                    <th width="90px">
                        <a href="#">Email</a></th>
                    <th width="60px">
                        <a href="#">Telefon</a></th>
                    <th width="100px">
                        <a href="#">Tarih</a></th>
                </tr>
            </thead>
            <tbody>
<%
    for (int i = 0; i < _dtSiparis.Rows.Count; i++)
{
    Response.Write("<tr><td class='a-center'>" + _dtSiparis.Rows[i]["Siparis.idSiparis"].ToString() + "</td><td style='width: 90px'><a href='#'>" + _dtSiparis.Rows[i]["Siparis.Ad"].ToString() + "-" + _dtSiparis.Rows[i]["Siparis.Soyad"].ToString() + "</a></td>"
        + "<td style='width: 135px'>" + _dtSiparis.Rows[i]["Paket.PaketAdi"].ToString() + "</td><td>" + _dtSiparis.Rows[i]["Siparis.Domain"].ToString() + "</td><td>" + _dtSiparis.Rows[i]["Siparis.Email"].ToString() + "</td>"
            + "<td>" + _dtSiparis.Rows[i]["Siparis.Telefon"].ToString() + "</td><td>" + _dtSiparis.Rows[i]["Siparis.Tarih"].ToString() + "</td></tr>");
    }
     %>
            </tbody>
        </table>
        <div id="pager">
                    	Page <a href="#">
            <img src="img/icons/arrow_left.gif" width="16" height="16" /></a>
            <input size="1" value="1" type="text" name="page" id="page" /> <a href="#">
            <img src="img/icons/arrow_right.gif" width="16" height="16" /></a>of 42
                    pages | View 
            <select name="view">
                <option>10</option>
                <option>20</option>
                <option>50</option>
                <option>100</option>
            </select> 
                    per page | Total <strong>420</strong> records found
                    </div>
    </div>
</asp:Content>

