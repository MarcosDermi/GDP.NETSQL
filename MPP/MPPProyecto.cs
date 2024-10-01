using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using TP_2___FInal.Clases.clsTareas;

namespace MPP
{
    public class MPPProyecto : IGestor<BEProyecto>
    {
        public MPPProyecto()
        {
            oDatos = new Datos();
        }

        Datos oDatos;

        public bool Baja(BEProyecto Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEProyecto oBEProyecto)
        {
            string ConsultaSQL = string.Empty;

            if (oBEProyecto.Codigo == 0)
            {
                string ConsultaCambioEstado = string.Format("UPDATE Equipos SET Estado = 'Asociado' WHERE Codigo = " + oBEProyecto.Equipo.Codigo);
                oDatos.Escribir(ConsultaCambioEstado);

                ConsultaSQL = string.Format("INSERT INTO Proyectos(Nombre, Equipo) values ('{0}','{1}') ", oBEProyecto.Nombre, oBEProyecto.Equipo.Codigo);
            }
            else if(oBEProyecto.Estado == "Finalizado")
            {
                string ConsultaBorrarTareas = string.Format("DELETE FROM Tareas WHERE Codigo IN (SELECT et.CodTarea FROM EquipoTarea et GROUP BY et.CodTarea HAVING COUNT(DISTINCT et.CodEquipo) = 1 AND MAX(et.CodEquipo) = ' " + oBEProyecto.Equipo.Codigo + "');");
                oDatos.Escribir(ConsultaBorrarTareas);
                string ConsultaCambioEstado = string.Format("UPDATE Equipos SET Estado = 'Sin proyecto asociado' WHERE Codigo = " + oBEProyecto.Equipo.Codigo);
                oDatos.Escribir(ConsultaCambioEstado);
                ConsultaSQL = string.Format("UPDATE Proyectos SET Estado='Finalizado' WHERE Codigo = " + oBEProyecto.Codigo);
            }
            else
            {
                ConsultaSQL = string.Format("UPDATE Proyectos SET Nombre= '" + oBEProyecto.Nombre + " ' WHERE Codigo = " + oBEProyecto.Codigo);
            }

            return oDatos.Escribir(ConsultaSQL);
        }

        public bool GuardarProyectoEquipo(BEProyecto oBEPro, BEEquipo oBEEquipo)
        {
            string Consulta;
            BEProyecto oBEProBuscada = new BEProyecto();
            oBEProBuscada = ListarObjeto(oBEPro);
            if (oBEProBuscada.Codigo != 0)
            {
                Consulta = string.Format("Insert into ProyectoEquipo(CodProyecto, CodEquipo) values({0},{1})", oBEProBuscada.Codigo, oBEEquipo.Codigo);
                return oDatos.Escribir(Consulta);
            }
            else
            {
                return false;
            }
        }

        public BEProyecto ListarObjeto(BEProyecto oBEPro)
        {
            string Consulta = "SELECT * From Proyectos WHERE Nombre = '" + oBEPro.Nombre + "'";

            DataTable Tabla = oDatos.Leer(Consulta);

            if (Tabla.Rows.Count > 0)

            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEProyecto oBEProEncontrado = new BEProyecto();
                    oBEProEncontrado.Codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEProEncontrado.Nombre = fila["Nombre"].ToString();
                    oBEProEncontrado.Equipo.Codigo = Convert.ToInt32(fila["Codigo"]);


                    return oBEProEncontrado;



                }
            }
            return null;
        }

        public List<BEProyecto> ListarTodo()
        {
            List<BEProyecto> LProyecto = new List<BEProyecto>();

            string ConsultaSQL = "SELECT Proyectos.Codigo, Proyectos.Nombre, Proyectos.Estado, Proyectos.Equipo, Equipos.Codigo as CodEquipo, Equipos.Nombre as NombreEquipo \r\nFROM Proyectos, Equipos Where Proyectos.Equipo = Equipos.Codigo";

            DataTable Tabla = oDatos.Leer(ConsultaSQL);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEProyecto oBEPRO = new BEProyecto();
                    oBEPRO.Codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEPRO.Nombre = fila["Nombre"].ToString();
                    oBEPRO.Estado = fila["Estado"].ToString();

                    BEEquipo oBEEquipo = new BEEquipo();
                    oBEEquipo.Codigo = Convert.ToInt32(fila["CodEquipo"]);
                    oBEEquipo.Nombre = fila["NombreEquipo"].ToString();
                    oBEEquipo.Estado = "Asociado";
                    oBEPRO.Equipo = oBEEquipo;

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

                    LProyecto.Add(oBEPRO);
                }
            }
            return LProyecto;
        }
    }
}
