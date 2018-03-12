using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class MercanPage : System.Web.UI.MasterPage
{
    string _UrunID;
    public string _BResim;
    public string _PageTitle;
    public string _PageFooter;
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public DataTable _dtMenu;
    public static string _HataSayfa = "Urun.aspx";
    public string _StrPageTitle;
    public string _StrPageFooter;
    public string _StrPageKeywords;
    public string _StrPageDescription;
    protected void Page_Load(object sender, EventArgs e)
    {
        _StrPageTitle = _sysAyar._fncGenelAyar("PageTitle");
        _StrPageFooter = _sysAyar._fncGenelAyar("PageFooter");
        _StrPageKeywords = _sysAyar._fncGenelAyar("Keywords");
        _StrPageDescription = _sysAyar._fncGenelAyar("Description");
        _dtMenu = _sysData._fncSelect("SELECT MenuAdi,MenuUrl FROM Menu");
        if (_dtMenu ==null)
        {
            Response.Redirect("Hata.aspx");
        }
    }
}
