using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Yonetici_SlideShow : System.Web.UI.Page
{
    DataTable _dtUrun;
    DataTable _dtUrunDuzenle;
    //public DataTable _dtResim;
    public string Resim="images/Banner/4.png";
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
            ListBox1.SelectedIndex = 1;
        }
        else
        {
            Resim = _sysData._fncSelectString("SELECT Resim FROM Banner WHERE idBanner=" + ListBox1.SelectedValue + "");
        }
    }
    private void _fncUrunListesi()
    {
        try
        {
            _dtUrun = _sysData._fncSelect("SELECT idBanner,Baslik FROM Banner");
            ListBox1.DataSource = _dtUrun;
            ListBox1.DataValueField = "idBanner";
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
            _dtUrunDuzenle = _sysData._fncSelect("SELECT Resim,Baslik,Aciklama,Url FROM Banner WHERE idBanner=" + ListBox1.SelectedValue + "");
            TextBox2.Text = _dtUrunDuzenle.Rows[0]["Resim"].ToString();
            TextBox1.Text = _dtUrunDuzenle.Rows[0]["Baslik"].ToString();
            TextBox4.Text = _dtUrunDuzenle.Rows[0]["Aciklama"].ToString();
            TextBox5.Text = _dtUrunDuzenle.Rows[0]["Url"].ToString();
        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "UPDATE Banner SET Resim=@Resim,Baslik=@Baslik,Aciklama=@Aciklama,Url=@Url WHERE idBanner=@idBanner";
            _cmd.Parameters.AddWithValue("Resim", TextBox2.Text);
            _cmd.Parameters.AddWithValue("Baslik", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
            _cmd.Parameters.AddWithValue("Url", TextBox5.Text);
            _cmd.Parameters.AddWithValue("idBanner", Convert.ToInt32(ListBox1.SelectedValue));
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
        TextBox5.Text = "";
        _fncUrunListesi();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "INSERT INTO Banner (Resim,Baslik,Aciklama,Url) VALUES (@Resim,@Baslik,@Aciklama,@Url)";
            _cmd.Parameters.AddWithValue("Resim", TextBox2.Text);
            _cmd.Parameters.AddWithValue("Baslik", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
            _cmd.Parameters.AddWithValue("Url", TextBox4.Text);
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
        TextBox5.Text = "";
        _fncUrunListesi();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        _sysData._fncExecuteNonQuery("DELETE FROM Banner WHERE idBanner="+ListBox1.SelectedValue+"");
        _fncUrunListesi();
        _lblMesaj.Text = "Silindi.";
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        //_dtResim = new DataTable();
      Resim = _sysData._fncSelectString("SELECT Resim FROM Banner WHERE idBanner=" + ListBox1.SelectedValue + "");
    }
}