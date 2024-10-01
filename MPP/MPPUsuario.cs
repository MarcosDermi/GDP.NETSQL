using BE;
using DAL;
using System.Data;

namespace MPP
{
    public class MPPUsuario
    {
        public MPPUsuario()
        {
            Datos oDatos = new Datos();
        }

        Datos oDatos;



        public bool ValidadLogin(BEUsuario oBEUsu)
        {


            string ConsultaSQL = string.Format("SELECT * FROM Usuarios WHERE usuario = '{0}'", oBEUsu.Usuario);

            oDatos = new Datos();
            DataTable Tabla = oDatos.Leer(ConsultaSQL);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    oBEUsu.Usuario = fila["Usuario"].ToString();
                    oBEUsu.Pass = fila["Contrasena"].ToString();
                    return true;
                }
            }
            return false;
        }
    }
}