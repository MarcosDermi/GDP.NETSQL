using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MPP
{
    public class MPPPrueba : IGestor<BEPrueba>
    {
        public MPPPrueba()
        {
            oDatos = new Datos();
        }

        Datos oDatos;

        public List<BEPrueba> ListarTodo()
        {
            List<BEPrueba> LTareas = new List<BEPrueba>();

            string ConsultaSQL = "SELECT * From Tareas Where Categoria = 'Prueba'";

            DataTable Tabla = oDatos.Leer(ConsultaSQL);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {

                    BEPrueba oBEPrueba = new BEPrueba();
                    oBEPrueba.codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEPrueba.nombre = fila["Nombre"].ToString();
                    string Prueba = fila["Categoria"].ToString();
                    oBEPrueba.fechafinalizacion = fila["Fecha finalizacion"].ToString();

                    LTareas.Add(oBEPrueba);
                }

            }
            else
            {
                LTareas = null;
            }
            return LTareas;
        }

        public bool Guardar(BEPrueba oBEPrueba)
        {
            if(oBEPrueba.codigo == 0) { 
            string Consulta = string.Format("INSERT INTO Tareas (Nombre, Categoria, Valor, [Fecha finalizacion]) VALUES('{0}', '{1}', {2}, '{3}')",
            oBEPrueba.nombre, "Prueba", oBEPrueba.Valor, Convert.ToDateTime(oBEPrueba.fechafinalizacion).ToString("yyyy-MM-dd HH:mm:ss"));

            return oDatos.Escribir(Consulta);
            }
            else
            {
            
                string Consulta = string.Format("UPDATE Tareas SET Nombre = '" + oBEPrueba.nombre + "' Valor = '" + oBEPrueba.Valor  + "WHERE Codigo = "  + oBEPrueba.codigo );
            return oDatos.Escribir(Consulta);
            }
        }

        public bool GuardarTareaEquipo(BEEquipo oBEEquipo, BEPrueba oBEPrueba)
        {
            string Consulta;
            BEPrueba oBEPruebaBUSCADA = new BEPrueba();
            oBEPruebaBUSCADA = ListarObjeto(oBEPrueba);
            if (oBEPruebaBUSCADA.codigo != 0)
            {
                Consulta = string.Format("Insert into EquipoTarea(CodEquipo, CodTarea) values({0},{1})", oBEEquipo.Codigo, oBEPruebaBUSCADA.codigo);
                return oDatos.Escribir(Consulta);
            }
            else
            {
                return false;
            }
        }

        public bool Baja(BEPrueba oBEPrueba)
        {
            try
            {
                string ConsultaSQL = "DELETE From Tareas where Codigo = " + oBEPrueba.codigo + "";
                return oDatos.Escribir(ConsultaSQL);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        List<BEPrueba> IGestor<BEPrueba>.ListarTodo()
        {
            throw new NotImplementedException();
        }

        public BEPrueba ListarObjeto(BEPrueba oBEPrueba)
        {
            string Consulta = "SELECT * From Tareas WHERE [Fecha finalizacion] = '" + Convert.ToDateTime(oBEPrueba.fechafinalizacion).ToString("yyyy-MM-dd HH:mm:ss") + "'";

            DataTable Tabla = oDatos.Leer(Consulta);

            if (Tabla.Rows.Count > 0)

            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEPrueba oBEP = new BEPrueba();
                    oBEP.codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEP.nombre = fila["Nombre"].ToString();
                    oBEP.Valor = Convert.ToDouble(fila["Valor"]);
                    oBEP.fechafinalizacion = fila["Fecha finalizacion"].ToString();
                    return oBEP;



                }
            }
            return null;
        }
    }
}
