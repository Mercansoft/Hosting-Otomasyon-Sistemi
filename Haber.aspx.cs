using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Haber : System.Web.UI.Page
{
    string _HaberID;
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public static string _HataSayfa = "Referans.aspx";
    public DataTable _dtOku;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            _HaberID = Request.QueryString["MercaNYaziliM"];
            try
            {
                _dtOku = _sysData._fncSelect("SELECT Baslik,Haber FROM Haber WHERE idHaber=" + Convert.ToInt32(_HaberID));
            }
            catch (Exception)
            {
                Response.Redirect("Hata.aspx");
            }

        }
    }
}