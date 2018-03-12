using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Yonetici_Hosting : System.Web.UI.Page
{
    DataTable _dtUrun;
    DataTable _dtUrunDuzenle;
    DataTable _dtHostingTur;
    private int _idKayit;
    public Data _sysData = new Data();
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
            _dtUrun = _sysData._fncSelect("SELECT idPaket,PaketAdi FROM Paket");
            ListBox1.DataSource = _dtUrun;
            ListBox1.DataValueField = "idPaket";
            ListBox1.DataTextField = "PaketAdi";
            ListBox1.DataBind();
            _dtHostingTur = _sysData._fncSelect("SELECT idHostingTur,TurAdi FROM HostingTur");
            DropDownList1.DataSource = _dtHostingTur;
            DropDownList1.DataValueField = "idHostingTur";
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
            _dtUrunDuzenle = _sysData._fncSelect("SELECT PaketAdi,Resim,Alan,Trafik,Db,SubDomain,Email,idHostingTur,AylikFiyat,YillikFiyat FROM Paket WHERE idPaket=" + ListBox1.SelectedValue + "");
            _idKayit = Convert.ToInt32(ListBox1.SelectedValue);
            TextBox1.Text = _dtUrunDuzenle.Rows[0]["PaketAdi"].ToString();
            TextBox2.Text = _dtUrunDuzenle.Rows[0]["Resim"].ToString();
            TextBox3.Text = _dtUrunDuzenle.Rows[0]["Alan"].ToString();
            TextBox5.Text = _dtUrunDuzenle.Rows[0]["Trafik"].ToString();
            TextBox6.Text = _dtUrunDuzenle.Rows[0]["Db"].ToString();
            TextBox7.Text = _dtUrunDuzenle.Rows[0]["SubDomain"].ToString();
            TextBox8.Text = _dtUrunDuzenle.Rows[0]["Email"].ToString();
            DropDownList1.SelectedValue = _dtUrunDuzenle.Rows[0]["idHostingTur"].ToString();
            TextBox9.Text = _dtUrunDuzenle.Rows[0]["AylikFiyat"].ToString();
            TextBox10.Text = _dtUrunDuzenle.Rows[0]["YillikFiyat"].ToString();
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
                _cmd.CommandText = "INSERT INTO Paket (PaketAdi,Resim,Alan,Trafik,Db,SubDomain,Email,idHostingTur,AylikFiyat,YillikFiyat) VALUES (@PaketAdi,@Resim,@Alan,@Trafik,@Db,@SubDomain,@Email,@idHostingTur,@AylikFiyat,@YillikFiyat)";
                _cmd.Parameters.AddWithValue("PaketAdi", TextBox1.Text);
                _cmd.Parameters.AddWithValue("Resim", TextBox2.Text);
                _cmd.Parameters.AddWithValue("Alan", TextBox3.Text);
                _cmd.Parameters.AddWithValue("Trafik", TextBox5.Text);
                _cmd.Parameters.AddWithValue("Db", TextBox6.Text);
                _cmd.Parameters.AddWithValue("SubDomain", TextBox7.Text);
                _cmd.Parameters.AddWithValue("Email", TextBox8.Text);
                _cmd.Parameters.AddWithValue("idHostingTur", DropDownList1.SelectedValue);
                _cmd.Parameters.AddWithValue("AylikFiyat", Convert.ToDecimal(TextBox9.Text));
                _cmd.Parameters.AddWithValue("YillikFiyat", Convert.ToDecimal(TextBox10.Text));
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
            TextBox3.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            _fncUrunListesi();
        
  
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "UPDATE Paket SET PaketAdi=@PaketAdi,Resim=@Resim,Alan=@BAlan,Trafik=@Trafik,Db=@Db,SubDomain=@SubDomain,Email=@Email,idHostingTur=@idHostingTur,AylikFiyat=@AylikFiyat,YillikFiyat=@YillikFiyat WHERE idPaket=@idPaket";
            _cmd.Parameters.AddWithValue("PaketAdi", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Resim", TextBox2.Text);
            _cmd.Parameters.AddWithValue("Alan", TextBox3.Text);
            _cmd.Parameters.AddWithValue("Trafik", TextBox5.Text);
            _cmd.Parameters.AddWithValue("Db", TextBox6.Text);
            _cmd.Parameters.AddWithValue("SubDomain", TextBox7.Text);
            _cmd.Parameters.AddWithValue("Email", TextBox8.Text);
            _cmd.Parameters.AddWithValue("idHostingTur", DropDownList1.SelectedValue);
            _cmd.Parameters.AddWithValue("AylikFiyat", TextBox9.Text);
            _cmd.Parameters.AddWithValue("YillikFiyat", TextBox10.Text);
            _cmd.Parameters.AddWithValue("idPaket", _idKayit);
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
        TextBox3.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        _fncUrunListesi();
    }
}