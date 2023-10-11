using System.Runtime.Serialization;

namespace Strategy
{
    public class Disciplina
    {
        private IcalcMedia _calcMedia;
        public IcalcMedia CalcMedia
        {
            get
            {
                return _calcMedia;
            }
            set
            {
                _calcMedia = value;
            }
        }

        public double Media { get; set; }

        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        private double _p1;
        public double P1
        {
            get
            {
                return _p1;
            }
            set
            {
                _p1 = value;
            }
        }

        private double _p2;
        public double P2
        {
            get
            {
                return _p2;
            }
            set
            {
                _p2 = value;
            }
        }

        public string Situacao { get; private set; }
        public Disciplina(IcalcMedia calculo, double p1, double p2)
        {
            CalcMedia = calculo;
            _p1 = p1;
            _p2 = p2;
        }

        public void CalcularMedia()
        {
            Media = CalcMedia.CalculaMedia(P1, P2);
            Situacao = CalcMedia.Situacao();
        }
    }
}