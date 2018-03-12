using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Yonetici_Haber : System.Web.UI.Page
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
            _dtUrun = _sysData._fncSelect("SELECT idHaber,Baslik FROM Haber");
            ListBox1.DataSource = _dtUrun;
            ListBox1.DataValueField = "idHaber";
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
            _dtUrunDuzenle = _sysData._fncSelect("SELECT Baslik,Haber,Tarih FROM Haber WHERE idHaber=" + ListBox1.SelectedValue + "");
            TextBox1.Text = _dtUrunDuzenle.Rows[0]["Baslik"].ToString();
            TextBox4.Text = _dtUrunDuzenle.Rows[0]["Haber"].ToString();
            Label1.Text = _dtUrunDuzenle.Rows[0]["Tarih"].ToString();
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
                _cmd.CommandText = "INSERT INTO Haber (Baslik,Haber,Tarih) VALUES (@Baslik,@Haber,@Tarih)";
                _cmd.Parameters.AddWithValue("Baslik", TextBox1.Text);
                _cmd.Parameters.AddWithValue("Haber", TextBox4.Text);
                _cmd.Parameters.AddWithValue("Tarih", DateTime.Now.ToString());
                _cmd.ExecuteNonQuery();
                _cnn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            _lblMesaj.Text = "Kayıt Edildi.";
            TextBox1.Text = "";
            TextBox4.Text = "";
            Label1.Text = "";
            _fncUrunListesi();
      
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        _lblMesaj.Text = "";
        TextBox1.Text = "";
        TextBox4.Text = "";
        Label1.Text = "";
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "UPDATE Haber SET Baslik=@Baslik,Haber=@Haber,Tarih=@Tarih WHERE idHaber=@idHaber";
            _cmd.Parameters.AddWithValue("Baslik", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Haber", TextBox4.Text);
            _cmd.Parameters.AddWithValue("Tarih", DateTime.Now.ToString());
            _cmd.Parameters.AddWithValue("idHaber", Convert.ToInt32(ListBox1.SelectedValue));
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
        Label1.Text = "";
    }
}