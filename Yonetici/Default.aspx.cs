using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Yonetici_Default : System.Web.UI.Page
{
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public DataTable _dtMesaj;
    public DataTable _dtSiparis;
    public DataTable _dtOdeme;
    public DataTable _dtWebTasarim;
    public DataTable _dtKampanya;
    public static string _HataSayfa = "Hizmetler.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["idYonetici"]==null)
        {
            Response.Redirect("Giris.aspx");
        }
        _dtMesaj = _sysData._fncSelect("SELECT * FROM iletisim WHERE Ok=True");
        _dtSiparis = _sysData._fncSelect("SELECT * FROM Siparis WHERE Onay=True");
        _dtOdeme = _sysData._fncSelect("SELECT * FROM Odeme WHERE Onay=True");
        _dtWebTasarim = _sysData._fncSelect("SELECT * FROM WebTasarimForm");
        _dtKampanya = _sysData._fncSelect("SELECT * FROM KampanyaForm");

    }
}