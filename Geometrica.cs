namespace Strategy
{
    public class Geometrica : IcalcMedia
    {
        public double P1 { get; set; }
        public double P2 { get; set; }
        public string TipoDeMedia { get; set; }

        public Geometrica()
        {
            TipoDeMedia = "Geometrica";
        }
        public const double NotaMinima = 7;
        public double CalculaMedia(double p1, double p2)
        {
            return Math.Sqrt(p1 + p2);
        }

        public string Situacao() =>
        CalculaMedia(P1, P2) > 7.0 ? "Aprovado" : "Reprovado";

    }
}