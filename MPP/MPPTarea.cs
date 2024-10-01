using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using TP_2___FInal.Clases.clsTareas;

namespace MPP
{
    public class MPPTarea : IGestor<BETarea>
    {

        public MPPTarea()
        {
            Datos oDatos = new Datos();
        }

        Datos oDatos;
        public bool Baja(BETarea oBETarea)
        {
            try
            {
                string ConsultaSQL = "DELETE From Tareas where Codigo =" + oBETarea.codigo;
                oDatos = new Datos();
                return oDatos.Escribir(ConsultaSQL);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Guardar(BETarea oBETarea)
        {
            if (oBETarea.codigo == 0)
            {
                string Consulta = string.Format("INSERT INTO Tareas (Nombre, Categoria, Valor) VALUES('{0}', '{1}', {2},)",
                oBETarea.nombre, "Prueba", oBETarea.Valor);

                return oDatos.Escribir(Consulta);
            }
            else
            {

                string Consulta = string.Format("UPDATE Tareas SET Nombre = '" + oBETarea.nombre + "' ,Valor = '" + oBETarea.Valor + "' WHERE Codigo = " + oBETarea.codigo);
                return oDatos.Escribir(Consulta);
            }
        }

        public BETarea ListarObjeto(BETarea Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BETarea> ListarTodo()
        {
            List<BETarea> LTareas = new List<BETarea>();

            string ConsultaSQL = "SELECT * FROM Tareas";

            oDatos = new Datos();

            DataTable Tabla = oDatos.Leer(ConsultaSQL);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    if (fila["Categoria"].ToString() == "Prueba")
                    {
                        BEPrueba oBEPrueba = new BEPrueba();
                        oBEPrueba.codigo = Convert.ToInt32(fila["Codigo"]);
                        oBEPrueba.nombre = fila["Nombre"].ToString();
                        string Prueba = fila["Categoria"].ToString();
                        oBEPrueba.Valor = Convert.ToDouble(fila["Valor"]);
                        oBEPrueba.fechafinalizacion = fila["Fecha finalizacion"].ToString();


                        LTareas.Add(oBEPrueba);
                    }
                    else
                    {
                        BEDesarrollo oBEDesa = new BEDesarrollo(fila["Descripcion"].ToString());
                        oBEDesa.codigo = Convert.ToInt32(fila["Codigo"]);
                        oBEDesa.nombre = fila["Nombre"].ToString();
                        oBEDesa.Valor = Convert.ToDouble(fila["Valor"]);
                        LTareas.Add(oBEDesa);
                    }
                }

            }
            else
            {
                LTareas = null;
            }
            return LTareas;
        }
    }
}
