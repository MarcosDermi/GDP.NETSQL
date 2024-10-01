using System;

namespace BE
{
    public class clsErrorPersonalizado : Exception
    {
        public override string Message
        {
            get
            {
                return string.Format("No se puede ingresar numeros negativos o 0");
            }

        }

    }
}
