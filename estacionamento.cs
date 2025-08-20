using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaEstacionamento
{
    public class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private List<string> historico = new List<string>();

        // Tabela de preços por tipo
        private Dictionary<string, (decimal precoInicial, decimal precoHora)> tabelaPrecos =
            new Dictionary<string, (decimal, decimal)>
            {
                { "Luxo", (30.0m, 15.0m) },
                { "SUV", (20.0m, 10.0m) },
                { "Popular", (10.0m, 5.0m) },
                { "Moto", (5.0m, 2.0m) },
                { "Caminhao", (40.0m, 20.0m) }
            };

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite o tipo do veículo (Luxo, SUV, Popular, Moto, Caminhao):");
            string tipo = Console.ReadLine();

            if (!tabelaPrecos.ContainsKey(tipo))
            {
                Console.WriteLine("Tipo inválido! Usando 'Popular' por padrão.");
                tipo = "Popular";
            }

            Console.WriteLine("Digite a quilometragem atual do veículo:");
            double km = Convert.ToDouble(Console.ReadLine());

            Veiculo v = new Veiculo(placa, tipo, km);
            veiculos.Add(v);

            Console.WriteLine($"Veículo {placa} ({tipo}) adicionado às {v.HoraEntrada}");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();

            Veiculo veiculo = veiculos.FirstOrDefault(v => v.Placa == placa);

            if (veiculo != null)
            {
                DateTime horaSaida = DateTime.Now;
                TimeSpan tempo = horaSaida - veiculo.HoraEntrada;
                int horas = (int)Math.Ceiling(tempo.TotalHours); // arredonda pra cima

                var (precoInicial, precoHora) = tabelaPrecos[veiculo.Tipo];
                decimal valorTotal = precoInicial + precoHora * horas;

                veiculos.Remove(veiculo);

                string resumo = $"Placa: {veiculo.Placa} | Tipo: {veiculo.Tipo} | " +
                                $"Tempo: {horas}h | Valor: R$ {valorTotal}";
                historico.Add(resumo);

                Console.WriteLine($"Veículo {placa} removido. Tempo: {horas}h. Valor a pagar: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (var v in veiculos)
                {
                    Console.WriteLine($"Placa: {v.Placa} | Tipo: {v.Tipo} | Km: {v.Km} | Entrada: {v.HoraEntrada}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo estacionado.");
            }
        }

        public void ListarHistorico()
        {
            if (historico.Any())
            {
                Console.WriteLine("Histórico de veículos atendidos:");
                foreach (var h in historico)
                {
                    Console.WriteLine(h);
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo removido ainda.");
            }
        }
    }
}
