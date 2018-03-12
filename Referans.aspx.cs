using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Referans : System.Web.UI.Page
{
    string _ReferansID;
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public static string _HataSayfa = "Referans.aspx";
    public DataTable _dtReferans;
    public DataTable _dtMenu;
    protected void Page_Load(object sender, EventArgs e)
    {
        _ReferansID = Request.QueryString["MercanYaziliM"];
        try
        {
            if (_ReferansID==null)
            {
                 _dtReferans = _sysData._fncSelect("SELECT idReferans,ReferansAdi,Url,Resim,Aciklama FROM Referans WHERE idReferans=" + Convert.ToInt32(Ayar._idHosting) + "");
            }
            else
            {
                _dtReferans = _sysData._fncSelect("SELECT idReferans,ReferansAdi,Url,Resim,Aciklama FROM Referans WHERE idReferans=" + Convert.ToInt32(_ReferansID) + "");
            }
            _dtMenu = _sysData._fncSelect("select idReferans,ReferansAdi from Referans");
            _lblHizmetName.Text = _dtReferans.Rows[0]["ReferansAdi"].ToString();
            HyperLink1.Text = "Görmek İçin Tıklayın..";
            HyperLink1.NavigateUrl = _dtReferans.Rows[0]["Url"].ToString();
            ImageMap1.ImageUrl = _dtReferans.Rows[0]["Resim"].ToString();
            _lblAciklama.Text = _dtReferans.Rows[0]["Aciklama"].ToString();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
        
        
    }
}