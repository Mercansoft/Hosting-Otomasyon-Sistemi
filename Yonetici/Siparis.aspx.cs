using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Yonetici_Siparis : System.Web.UI.Page
{
    DataTable _dtUrun;
    DataTable _dtUrunDuzenle;
    public DataTable _dtSiparis;
    Data _sysData = new Data();
    private bool _blDuzenle;
    OleDbConnection _cnn;
    OleDbCommand _cmd;
    string Baglan = "Provider=Microsoft.jet.OLEDB.4.0; data source=" + HttpContext.Current.Server.MapPath("~/App_Data\\MercanYazilimDataBase.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["idYonetici"] == null)
        {
            Response.Redirect("Giris.aspx");
        }
        if (!Page.IsPostBack)
        {
            _fncSiparisGetir();
        }
    }
    private void _fncSiparisGetir()
    {
        _dtSiparis = new DataTable();
        _dtSiparis = _sysData._fncSelect("SELECT [Siparis.idSiparis],[Paket.PaketAdi],[Siparis.Domain],[Siparis.Ad],[Siparis.Soyad],[Siparis.Telefon],[Siparis.Email],[Siparis.Tarih] FROM Siparis INNER JOIN Paket ON Siparis.idPaket = Paket.idPaket");
    }
}