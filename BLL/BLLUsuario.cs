using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLLUsuario : IGestor<BEUsuario>
    {
        public BLLUsuario()
        {
            oMMPUsuario = new MPPUsuario();
        }

        MPPUsuario oMMPUsuario;

        public bool Guardar(BEUsuario Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Baja(BEUsuario Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEUsuario> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public bool Validar(BEUsuario Objeto)
        {
            return oMMPUsuario.ValidadLogin(Objeto);
        }

        BEUsuario IGestor<BEUsuario>.ListarObjeto(BEUsuario Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
