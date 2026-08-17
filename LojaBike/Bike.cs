namespace LojaBike
{
    class Bike
    {
        public string Modelo { get; set; } = string.Empty;
        public double Bateria { get; set; }
        public double PesoCiclista { get; set; }
        public int RecargaMes { get; set; }

        public double CalcularAutonomia()
        {
            double autonomiaBase = Bateria / 15.0;
            bool pesoElevado = PesoCiclista > 90;

            return pesoElevado ? (autonomiaBase * 0.05) : autonomiaBase;
        }

        public double CalcularConsumoMensal()
        {
            double kmPorCarga = Bateria / 1000.0;
            return kmPorCarga * RecargaMes;
        }

        public double CalcularCustoMensal()
        {
            const double PRECO_KWH = 0.80;
            return CalcularConsumoMensal() * PRECO_KWH;
        }

        public bool ModeloEconomico()
        {
            return (CalcularCustoMensal() < 15.00) || (CalcularAutonomia() > 40.0);
        }
    }
}