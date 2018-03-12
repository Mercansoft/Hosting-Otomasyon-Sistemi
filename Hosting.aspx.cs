using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Hosting : System.Web.UI.Page
{
    public string _BResim;
    public string _PageTitle;
    public string _PageFooter;
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public DataTable _dtHosting;
    public static string _HataSayfa = "Hizmetler.aspx";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            _dtHosting = _sysData._fncSelect("SELECT TurAdi,Resim FROM HostingTur");
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
        
    }
   
}