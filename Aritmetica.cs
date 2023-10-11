namespace Strategy
{
    public class Aritmetica : IcalcMedia
    {
        public double P1 { get; set; }
        public double P2 { get; set; }
        public string TipoDeMedia { get; set; }

        public Aritmetica()
        {
            TipoDeMedia = "Aritmética";
        }

        public double CalculaMedia(double p1, double p2)
        {
            P1 = p1;
            P2 = p2;
            return (p1 + p2) / 2;
        }

        public string Situacao() =>
        CalculaMedia(P1, P2) > 5.0 ? "Aprovado" : "Reprovado";

    }
}