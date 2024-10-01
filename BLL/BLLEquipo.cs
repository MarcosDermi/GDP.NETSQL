using BE;
using MPP;
using System;
using System.Collections.Generic;


namespace BLL
{
    public class BLLEquipo : IGestor<BEEquipo>
    {
        public BLLEquipo()
        {
            oMPPEquipo = new MPPEquipo();
        }

        MPPEquipo oMPPEquipo;

        public List<BEEquipo> ListarTodo()
        {
            return oMPPEquipo.ListarTodo();
        }

        public bool Guardar(BEEquipo oBEEquipo)
        {
            return oMPPEquipo.Guardar(oBEEquipo);
        }

        public bool Baja(BEEquipo oBEEquipo)
        {
            return oMPPEquipo.Baja(oBEEquipo);
        }

        public BEEquipo ListarObjeto(BEEquipo Objeto)
        {
            throw new NotImplementedException();
        }

        //double Icalculable.CalcularTotal(BEEquipo oEquipo)
        //{
        //    double MontoTotal = 0;

        //    if (oEquipo.ListaTareas.Count > 0)
        //    {
        //        foreach (clsTarea item in oEquipo.ListaTareas)
        //        {

        //            MontoTotal += item.Valor;

        //        }

        //    }

        //    return MontoTotal;
        //}






    }
}
