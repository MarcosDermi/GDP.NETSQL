using System.Collections.Generic;
using TP_2___FInal.Clases.clsTareas;

namespace BE
{
    public class BEEquipo
    {
        public string Nombre { get; set; }

        public int Codigo { get; set; }

        public string Estado { get; set; }

        //Lista 1 a muchos
        public List<BETarea> ListaTareas { get; set; }



        //Contador
        public static int CantEquipos = 0;

        //Contructor
        public BEEquipo()
        {

        }


        public override string ToString()
        {
            return Nombre;
        }
    }
}
