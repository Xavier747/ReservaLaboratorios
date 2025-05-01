using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservaLaboratorios
{
    public partial class SistemaLaboratorio : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tipoPermiso = Session["Permisos"].ToString();
            // Comprobar si la variable de sesión "Permisos" no es nula

            itemLaboratorio.Attributes["style"] = tipoPermiso != null && (tipoPermiso == "ADMINISTRADOR" || tipoPermiso == "LABORATORISTA") ? "display: block;" : "display: none;";
            itemDocente.Attributes["style"] = tipoPermiso != null && tipoPermiso == "DOCENTE" ? "display: block;" : "display: none;";
        }
    }
}