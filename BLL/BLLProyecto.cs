using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLLProyecto : IGestor<BEProyecto>
    {
        public BLLProyecto()
        {
            oMPPProyecto = new MPPProyecto();
        }

        MPPProyecto oMPPProyecto;
        public bool Baja(BEProyecto Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BEProyecto Objeto)
        {
            return oMPPProyecto.Guardar(Objeto);
        }

        public bool GuardarProyectoEquipo(BEProyecto oBEPro, BEEquipo oBEEquipo)
        {
            return oMPPProyecto.GuardarProyectoEquipo(oBEPro, oBEEquipo);
        }

        public BEProyecto ListarObjeto(BEProyecto oBEPro)
        {
            return oMPPProyecto.ListarObjeto(oBEPro);
        }

        public List<BEProyecto> ListarTodo()
        {
            return oMPPProyecto.ListarTodo();
        }
    }
}
