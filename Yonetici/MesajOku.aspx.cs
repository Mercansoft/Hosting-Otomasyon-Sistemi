using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Yonetici_MesajOku : System.Web.UI.Page
{
    string _idAl;
    string _idTum;
    string _idTur;
    public DataTable _dtMesajOku;
    Data _sysData = new Data();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["idYonetici"] == null)
        {
            Response.Redirect("Giris.aspx");
        }
        if (!Page.IsPostBack)
        {
            _idTur = Request.QueryString["Type"];
            _idAl = Request.QueryString["id"];
            _idTum = Request.QueryString["tum"];
            if (_idAl!=null && _idTur!=null)
            {
                switch (_idTur)
                {
                    case "Siparis":
                        _dtMesajOku = _sysData._fncSelect("SELECT * FROM Siparis WHERE idSiparis="+_idAl.ToString());
                        DetailsView1.DataSource = _dtMesajOku;
                        DetailsView1.DataBind();
                        break;
                    case "Kampanya":
                        _dtMesajOku = _sysData._fncSelect("SELECT * FROM KampanyaForm WHERE idKampanyaForm=" + _idAl.ToString());
                        DetailsView1.DataSource = _dtMesajOku;
                        DetailsView1.DataBind();
                        break;
                    case "Mesaj":
                        _dtMesajOku = _sysData._fncSelect("SELECT * FROM iletisim WHERE idiletisim=" + _idAl.ToString());
                        DetailsView1.DataSource = _dtMesajOku;
                        DetailsView1.DataBind();
                        break;
                    case "Odeme":
                        _dtMesajOku = _sysData._fncSelect("SELECT * FROM Odeme WHERE idOdeme=" + _idAl.ToString());
                        DetailsView1.DataSource = _dtMesajOku;
                        DetailsView1.DataBind();
                        break;
                    case "WebTasarim":
                        _dtMesajOku = _sysData._fncSelect("SELECT * FROM WebTasarimForm WHERE idWebTasarimForm=" + _idAl.ToString());
                        DetailsView1.DataSource = _dtMesajOku;
                        DetailsView1.DataBind();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (_idTum)
                {
                    case "Siparis":
                _dtMesajOku = _sysData._fncSelect("SELECT * FROM Siparis");
                GridView1.DataSource = _dtMesajOku;
                GridView1.DataBind();
                break;
                    case "Kampanya":
                _dtMesajOku = _sysData._fncSelect("SELECT * FROM KampanyaForm");
                GridView1.DataSource = _dtMesajOku;
                GridView1.DataBind();
                break;
                    case"Mesaj":
                _dtMesajOku = _sysData._fncSelect("SELECT * FROM iletisim");
                GridView1.DataSource = _dtMesajOku;
                GridView1.DataBind();
                break;
                    case"Odeme":
                _dtMesajOku = _sysData._fncSelect("SELECT * FROM Odeme");
                GridView1.DataSource = _dtMesajOku;
                GridView1.DataBind();
                break;
                    case"WebTasarim":
                 _dtMesajOku = _sysData._fncSelect("SELECT * FROM WebTasarimForm");
                GridView1.DataSource = _dtMesajOku;
                GridView1.DataBind();
                break;
                    default:
                        break;
                }
            }
        }
        //if (!Page.IsPostBack)
        //{
        //   _idAl= Request.QueryString["id"];
        //   _idTum = Request.QueryString["tum"];
        //   if (_idAl!=null)
        //   {
        //       try
        //   {
        //       _dtMesajOku = _sysData._fncSelect("SELECT * FROM iletisim WHERE idiletisim=" + _idAl + "");
        //       _lblAdSoyad.Text = _dtMesajOku.Rows[0]["Ad"].ToString() + " " + _dtMesajOku.Rows[0]["Soyad"].ToString();
        //       _lblEmail.Text = _dtMesajOku.Rows[0]["Email"].ToString();
        //       _lblTarih.Text = _dtMesajOku.Rows[0]["Tarih"].ToString();
        //       _lblKonu.Text = _dtMesajOku.Rows[0]["Konu"].ToString();
        //       _lblAciklama.Text = _dtMesajOku.Rows[0]["Aciklama"].ToString();
        //   }
        //   catch (Exception)
        //   {
        //       Response.Write("Page_Load");
        //   }
        //   }
        //   else if(_idTum =="tum")
        //   {
        //       _dtMesajOku = _sysData._fncSelect("SELECT * FROM iletisim");
        //   }
        //   else
        //   {
        //       _dtMesajOku = _sysData._fncSelect("SELECT * FROM iletisim");
        //   }
        //}
    }
}