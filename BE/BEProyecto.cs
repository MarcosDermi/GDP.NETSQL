namespace BE
{
    public class BEProyecto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        
        public string Estado { get; set; }
        //contador
        public static int CantProyecto = 0;

        //1 a 1
        public BEEquipo Equipo { get; set; }

        //constructor para codigo random
        public BEProyecto()
        {

        }

        public override string ToString()
        {
            return $" {Nombre}";
        }
    }
}
