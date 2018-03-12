using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Kampanya : System.Web.UI.Page
{
    public DataTable _dtMenu;
    Data _sysData = new Data();
    string _idAl;
    OleDbConnection _cnn;
    OleDbCommand _cmd;
    DataTable _dtKampanya;
    string Baglan = "Provider=Microsoft.jet.OLEDB.4.0; data source=" + HttpContext.Current.Server.MapPath("~/App_Data\\MercanYazilimDataBase.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            _idAl = Request.QueryString["MercanYaziliM"];
            _fncMenuGetir();
            _fncVeriDoldur(_idAl);
        }
        
    }
    private void _fncMenuGetir()
    {
        _dtMenu = _sysData._fncSelect("SELECT idKampanya,Baslik FROM Kampanya");
    }
    private void _fncVeriDoldur(string id)
    {
        try
        {
            _dtKampanya = _sysData._fncSelect("SELECT Baslik,Aciklama,Fiyat FROM Kampanya WHERE idKampanya =" + Convert.ToInt32(id));
            _lblAdi.Text = _dtKampanya.Rows[0]["Baslik"].ToString();
            _lblPaketAdi.Text = _dtKampanya.Rows[0]["Baslik"].ToString();
            _lblFiyat.Text = _dtKampanya.Rows[0]["Fiyat"].ToString();
            _lblDetay.Text = _dtKampanya.Rows[0]["Aciklama"].ToString();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "INSERT INTO KampanyaForm ([KampanyaAdi],[Ad],[Soyad],[Telefon],[Email],[Aciklama],[Tarih]) VALUES (@KampanyaAdi,@Ad,@Soyad,@Telefon,@Email,@Aciklama,@Tarih)";
            _cmd.Parameters.AddWithValue("KampanyaAdi", _lblPaketAdi.Text);
            _cmd.Parameters.AddWithValue("Ad", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Soyad", TextBox2.Text);
            _cmd.Parameters.AddWithValue("Telefon", TextBox3.Text);
            _cmd.Parameters.AddWithValue("Email", TextBox4.Text);
            _cmd.Parameters.AddWithValue("Aciklama", TextBox5.Text);
            _cmd.Parameters.AddWithValue("Tarih", DateTime.Now.ToString());
            _cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
        _lblDurum.Text = "Siparişiniz Alındı.";

    }
}