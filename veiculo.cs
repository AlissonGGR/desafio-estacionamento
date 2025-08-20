ausing System;

namespace SistemaEstacionamento
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public double Km { get; set; }
        public DateTime HoraEntrada { get; set; }

        public Veiculo(string placa, string tipo, double km)
        {
            Placa = placa;
            Tipo = tipo;
            Km = km;
            HoraEntrada = DateTime.Now; 
        }
    }
}
