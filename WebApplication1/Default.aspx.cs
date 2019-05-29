using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            VoucherNegocio voucher = new VoucherNegocio();
            if(voucher.listarVoucher(txtCodigo.Text))
            {
                Response.Redirect("~/Catalogo.aspx");
            }
        }
    }
}