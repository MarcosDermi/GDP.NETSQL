using TP_2___FInal.Clases.clsTareas;

namespace BE
{
    public class BEPrueba : BETarea
    {
        public string fechafinalizacion { get; set; }

        public static int CantTareaPrueba = 0;

        //contructor vacio
        public BEPrueba() { }

        public override string ToString()
        {
            return nombre + " " + " " + fechafinalizacion;
        }
    }
}
