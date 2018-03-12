using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Yonetici_Yazilim : System.Web.UI.Page
{
    DataTable _dtUrun;
    DataTable _dtYazilimTur;
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
            _dtUrun = _sysData._fncSelect("SELECT idYazilim,YazilimAdi FROM Yazilim");
            _dtYazilimTur = _sysData._fncSelect("SELECT idYazilimTur,TurAdi FROM YazilimTur");
            ListBox1.DataSource = _dtUrun;
            ListBox1.DataValueField = "idYazilim";
            ListBox1.DataTextField = "YazilimAdi";
            ListBox1.DataBind();
            DropDownList1.DataSource = _dtYazilimTur;
            DropDownList1.DataValueField = "idYazilimTur";
            DropDownList1.DataTextField = "TurAdi";
            DropDownList1.DataBind();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int sayi = Convert.ToInt32(ListBox1.SelectedValue);
        try
        {
            _dtUrunDuzenle = _sysData._fncSelect("SELECT idYazilimTur,YazilimAdi,Resim,DownloadLink,HitCount,Aciklama FROM Yazilim WHERE idYazilim=" + ListBox1.SelectedValue + "");
            DropDownList1.SelectedValue = _dtUrunDuzenle.Rows[0]["idYazilimTur"].ToString();
            TextBox1.Text = _dtUrunDuzenle.Rows[0]["YazilimAdi"].ToString();
            TextBox2.Text = _dtUrunDuzenle.Rows[0]["Resim"].ToString();
            TextBox5.Text = _dtUrunDuzenle.Rows[0]["DownloadLink"].ToString();
            TextBox6.Text = _dtUrunDuzenle.Rows[0]["HitCount"].ToString();
            TextBox4.Text = _dtUrunDuzenle.Rows[0]["Aciklama"].ToString();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
            {
                _cnn = new OleDbConnection(Baglan);
                _cnn.Open();
                _cmd = _cnn.CreateCommand();
                _cmd.CommandText = "INSERT INTO Yazilim (idYazilimTur,YazilimAdi,Resim,DownloadLink,HitCount,Aciklama) VALUES (@idYazilimTur,@YazilimAdi,@Resim,@DownloadLink,@HitCount,@Aciklama)";
                _cmd.Parameters.AddWithValue("idYazilimTur", DropDownList1.SelectedValue);
                _cmd.Parameters.AddWithValue("YazilimAdi", TextBox1.Text);
                _cmd.Parameters.AddWithValue("Resim", TextBox2.Text);
                _cmd.Parameters.AddWithValue("DownloadLink", TextBox5.Text);
                _cmd.Parameters.AddWithValue("HitCount", TextBox6.Text);
                _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
                _cmd.ExecuteNonQuery();
                _cnn.Close();
            }
            catch (Exception)
            {
                Response.Redirect("Hata.aspx");
            }
            _lblMesaj.Text = "Kayıt Edildi.";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox4.Text = "";
            TextBox6.Text = "";
            TextBox5.Text = "";
            _fncUrunListesi();
        }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "UPDATE Yazilim SET idYazilimTur=@idYazilimTur,YazilimAdi=@YazilimAdi,Resim=@Resim,DownloadLink=@DownloadLink,HitCount=@HitCount,Aciklama=@Aciklama WHERE idYazilim=@idYazilim";
            _cmd.Parameters.AddWithValue("idYazilimTur", DropDownList1.SelectedValue);
            _cmd.Parameters.AddWithValue("YazilimAdi", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Resim", TextBox2.Text);
            _cmd.Parameters.AddWithValue("DownloadLink", TextBox5.Text);
            _cmd.Parameters.AddWithValue("HitCount", TextBox6.Text);
            _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
            _cmd.Parameters.AddWithValue("idYazilim", Convert.ToInt32(ListBox1.SelectedValue));
            _cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
        _lblMesaj.Text = "Güncellendi.";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox4.Text = "";
        TextBox6.Text = "";
        TextBox5.Text = "";
        _fncUrunListesi();
    }
}