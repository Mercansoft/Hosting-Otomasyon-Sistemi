using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Odeme : System.Web.UI.Page
{
    string _idOdeme;
    Data _sysData = new Data();
    public DataTable _dtMenu;
    OleDbConnection _cnn;
    OleDbCommand _cmd;
    string Baglan = "Provider=Microsoft.jet.OLEDB.4.0; data source=" + HttpContext.Current.Server.MapPath("~/App_Data\\MercanYazilimDataBase.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        Label9.Enabled = false;
        _idOdeme = Request.QueryString["SiparisVerildi"];
        _dtMenu = _sysData._fncSelect("select idHostingTur,TurAdi from HostingTur");
        if (_idOdeme=="Onay")
        {
            Label9.Text = "Siparişiniz Alındı. Lütfen Ödemeyi Yaptıktan Sonra Ödeme Bildirim Formunu Doldurunuz..";
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = ""; 
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        Label8.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "INSERT INTO Odeme ([AdSoyad],[Email],[Telefon],[Banka],[Miktar],[Konu],[Aciklama],[Tarih],[Onay]) VALUES (@AdSoyad,@Email,@Telefon,@Banka,@Miktar,@Konu,@Aciklama,@Tarih,@Onay)";
            _cmd.Parameters.AddWithValue("AdSoyad", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Email", TextBox2.Text);
            _cmd.Parameters.AddWithValue("Telefon", TextBox3.Text);
            _cmd.Parameters.AddWithValue("Banka", TextBox4.Text);
            _cmd.Parameters.AddWithValue("Miktar", Convert.ToDecimal(TextBox5.Text));
            _cmd.Parameters.AddWithValue("Konu", TextBox6.Text);
            _cmd.Parameters.AddWithValue("Aciklama", TextBox7.Text);
            _cmd.Parameters.AddWithValue("Tarih" ,DateTime.Now.ToString());
            _cmd.Parameters.AddWithValue("Onay", true);
            _cmd.ExecuteNonQuery();
            _cnn.Close();
            Label8.Text = "Gönderildi..";
        }
        catch (Exception)
        {
            Label8.Text = "Hata Oluştu. Sistem Hatayı Yöneticiye Bildirdi Lütfen Hatanın Giderilmesini Bekleyiniz..";
        }
    }
}