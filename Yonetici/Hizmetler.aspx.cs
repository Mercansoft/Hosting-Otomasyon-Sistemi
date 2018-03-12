using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Yonetici_Hizmetler : System.Web.UI.Page
{
    DataTable _dtUrun;
    DataTable _dtUrunDuzenle;
    Data _sysData = new Data();
    OleDbConnection _cnn;
    OleDbCommand _cmd;
    string Baglan = "Provider=Microsoft.jet.OLEDB.4.0; data source=" + HttpContext.Current.Server.MapPath("~/App_Data\\MercanYazilimDataBase.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["idYonetici"] == null)
        {
            Response.Redirect("Giris.aspx");
        }
        if (!Page.IsPostBack)
        {
            _fncUrunListesi();
        }
    }
    private void _fncUrunListesi()
    {
        try
        {
            _dtUrun = _sysData._fncSelect("SELECT idHizmet,HizmetAdi FROM Hizmet");
            ListBox1.DataSource = _dtUrun;
            ListBox1.DataValueField = "idHizmet";
            ListBox1.DataTextField = "HizmetAdi";
            ListBox1.DataBind();
        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int sayi = Convert.ToInt32(ListBox1.SelectedValue);
        try
        {
            _dtUrunDuzenle = _sysData._fncSelect("SELECT HizmetAdi,Resim,Aciklama FROM Hizmet WHERE idHizmet=" + ListBox1.SelectedValue + "");
            TextBox1.Text = _dtUrunDuzenle.Rows[0]["HizmetAdi"].ToString();
            TextBox2.Text = _dtUrunDuzenle.Rows[0]["Resim"].ToString();
            TextBox4.Text = _dtUrunDuzenle.Rows[0]["Aciklama"].ToString();
        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        
            try
            {
                _cnn = new OleDbConnection(Baglan);
                _cnn.Open();
                _cmd = _cnn.CreateCommand();
                _cmd.CommandText = "INSERT INTO Hizmet (HizmetAdi,Resim,Aciklama) VALUES (@HizmetAdi,@Resim,@Aciklama)";
                _cmd.Parameters.AddWithValue("HizmetAdi", TextBox1.Text);
                _cmd.Parameters.AddWithValue("Resim", TextBox2.Text);
                _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
                _cmd.ExecuteNonQuery();
                _cnn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            _lblMesaj.Text = "Kayıt Edildi.";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox4.Text = "";
            _fncUrunListesi();
        
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "UPDATE Hizmet SET HizmetAdi=@HizmetAdi,Resim=@Resim,Aciklama=@Aciklama WHERE idHizmet=@idHizmet";
            _cmd.Parameters.AddWithValue("UrunAdi", TextBox1.Text);
            _cmd.Parameters.AddWithValue("KResim", TextBox2.Text);
            _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
            _cmd.Parameters.AddWithValue("idHizmet", Convert.ToInt32(ListBox1.SelectedValue));
            _cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        catch (Exception)
        {

            throw;
        }
        _lblMesaj.Text = "Güncellendi.";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox4.Text = "";
        _fncUrunListesi();
    }
}

