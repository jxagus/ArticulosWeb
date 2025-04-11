﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArticulosWeb
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            lblEnviar.Text = "Gracias por enviarnos mensaje, en breve solucionaremos tus dudas😊";
            lblEnviar.Visible = true;
            // Agregar un script para ocultar el label después de 4 segundos
            string script = "<script>setTimeout(function() { document.getElementById('" + lblEnviar.ClientID + "').style.display = 'none'; }, 5000);</script>";
            ClientScript.RegisterStartupScript(this.GetType(), "HideLabel", script);
        }
    }
}