using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLLPrueba : IGestor<BEPrueba>
    {
        public BLLPrueba()
        {
            MPPPrueba oMPPPrueba = new MPPPrueba();
        }

        MPPPrueba oMPPPrueba = new MPPPrueba();

        public List<BEPrueba> ListarTodo()
        {
            return oMPPPrueba.ListarTodo();
        }

        public bool Guardar(BEPrueba oBEPrueba)
        {
            return oMPPPrueba.Guardar(oBEPrueba);
        }

        public bool GuardarTareaEquipo(BEPrueba oBEPrueba, BEEquipo oBEEquipo)
        {
            return oMPPPrueba.GuardarTareaEquipo(oBEEquipo, oBEPrueba);
        }

        public bool Baja(BEPrueba oBEPrueba)
        {
            return oMPPPrueba.Baja(oBEPrueba);
        }



        public BEPrueba ListarObjeto(BEPrueba oBEPrueba)
        {
            throw new NotImplementedException();
        }

        //public override void PresupuestarHoras()
        //{

        //    Valor *= 0.10;
        //}

        //public override BEEnum.Estados DevolverEstado()
        //{
        //    return BEEnum.Estados.Iniciada;
        //}
    }
}
