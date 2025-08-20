using System;
using SistemaEstacionamento;

class Program
{
    static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento();
        bool rodando = true;

        while (rodando)
        {
            Console.WriteLine("\n==== SISTEMA DE ESTACIONAMENTO ====");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos estacionados");
            Console.WriteLine("4 - Listar histórico");
            Console.WriteLine("5 - Encerrar");
            Console.Write("Escolha: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": estacionamento.AdicionarVeiculo(); break;
                case "2": estacionamento.RemoverVeiculo(); break;
                case "3": estacionamento.ListarVeiculos(); break;
                case "4": estacionamento.ListarHistorico(); break;
                case "5": rodando = false; Console.WriteLine("Sistema encerrado."); break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }
}
