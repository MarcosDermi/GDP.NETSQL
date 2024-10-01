using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLLDesarrollo : IGestor<BEDesarrollo>
    {
        public BLLDesarrollo()
        {
            MPPDesarrollo oMPPDesa = new MPPDesarrollo();
        }

        MPPDesarrollo oMPPDesa = new MPPDesarrollo();

        public bool Guardar(BEDesarrollo oBEDesa)
        {
            return oMPPDesa.Guardar(oBEDesa);
        }

        public bool GuardarTareaEquipo(BEDesarrollo oBEDesa, BEEquipo oBEEquipo)
        {
            return oMPPDesa.GuardarTareaEquipo(oBEEquipo, oBEDesa);
        }
        public bool Baja(BEDesarrollo Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEDesarrollo> ListarTodo()
        {
            return oMPPDesa.ListarTodo();
        }

        public BEDesarrollo ListarObjeto(BEDesarrollo Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
