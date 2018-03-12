using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Paket : System.Web.UI.Page
{
    public int _PaketTurID;
    public int _idPaket;
    public string _PageTitle;
    public string _PageFooter;
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public DataTable _dtWinHosting;
    public DataTable _dtMenu;
    public string _PaketCinsi;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string _QeryString = Request.QueryString["MercanYaziliM"];
            _dtMenu = _sysData._fncSelect("SELECT idHostingTur,TurAdi,Resim FROM HostingTur");
            if (_QeryString == null)
            {
                _PaketCinsi = _sysData._fncSelectString("SELECT TurAdi FROM HostingTur WHERE idHostingTur=" + Convert.ToInt32(Ayar._idHosting));
                _dtWinHosting = _sysData._fncSelect("SELECT idPaket,PaketAdi,Resim,Alan,Trafik,Db,SubDomain,Email,Resim,YillikFiyat,idHostingTur FROM Paket Where idHostingTur=1");

            }
            else
            {
                _PaketCinsi = _sysData._fncSelectString("SELECT TurAdi FROM HostingTur WHERE idHostingTur=" + Convert.ToInt32(_QeryString));
                _dtWinHosting = _sysData._fncSelect("SELECT idPaket,PaketAdi,Resim,Alan,Trafik,Db,SubDomain,Email,Resim,YillikFiyat,idHostingTur FROM Paket Where idHostingTur=" + Convert.ToInt32(_QeryString));

            }
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
        
       
    }
}