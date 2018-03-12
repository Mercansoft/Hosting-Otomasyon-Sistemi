using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Hizmetler : System.Web.UI.Page
{
    string _HizmetID;
    public string _BResim;
    public string _PageTitle;
    public string _PageFooter;
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public DataTable _dtverii;
    public DataTable _dtMenu;
    protected void Page_Load(object sender, EventArgs e)
    {
        _HizmetID = Request.QueryString["MercanYaziliM"];
        try
        {
            if (_HizmetID == null)
            {
                _dtverii = _sysData._fncSelect("select HizmetAdi,Resim,Aciklama from Hizmet Where idHizmet=" + Convert.ToInt32(Ayar._idHosting));
            }
            else
            {

                _dtverii = _sysData._fncSelect("select HizmetAdi,Resim,Aciklama from Hizmet Where idHizmet=" + Convert.ToInt32(_HizmetID));

            }
            _dtMenu = _sysData._fncSelect("select idHizmet,HizmetAdi from Hizmet");
            _lblHizmetName.Text = _dtverii.Rows[0]["HizmetAdi"].ToString();
            ImageMap1.ImageUrl = _dtverii.Rows[0]["Resim"].ToString();
            _lblAciklama.Text = _dtverii.Rows[0]["Aciklama"].ToString();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
    }

}