using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Yonetici_Admin : System.Web.UI.MasterPage
{
    public DataTable _dtPanoMesaj;
    public DataTable _dtPanoHaber;
    public DataTable _dtPanoSiparis;
    Data _sysData = new Data();
    public int HaberSayisi;
    public int MesajSayisi;
    public int SiparisSayisi;
    protected void Page_Load(object sender, EventArgs e)
    {
        _lbluser.Text = Session["idYonetici"].ToString();
        _dtPanoMesaj = _sysData._fncSelect("SELECT * FROM iletisim WHERE Ok=True");
        _dtPanoHaber = _sysData._fncSelect("SELECT * FROM Haber");
        _dtPanoSiparis = _sysData._fncSelect("SELECT * FROM Siparis WHERE Onay=True");
        _lblHaber.Text = _fncPanoBilgisi(_dtPanoHaber);
        _lblMesaj.Text = _fncPanoBilgisi(_dtPanoMesaj);
        _lblSiparis.Text = _fncPanoBilgisi(_dtPanoSiparis);
    }
    private string _fncPanoBilgisi(DataTable _dtVeri)
    {
        int i;
        string sayi = string.Empty;
        for (i = 0; i < _dtVeri.Rows.Count; i++)
        {
            
        }
        sayi += i.ToString();
        return sayi;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
    }
}
