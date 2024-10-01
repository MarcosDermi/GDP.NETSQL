using TP_2___FInal.Clases.clsTareas;

namespace BE
{
    public class BEDesarrollo : BETarea
    {
        public string Desc { get; set; }

        public static int CantTareaDesa = 0;

        //constructor sobrecargado
        public BEDesarrollo(string Desc)
        {
            this.Desc = Desc;
        }







    }
}
