using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Yonetici_Kampanya : System.Web.UI.Page
{
    DataTable _dtUrun;
    DataTable _dtUrunDuzenle;
    Data _sysData = new Data();
    private bool _blDuzenle;
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
            _dtUrun = _sysData._fncSelect("SELECT idKampanya,Baslik FROM Kampanya");
            ListBox1.DataSource = _dtUrun;
            ListBox1.DataValueField = "idKampanya";
            ListBox1.DataTextField = "Baslik";
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
            _dtUrunDuzenle = _sysData._fncSelect("SELECT Resim,Url,Baslik,Aciklama,Fiyat,Tarih FROM Kampanya WHERE idKampanya=" + ListBox1.SelectedValue + "");
            TextBox1.Text = _dtUrunDuzenle.Rows[0]["Baslik"].ToString();
            TextBox5.Text = _dtUrunDuzenle.Rows[0]["Resim"].ToString();
             TextBox6.Text = _dtUrunDuzenle.Rows[0]["Url"].ToString();
             TextBox7.Text = _dtUrunDuzenle.Rows[0]["Fiyat"].ToString();
            TextBox4.Text = _dtUrunDuzenle.Rows[0]["Aciklama"].ToString();
            Label1.Text = _dtUrunDuzenle.Rows[0]["Tarih"].ToString();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
         try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "UPDATE Kampanya SET Resim=@Resim,Url=@Url,Baslik=@Baslik,Aciklama=@Aciklama,Fiyat=@Fiyat,Tarih=@Tarih WHERE idKampanya=@idKampanya";
            _cmd.Parameters.AddWithValue("Resim", TextBox5.Text);
            _cmd.Parameters.AddWithValue("Url", TextBox6.Text);
            _cmd.Parameters.AddWithValue("Baslik", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
             _cmd.Parameters.AddWithValue("Fiyat",  Convert.ToDecimal(TextBox7.Text));
            _cmd.Parameters.AddWithValue("Tarih", DateTime.Now.ToString());
            _cmd.Parameters.AddWithValue("idKampanya", Convert.ToInt32(ListBox1.SelectedValue));
            _cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
        _lblMesaj.Text = "Güncellendi.";
        TextBox1.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        Label1.Text = "";
        _fncUrunListesi();
    }
    protected void  Button3_Click(object sender, EventArgs e)
{
             try
            {
                _cnn = new OleDbConnection(Baglan);
                _cnn.Open();
                _cmd = _cnn.CreateCommand();
                _cmd.CommandText = "INSERT INTO Kampanya ([Resim],[Url],[Baslik],[Aciklama],[Fiyat],[Tarih]) VALUES (@Resim,@Url,@Baslik,@Aciklama,@Fiyat,@Tarih)";
                _cmd.Parameters.AddWithValue("Resim", TextBox5.Text);
                _cmd.Parameters.AddWithValue("Url", TextBox6.Text);
                _cmd.Parameters.AddWithValue("Baslik", TextBox1.Text);
                _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
                _cmd.Parameters.AddWithValue("Fiyat", Convert.ToDecimal(TextBox7.Text));
                _cmd.Parameters.AddWithValue("Tarih", DateTime.Now.ToString());
                _cmd.ExecuteNonQuery();
                _cnn.Close();
            }
            catch (Exception)
            {
                Response.Redirect("Hata.aspx");
            }
            _lblMesaj.Text = "Kayıt Edildi.";
            TextBox1.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            Label1.Text = "";
            _fncUrunListesi();
}
    protected void Button6_Click(object sender, EventArgs e)
    {
        _sysData._fncExecuteNonQuery("DELETE FROM Kampanya WHERE idKampanya=" + ListBox1.SelectedValue + "");
        _fncUrunListesi();
    }
}