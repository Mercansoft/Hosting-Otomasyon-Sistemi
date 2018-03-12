using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Yonetici_Referans : System.Web.UI.Page
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
            _dtUrun = _sysData._fncSelect("SELECT idReferans,ReferansAdi FROM Referans");
            ListBox1.DataSource = _dtUrun;
            ListBox1.DataValueField = "idReferans";
            ListBox1.DataTextField = "ReferansAdi";
            ListBox1.DataBind();
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
            _dtUrunDuzenle = _sysData._fncSelect("SELECT ReferansAdi,Url,Resim,Aciklama FROM Referans WHERE idReferans=" + ListBox1.SelectedValue + "");
            TextBox1.Text = _dtUrunDuzenle.Rows[0]["ReferansAdi"].ToString();
            TextBox2.Text = _dtUrunDuzenle.Rows[0]["Url"].ToString();
            TextBox5.Text = _dtUrunDuzenle.Rows[0]["Resim"].ToString();
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
                _cmd.CommandText = "INSERT INTO Referans (ReferansAdi,Url,Resim,Aciklama) VALUES (@ReferansAdi,@Url,@Resim,@Aciklama)";
                _cmd.Parameters.AddWithValue("ReferansAdi", TextBox1.Text);
                _cmd.Parameters.AddWithValue("Url", TextBox2.Text);
                _cmd.Parameters.AddWithValue("Resim", TextBox5.Text);
                _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
                _cmd.ExecuteNonQuery();
                _cnn.Close();
                _fncUrunListesi();
            }
            catch (Exception)
            {
                Response.Redirect("Hata.aspx");
            }
            _lblMesaj.Text = "Kayıt Edildi.";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox5.Text = "";
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
            _cmd.CommandText = "UPDATE Referans SET ReferansAdi=@ReferansAdi,Url=@Url,Resim=@Resim,Aciklama=@Aciklama WHERE idReferans=@idReferans";
            _cmd.Parameters.AddWithValue("ReferansAdi", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Url", TextBox2.Text);
            _cmd.Parameters.AddWithValue("Resim", TextBox5.Text);
            _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
            _cmd.Parameters.AddWithValue("idReferans", Convert.ToInt32(ListBox1.SelectedValue));
            _cmd.ExecuteNonQuery();
            _cnn.Close();
            _fncUrunListesi();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
        _lblMesaj.Text = "Güncellendi.";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox5.Text = "";
        TextBox4.Text = "";
        _fncUrunListesi();
    }
}