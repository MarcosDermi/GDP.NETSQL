using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using TP_2___FInal.Clases.clsTareas;

namespace MPP
{
    public class MPPEquipo : IGestor<BEEquipo>
    {
        public MPPEquipo()
        {
            oDatos = new Datos();
        }

        Datos oDatos;

        public List<BEEquipo> ListarTodo()
        {
            List<BEEquipo> LEquipo = new List<BEEquipo>();

            string ConsultaSQL = "SELECT * FROM Equipos";

            DataTable Tabla = oDatos.Leer(ConsultaSQL);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEEquipo oBEEquipo = new BEEquipo();
                    oBEEquipo.Codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEEquipo.Nombre = fila["Nombre"].ToString();
                    oBEEquipo.Estado = fila["Estado"].ToString();

                    Datos oDatos2 = new Datos();
                    DataTable Tabla2 = oDatos2.Leer("SELECT T.Codigo, T.Nombre, T.Categoria, T.Valor,T.[Fecha finalizacion] ,T.Descripcion\r\nFROM EquipoTarea, Equipos as E, Tareas as T\r\nWhere EquipoTarea.CodTarea = T.Codigo and EquipoTarea.CodEquipo= E.Codigo and E.Codigo=" + oBEEquipo.Codigo);

                    List<BETarea> LTareas = new List<BETarea>();
                    if (Tabla2.Rows.Count > 0)
                    {
                        foreach (DataRow fila2 in Tabla2.Rows)
                        {
                            if (fila2["Descripcion"] is DBNull)
                            {
                                BEPrueba oBEPrueba = new BEPrueba();
                                oBEPrueba.codigo = Convert.ToInt32(fila2["Codigo"]);
                                oBEPrueba.nombre = fila2["Nombre"].ToString();
                                oBEPrueba.fechafinalizacion = fila2["Fecha finalizacion"].ToString();
                                oBEPrueba.Valor = Convert.ToDouble(fila2["Valor"]);
                                LTareas.Add(oBEPrueba);
                            }
                            else
                            {
                                BEDesarrollo oBEDesa = new BEDesarrollo(fila2["Descripcion"].ToString());
                                oBEDesa.codigo = Convert.ToInt32(fila2["Codigo"]);
                                oBEDesa.nombre = fila2["Nombre"].ToString();
                                oBEDesa.Valor = Convert.ToDouble(fila2["Valor"]);
                                LTareas.Add(oBEDesa);
                            }
                        }
                        oBEEquipo.ListaTareas = LTareas;
                    }

                    LEquipo.Add(oBEEquipo);
                }

            }
            return LEquipo;
        }

        public bool Guardar(BEEquipo oBEEquipo)
        {
            string ConsultaSQL = string.Empty;

            if (oBEEquipo.Codigo == 0)
            {
                ConsultaSQL = string.Format("INSERT INTO Equipos(Nombre, Estado) values ('{0}','{1}')", oBEEquipo.Nombre, oBEEquipo.Estado);
            }
            else
            {
                ConsultaSQL = string.Format("UPDATE Equipos SET Nombre= '{0}' Where Codigo = '{1}'", oBEEquipo.Nombre, oBEEquipo.Codigo);
            }

            return oDatos.Escribir(ConsultaSQL);
        }

        public bool Baja(BEEquipo oBEEquipo)
        {
            string ConsultaSQL = string.Format("DELETE FROM Equipos where Codigo =" + oBEEquipo.Codigo + "");
            oDatos = new Datos();
            return oDatos.Escribir(ConsultaSQL);
        }

        public BEEquipo ListarObjeto(BEEquipo oBEEquipo)
        {
            throw new NotImplementedException();
        }
    }
}
