using System;
using System.Collections.Generic;
using System.Web;
using System.IO;

/// <summary>
/// Summary description for HataLog
/// </summary>
public class HataLog
{
	public HataLog()
	{
		//
		// TODO: Add constructor logic here
		//
	}
       public void DosyaOlustur(string _strDosyaAdresIsim, string _strYazi)
        {
            StreamWriter dosya;
            dosya = File.AppendText(_strDosyaAdresIsim);
            dosya.WriteLine(_strYazi);
            dosya.Close();
        }
}