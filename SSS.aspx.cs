using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class SSS : System.Web.UI.Page
{
    string _HizmetID;
    public string _BResim;
    public string _PageTitle;
    public string _PageFooter;
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public DataTable _dtverii;
    public DataTable _dtSSS;
    HataLog _clsHataLog = new HataLog();
    protected void Page_Load(object sender, EventArgs e)
    {
        _HizmetID = Request.QueryString["MercanYaziliM"];
        try
        {
            if (_HizmetID == null)
            {
                _dtverii = _sysData._fncSelect("select Soru,Cevap from SSS Where idSSS=" + Convert.ToInt32(Ayar._idHosting));
            }
            else
            {

                _dtverii = _sysData._fncSelect("select Soru,Cevap from SSS Where idSSS=" + Convert.ToInt32(_HizmetID));

            }
            _dtSSS = _sysData._fncSelect("select idSSS,Soru from SSS");
            _lblHizmetName.Text = _dtverii.Rows[0]["Soru"].ToString();
            _lblAciklama.Text = _dtverii.Rows[0]["Cevap"].ToString();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
    }
}