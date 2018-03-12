using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class Yonetici_Urunler : System.Web.UI.Page
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
            _dtUrun = _sysData._fncSelect("SELECT idUrun,UrunAdi FROM Urun");
            ListBox1.DataSource = _dtUrun;
            ListBox1.DataValueField = "idUrun";
            ListBox1.DataTextField = "UrunAdi";
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
            _dtUrunDuzenle = _sysData._fncSelect("SELECT UrunAdi,KResim,BResim,Aciklama FROM Urun WHERE idUrun=" + ListBox1.SelectedValue + "");
            TextBox1.Text = _dtUrunDuzenle.Rows[0]["UrunAdi"].ToString();
            TextBox2.Text = _dtUrunDuzenle.Rows[0]["KResim"].ToString();
            TextBox3.Text = _dtUrunDuzenle.Rows[0]["BResim"].ToString();
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
                _cmd.CommandText = "UPDATE Urun SET UrunAdi=@UrunAdi,KResim=@KResim,BResim=@BResim,Aciklama=@Aciklama WHERE idUrun=@idUrun";
                _cmd.Parameters.AddWithValue("UrunAdi", TextBox1.Text);
                _cmd.Parameters.AddWithValue("KResim", TextBox2.Text);
                _cmd.Parameters.AddWithValue("BResim", TextBox3.Text);
                _cmd.Parameters.AddWithValue("Aciklama", TextBox4.Text);
                _cmd.Parameters.AddWithValue("idUrun", Convert.ToInt32(ListBox1.SelectedValue));
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
            TextBox3.Text = "";
            TextBox4.Text = "";
            _fncUrunListesi();
       
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "INSERT INTO Urun (UrunAdi,KResim,BResim,Aciklama) VALUES (@UrunAdi,@KResim,@BResim,@Aciklama)";
            _cmd.Parameters.AddWithValue("UrunAdi", TextBox1.Text);
            _cmd.Parameters.AddWithValue("KResim", TextBox2.Text);
            _cmd.Parameters.AddWithValue("BResim", TextBox3.Text);
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
        TextBox3.Text = "";
        TextBox4.Text = "";
        _fncUrunListesi();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        _sysData._fncExecuteNonQuery("DELETE FROM Urun WHERE idUrun=" + ListBox1.SelectedValue);
        _fncUrunListesi();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        try
        {
            decimal boyut = FileUpload1.FileBytes.Length / 1000;
            Label9.Text = "Boyut : " + boyut.ToString() + " KB";
            Label10.Text = "Isim : " + FileUpload1.FileName;
            Label11.Text = "Tür : " + FileUpload1.PostedFile.ContentType;
            FileUpload1.SaveAs(Server.MapPath("~/" + Kontrol.UploadUrun) + FileUpload1.FileName);
            System.Drawing.Image resim = System.Drawing.Image.FromFile(Server.MapPath("~/" + Kontrol.UploadUrun + FileUpload1.FileName));
            _clsResim.Boyutlandir(resim, Kontrol.Genislik, Kontrol.Yukseklik, Kontrol.UploadUrun, FileUpload1.FileName);
            resim.Dispose();
            ImageMap2.ImageUrl = "~/" + Kontrol.UploadUrun + "kucuk_" + FileUpload1.FileName;
            _clsData._fncExecuteNonQueryVoid("INSERT INTO Resim (UrunID,Resim) VALUES ('" + Kontrol.UrunID + "','" + Kontrol.UploadUrun + FileUpload1.FileName + "')");
            _strResimYukleme = "<span class='message success'><strong>İşlem Mesajı: </strong>Resim Başarıyla Yüklendi.</span>";
        }
        catch (Exception)
        {
            _strResimYukleme = "<span class='message error'><strong>Hata Mesajı: </strong>Resim Yüklenemedi.</span>";
        }
        _fncResimlerGelsin();
    }
}