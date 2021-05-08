using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dortislem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int sayi1 = int.Parse(TextBox1.Text);
        int sayi2 = int.Parse(TextBox2.Text);
        int secim = DropDownList1.SelectedIndex;
        switch (secim)
        {
            case 0:
                TextBox3.Text = (sayi1 + sayi2).ToString();
                break;
            case 1:
                TextBox3.Text = (sayi1 - sayi2).ToString();
                break;
            case 2:
                TextBox3.Text = (sayi1 * sayi2).ToString();
                break;
            case 3:
                TextBox3.Text = (((double)sayi1 / (double)sayi2)).ToString();
                break;
            default:
                TextBox3.Text = "Hatalı tercih...";
                break;
        }
    }
}