using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class WebTasarimForm : System.Web.UI.Page
{
    Data _sysData = new Data();
    public DataTable _dtMenu;
    DataTable _dtPaket;
    OleDbConnection _cnn;
    OleDbCommand _cmd;
    HataLog _clsHataLog = new HataLog();
    string Baglan = "Provider=Microsoft.jet.OLEDB.4.0; data source=" + HttpContext.Current.Server.MapPath("~/App_Data\\MercanYazilimDataBase.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            _fncComboboxDoldur();
        }
        try
        {
            _dtMenu = _sysData._fncSelect("select idHostingTur,TurAdi from HostingTur");
            _dtPaket = _sysData._fncSelect("select idPaket,PaketAdi from Paket");
            DropDownList1.DataSource = _dtPaket;
            DropDownList1.DataValueField = "idPaket";
            DropDownList1.DataTextField = "PaketAdi";
            DropDownList1.DataBind();
        }
        catch (Exception)
        {
            Response.Write("Yanlış");
        }
        
    }
    private void _fncComboboxDoldur()
    {
        DropDownList1.Items.Add("Var");
        DropDownList2.Items.Add("----------");
        DropDownList2.Items.Add("7 / 24");
        DropDownList2.Items.Add("Haftada 1");
        DropDownList2.Items.Add("Ayda 1");
        DropDownList2.Items.Add("Yılda 1~5 arası");
        DropDownList2.Items.Add("Hiçbir zaman");

        DropDownList3.Items.Add("----------");
        DropDownList3.Items.Add("Şirket tanıtımı");
        DropDownList3.Items.Add("Ürün / hizmet tanıtımı");
        DropDownList3.Items.Add("E-Ticaret");
        DropDownList3.Items.Add("Online müşteri desteği vermek");
        DropDownList3.Items.Add("Var olan Web Sitesini geliştirmek , yenilemek");

        DropDownList4.Items.Add("----------");
        DropDownList4.Items.Add("Telefon");
        DropDownList4.Items.Add("GSM");
        DropDownList4.Items.Add("E-Mail");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        TextBox6.Text = "Var";
        TextBox6.Enabled = false;
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        DropDownList1.Enabled = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string sql = "INSERT INTO WebTasarimForm ([FirmaAdi],[YetkiliAdi],[Telefon],[Email],[Adres],[AlanAdi],[idPaket],[WebSiteGuncelleme],[WebSiteAmac],[Ulasim],[WebSiteAyrinti],[RefWeb],[Aciklama],[Butce],[Tarih]) VALUES (@FirmaAdi,@YetkiliAdi,@Telefon,@Email,@Adres,@AlanAdi,@idPaket,@WebSiteGuncelleme,@WebSiteAmac,@Ulasim,@WebSiteAyrinti,@RefWeb,@Aciklama,@Butce,@Tarih)";
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = sql;
            _cmd.Parameters.AddWithValue("FirmaAdi", TextBox1.Text);
            _cmd.Parameters.AddWithValue("YetkiliAdi", TextBox2.Text);
            _cmd.Parameters.AddWithValue("Telefon", TextBox3.Text);
            _cmd.Parameters.AddWithValue("Email", TextBox4.Text);
            _cmd.Parameters.AddWithValue("Adres", TextBox5.Text);
            _cmd.Parameters.AddWithValue("AlanAdi", TextBox6.Text);
            _cmd.Parameters.AddWithValue("idPaket", DropDownList1.SelectedValue);
            _cmd.Parameters.AddWithValue("WebSiteGuncelleme", DropDownList2.SelectedItem.Text);
            _cmd.Parameters.AddWithValue("WebSiteAmac", DropDownList3.SelectedItem.Text);
            _cmd.Parameters.AddWithValue("Ulasim", DropDownList4.SelectedItem.Text);
            _cmd.Parameters.AddWithValue("WebSiteAyrinti", TextBox7.Text);
            _cmd.Parameters.AddWithValue("RefWeb", TextBox8.Text);
            _cmd.Parameters.AddWithValue("RefWeb", TextBox10.Text);
            _cmd.Parameters.AddWithValue("Butce", TextBox9.Text);
            _cmd.Parameters.AddWithValue("Tarih",DateTime.Now.ToString());
            _cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
        Label8.Text = "Siparişiniz Alındı. Değerlendirdikten Sonra Size Geri Döneceğiniz Lütfen Bekleyiniz..";
        TextBox1.Enabled = false;
        TextBox2.Enabled = false;
        TextBox3.Enabled = false;
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;
        TextBox6.Enabled = false;
        TextBox7.Enabled = false;
        TextBox8.Enabled = false;
        TextBox9.Enabled = false;
        TextBox10.Enabled = false;
        DropDownList1.Enabled = false;
        DropDownList2.Enabled = false;
        DropDownList3.Enabled = false;
        DropDownList4.Enabled = false;

    }
}