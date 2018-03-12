using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Data;

public partial class Domain : System.Web.UI.Page
{
    public DataTable _dtMenu;
    Data _sysData = new Data();
    protected void Page_Load(object sender, EventArgs e)
    {
        _dtMenu = _sysData._fncSelect("select idHostingTur,TurAdi from HostingTur");
        if (!Page.IsPostBack)
        {
            DropDownList1.Items.Add("COM");
            DropDownList1.Items.Add("NET");
            DropDownList1.Items.Add("ORG");
            txtDomain.Attributes.Add("onclick", "this.value='';");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string firstLevelbufData = null;
        // Stores the bufData extracted from the webclient 
        try
        {
            // similarly we can select any server address for bufData mining
            string strURL = "http://www.directnic.com/whois/index.php?query=" + txtDomain.Text;
            WebClient web = new WebClient();
            // byte array to store the extracted bufData by webclient
            byte[] bufData = null;
            bufData = web.DownloadData(strURL);
            // got the bufData now convert it into string form
            firstLevelbufData = Encoding.Default.GetString(bufData);
        }
        catch (System.Net.WebException ex)
        {
            // this exception will be fired when the host name is not resolved or any other connection problem
            txtResult.Text = ex.Message.ToString();
            return;
        }
        try
        {
            // first and last are the regular expression string for extraction bufData witnin two tags
            // you can change according to your requirement
            string first = null;
            string last = null;
            // chr(34) is used for (") symbol
            first = "<p class=\"text12\">";
            last = "</p>";

            Regex RE = new Regex(first + "(?<MYDATA>.*?(?=" + last + "))", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            // try to extract the bufData  within the first and last tag
            Match m = RE.Match(firstLevelbufData);
            // got the result
            txtResult.Text = m.Groups["MYDATA"].Value + "<br>";
            // check if no information abour that domain is available
            if (txtResult.Text.Length < 10) txtResult.Text = "Information about this domain is not available !!";
        }
        catch (System.Net.WebException)
        {
            txtResult.Text = "Sorry the whois information is currently not available !!";
        }
    }
}