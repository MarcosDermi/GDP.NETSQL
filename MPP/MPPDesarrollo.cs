using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPPDesarrollo
    {
        public MPPDesarrollo()
        {
            oDatos = new Datos();
        }

        Datos oDatos;

        public List<BEDesarrollo> ListarTodo()
        {
            List<BEDesarrollo> LTareas = new List<BEDesarrollo>();

            string ConsultaSQL = "SELECT * From Tareas Where Categoria = 'Desarrollo'";

            DataTable Tabla = oDatos.Leer(ConsultaSQL);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {

                    BEDesarrollo oBEDesa = new BEDesarrollo(fila["Descripcion"].ToString());
                    oBEDesa.codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEDesa.nombre = fila["Nombre"].ToString();
                    oBEDesa.Valor = Convert.ToDouble(fila["Valor"]);

                    LTareas.Add(oBEDesa);
                }

            }
            else
            {
                LTareas = null;
            }
            return LTareas;
        }

        public bool Guardar(BEDesarrollo oBEDesa)
        {
            string Consulta = string.Format("INSERT INTO Tareas (Nombre, Categoria, Valor, Descripcion) VALUES('{0}', '{1}', {2}, '{3}')",
            oBEDesa.nombre, "Desarrollo", oBEDesa.Valor, oBEDesa.Desc);
            return oDatos.Escribir(Consulta);
        }

        public bool GuardarTareaEquipo(BEEquipo oBEEquipo, BEDesarrollo oBEDesa)
        {
            string Consulta;
            BEDesarrollo oBEDesaBUSCADA = new BEDesarrollo(string.Empty);
            oBEDesaBUSCADA = ListarObjeto(oBEDesa);
            if (oBEDesaBUSCADA.codigo != 0)
            {
                Consulta = string.Format("Insert into EquipoTarea(CodEquipo, CodTarea) values({0},{1})", oBEEquipo.Codigo, oBEDesaBUSCADA.codigo);
                return oDatos.Escribir(Consulta);
            }
            else
            {
                return false;
            }
        }

        public bool Baja(BEPrueba Objeto)
        {
            throw new NotImplementedException();
        }



        public BEDesarrollo ListarObjeto(BEDesarrollo oBEDesa)
        {
            string Consulta = "SELECT * From Tareas WHERE Nombre = '" + oBEDesa.nombre + "'";

            DataTable Tabla = oDatos.Leer(Consulta);

            if (Tabla.Rows.Count > 0)

            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEDesarrollo oBED = new BEDesarrollo(fila["Descripcion"].ToString());
                    oBED.codigo = Convert.ToInt32(fila["Codigo"]);
                    oBED.nombre = fila["Nombre"].ToString();
                    oBED.Valor = Convert.ToDouble(fila["Valor"]);

                    return oBED;



                }
            }
            return null;
        }
    }
}
