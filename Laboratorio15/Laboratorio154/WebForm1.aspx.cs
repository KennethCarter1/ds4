using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio154
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txt1.Text);
            int numero2 = int.Parse(txt2.Text);

            resultado.Text = (numero1 + numero2).ToString();
        }
    }
}