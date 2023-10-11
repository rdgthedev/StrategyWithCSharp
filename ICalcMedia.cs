namespace Strategy
{
    public interface IcalcMedia
    {
        public double P1 { get; set; }
        public double P2 { get; set; }
        public string TipoDeMedia { get; set; }
        public double CalculaMedia(double p1, double p2);
        public string Situacao();
    }
}