using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Urun : System.Web.UI.Page
{
    string _UrunID;
    public string _BResim;
    public string _PageTitle;
    public string _PageFooter;
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public DataTable _dtMenu;
    protected void Page_Load(object sender, EventArgs e)
    {
        _UrunID = Request.QueryString["MercanYaziliM"];
        DataTable _dtverii = new DataTable();
        try
        {
            if (_UrunID==null)
            {
                _dtverii = _sysData._fncSelect("select UrunAdi,KResim,BResim,Aciklama from Urun Where idUrun=" + Convert.ToInt32(Ayar._idHosting));
            }
            else
            {
                _dtverii = _sysData._fncSelect("select UrunAdi,KResim,BResim,Aciklama from Urun Where idUrun=" + Convert.ToInt32(_UrunID));
            }
            _dtMenu = _sysData._fncSelect("select idUrun,UrunAdi from Urun");
            _lblUrunName.Text = _dtverii.Rows[0]["UrunAdi"].ToString();
            ImageMap1.ImageUrl = _dtverii.Rows[0]["KResim"].ToString();
            _BResim = _dtverii.Rows[0]["BResim"].ToString();
            _lblAciklama.Text = _dtverii.Rows[0]["Aciklama"].ToString();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
    }
    //private void _fncAyar()
    //{
    //    DataTable _dtAyar = new DataTable();
    //    _dtAyar = _sysData._fncSelect("select UrunAdi,KResim,BResim,Aciklama from Urun Where idUrun=" + Convert.ToInt32(_UrunID));
    //}

}