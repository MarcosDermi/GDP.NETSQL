using BE;
using MPP;
using System;
using System.Collections.Generic;
using TP_2___FInal.Clases.clsTareas;

namespace BLL
{
    public class BLLTarea : IGestor<BETarea>
    {
        public BLLTarea()
        {
            oMPPTarea = new MPPTarea();
        }

        MPPTarea oMPPTarea;
        //public abstract void PresupuestarHoras();

        public virtual BEEnum.Estados DevolverEstado()
        {
            return DevolverEstado();
        }

        public bool Guardar(BETarea oBETarea)
        {
            return oMPPTarea.Guardar(oBETarea);
        }

        public bool Baja(BETarea oBETarea)
        {
            return oMPPTarea.Baja(oBETarea);
        }

        public List<BETarea> ListarTodo()
        {
            return oMPPTarea.ListarTodo();
        }

        public BETarea ListarObjeto(BETarea Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
