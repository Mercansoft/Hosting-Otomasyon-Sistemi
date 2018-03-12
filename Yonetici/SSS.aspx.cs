using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Yonetici_SSS : System.Web.UI.Page
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
            _dtUrun = _sysData._fncSelect("SELECT idSSS,Soru FROM SSS");
            ListBox1.DataSource = _dtUrun;
            ListBox1.DataValueField = "idSSS";
            ListBox1.DataTextField = "Soru";
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
            _dtUrunDuzenle = _sysData._fncSelect("SELECT Soru,Cevap FROM SSS WHERE idSSS=" + ListBox1.SelectedValue + "");
            TextBox1.Text = _dtUrunDuzenle.Rows[0]["Soru"].ToString();
            TextBox4.Text = _dtUrunDuzenle.Rows[0]["Cevap"].ToString();
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
                _cmd.CommandText = "INSERT INTO SSS (Soru,Cevap) VALUES (@Soru,@Cevap)";
                _cmd.Parameters.AddWithValue("Soru", TextBox1.Text);
                _cmd.Parameters.AddWithValue("Cevap", TextBox4.Text);
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
            _fncUrunListesi();
        
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "UPDATE SSS SET Soru=@Soru,Cevap=@Cevap WHERE idSSS=@idSSS";
            _cmd.Parameters.AddWithValue("Soru", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Cevap", TextBox4.Text);
            _cmd.Parameters.AddWithValue("idSSS", Convert.ToInt32(ListBox1.SelectedValue));
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
        _fncUrunListesi();
    }
}