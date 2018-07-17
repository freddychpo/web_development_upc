using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            ClsUsuario Usuario = new ClsUsuario(username.Value.ToString(), password.Value.ToString());
            if (Usuario.ConsultarUsuario() == false)
            {
                LblError.Text = "El usuario o contraseña son incorrectos";
            }
            else
            {
                LblError.Text = "";
            }
        }
    }
}