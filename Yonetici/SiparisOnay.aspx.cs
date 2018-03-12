using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Yonetici_SiparisOnay : System.Web.UI.Page
{
    string _intOnay;
    bool _blOnay;
    Data _sysData = new Data();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["idYonetici"] == null)
        {
            Response.Redirect("Giris.aspx");
        }
            _intOnay = Request.QueryString["MercaNYaziliM"];
            _blOnay = _sysData._fncExecuteNonQuery("UPDATE Siparis SET Onay=False WHERE idSiparis="+_intOnay.ToString()+"");
            Response.Redirect("Default.aspx");        

    }
}