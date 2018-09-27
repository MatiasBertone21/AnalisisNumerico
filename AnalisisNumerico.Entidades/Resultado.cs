namespace AnalisisNumerico.Entidades
{
    public class ResultadoRaices
    {
        public double Raiz { get; set; }

        public double Iteraciones { get; set; }

        public double Error { get; set; }

        public string Mensaje { get; set; }
    }

    public class ResultadoSeidel
    {
        public double[,] Solucion { get; set; }
        public int Iteraciones { get; set; }
    }
}