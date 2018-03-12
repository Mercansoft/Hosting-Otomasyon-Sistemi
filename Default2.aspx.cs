using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;

public partial class _Default : System.Web.UI.Page 
{
    public static string _idHosting= "1";
    public static string _idBayi = "3";
    public DataTable _dtMenu;
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public DataTable _dtAltSol;
    public DataTable _dtSagUst;
    public DataTable _dtAltOrta;
    public DataTable _dtBanner;
    public DataTable _dtUrunGoster;
    public DataTable _dtKampanya;
    public string _StrPageTitle;
    public string _StrPageFooter;
    public string _StrPageKeywords;
    public string _StrPageDescription;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
            _dtMenu = _sysData._fncSelect("SELECT MenuAdi,MenuUrl FROM Menu");
            if (_dtMenu == null)
            {
                Response.Redirect("Hata.aspx");
            }
            _fncAltSolPanel();
            _fncSagUstPanel();
            _fncUrunlerPanel();
            _fncBanner();
            _fncKampanya();
            _StrPageTitle = _sysAyar._fncGenelAyar("PageTitle");
            _StrPageFooter = _sysAyar._fncGenelAyar("PageFooter");
            _StrPageKeywords = _sysAyar._fncGenelAyar("Keywords");
            _StrPageDescription = _sysAyar._fncGenelAyar("Description");
              }
            catch { Response.Redirect("Hata.aspx"); };
        }

    }
    //}
    //private void _fncAltOrtaPanel()
    //{
    //    _dtAltOrta = _sysData._fncWebDBBaglan("SELECT TOP 5 PostID,Title FROM Post");
    //}
    private void _fncAltSolPanel()
    {
        _dtAltSol = _sysData._fncSelect("SELECT TOP 5 ReferansAdi,Url,Resim,Aciklama FROM Referans");
    }
    private void _fncUrunlerPanel()
    {
        _dtUrunGoster = _sysData._fncSelect("SELECT TOP 2 idUrun,UrunAdi,KResim FROM Urun");
    }
    private void _fncSagUstPanel()
    {
        _dtSagUst = _sysData._fncSelect("SELECT TOP 5 idHaber,Baslik,Haber FROM Haber");
    }
    private void _fncBanner()
    {
        _dtBanner = _sysData._fncSelect("SELECT * FROM Banner");
    }
    private void _fncKampanya()
    {
        _dtKampanya = _sysData._fncSelect("SELECT idKampanya,Baslik,Resim FROM Kampanya");
    }
}